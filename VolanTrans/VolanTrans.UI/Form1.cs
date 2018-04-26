using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolanTrans.Logic;
using VolanTrans.Logic.Helpers;
using VolanTrans.Logic.Model;

namespace VolanTrans.UI
{
    public partial class MainForm : Form
    {

        private Cars _cars;
        private CarsRepositoryHelper _carsRepositoryHelper;
        private bool _loaded;
        private int _selectedId = 0;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            try
            {
                LoadDataFirst();
                _loaded = true;
                radioButtonProp.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void dataGridViewMain_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMain.SelectedCells.Count > 0 && _loaded)
            {
                int selectedrowindex = dataGridViewMain.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewMain.Rows[selectedrowindex];

                var id = Convert.ToString(selectedRow.Cells["ID"].Value);
                int carId = 0;
                int.TryParse(id, out carId);
                if (_cars.GetList().Any(w => w.Id == carId)) LoadCarData(carId);

            }
        }


        private void LoadCarData(int id)
        {
            var car = _cars.GetList().FirstOrDefault(w => w.Id == id);
            if (car == null) return;
            textBoxProp.Text = car.Proprietar;
            textBoxMarca.Text = car.Marca;
            textBoxModel.Text = car.Model;
            textBoxTip.Text = car.Tip;
            textBoxNrImat.Text = car.NrdeImatriculare;
            textBoxNrsasiu.Text = car.NumarSasiu;
            dateTimePickerITP.Value = car.ITP;
            dateTimePickerRCA.Value = car.RCA;
            dateTimePickerAsgPers.Value = car.AsigPers;
            _selectedId = id;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var model = new CarModel();
            model.Proprietar = textBoxProp.Text;
            model.Marca = textBoxMarca.Text;
            model.Model = textBoxModel.Text;
            model.Tip = textBoxTip.Text;
            model.NrdeImatriculare = textBoxNrImat.Text;
            model.NumarSasiu = textBoxNrsasiu.Text;
            model.ITP = dateTimePickerITP.Value;
            model.RCA = dateTimePickerRCA.Value;
            model.AsigPers = dateTimePickerAsgPers.Value;
            model.Id = _selectedId;
            _cars.Add(model);
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _cars.Remove(_selectedId);
            LoadData();
        }

        private void LoadDataFirst()
        {
            dataGridViewMain.Rows.Clear();
            dataGridViewProblem.Rows.Clear();

            if (_carsRepositoryHelper == null) _carsRepositoryHelper = new CarsRepositoryHelper();
            List<CarModel> carList = _carsRepositoryHelper.GetCars();
            _cars = new Cars();

            var ccDays = ConfigurationManager.AppSettings["ConcernDays"];
            int cdays = 0;
            int.TryParse(ccDays, out cdays);
            if (cdays < 1) cdays = 5;

            var checkDay = DateTime.Today.AddDays(cdays);

            foreach (var item in carList)
            {
                _cars.InitAdd(item);
                dataGridViewMain.Rows.Add(item.Id, item.Proprietar, item.Marca, item.Tip, item.NumarSasiu);
                if (item.ITP.Date <= checkDay)
                {
                    MessageBox.Show(
                        $"ITP expira in {cdays} zile pentru autovechicolul cu nr matricol {item.NrdeImatriculare}!",
                        "Expirare");
                    dataGridViewProblem.Rows.Add(item.NrdeImatriculare, $"ITP {item.ITP}");
                }

                if (item.RCA.Date <= checkDay)
                {
                    MessageBox.Show(
                        $"RCA expira in {cdays} zile pentru autovechicolul cu nr matricol {item.NrdeImatriculare}!",
                        "Expirare");
                    dataGridViewProblem.Rows.Add(item.NrdeImatriculare, $"RCA {item.RCA}");
                }

                if (item.AsigPers.Date <= checkDay)
                {
                    MessageBox.Show(
                        $"Asigurarea personala expira in {cdays} zile pentru autovechicolul cu nr matricol {item.NrdeImatriculare}!",
                        "Expirare");
                    dataGridViewProblem.Rows.Add(item.NrdeImatriculare, $"Asig. pers. {item.AsigPers}");
                }
            }

            LoadCarData(carList.FirstOrDefault().Id);


        }

        private void LoadData(List<CarModel> dataList = null)
        {
            dataGridViewMain.Rows.Clear();
            dataGridViewProblem.Rows.Clear();

            if (_carsRepositoryHelper == null) _carsRepositoryHelper = new CarsRepositoryHelper();
            List<CarModel> carList = dataList;

            if (dataList == null) carList = _cars.GetList();
            var ccDays = ConfigurationManager.AppSettings["ConcernDays"];
            int cdays = 0;
            int.TryParse(ccDays, out cdays);
            if (cdays < 1) cdays = 5;

            var checkDay = DateTime.Today.AddDays(cdays);

            foreach (var item in carList)
            {
                dataGridViewMain.Rows.Add(item.Id, item.Proprietar, item.Marca, item.Tip, item.NumarSasiu);
                if (item.ITP.Date <= checkDay) dataGridViewProblem.Rows.Add(item.NrdeImatriculare, $"ITP {item.ITP}");
                if (item.RCA.Date <= checkDay) dataGridViewProblem.Rows.Add(item.NrdeImatriculare, $"RCA {item.RCA}");
                if (item.AsigPers.Date <= checkDay) dataGridViewProblem.Rows.Add(item.NrdeImatriculare, $"Asig. pers. {item.AsigPers}");
            }

            LoadCarData(_selectedId);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            List<CarModel> _resultList = new List<CarModel>();

            if (radioButtonProp.Checked)
                _resultList = _cars.GetList().Where(w => w.Proprietar.Trim().ToLower().StartsWith(textBox1.Text.Trim().ToLower())).ToList();
            else if (radioButtonInMat.Checked)
                _resultList = _cars.GetList().Where(w => w.NrdeImatriculare.Trim().ToLower().StartsWith(textBox1.Text.Trim().ToLower())).ToList();
            else if (radioButtonMarca.Checked)
                _resultList = _cars.GetList().Where(w => w.Marca.Trim().ToLower().StartsWith(textBox1.Text.Trim().ToLower())).ToList();
            else if (radioButtonSasiu.Checked)
                _resultList = _cars.GetList().Where(w => w.NumarSasiu.Trim().ToLower().StartsWith(textBox1.Text.Trim().ToLower())).ToList();
            else
                _resultList = _cars.GetList();

            LoadData(_resultList);
        }
    }
}
