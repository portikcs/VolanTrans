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
        private Persons _persons;
        private Renewables _renewables;
        private readonly CarsRepositoryHelper _carsRepositoryHelper;
        private readonly PersonsRepositoryHelper _personsRepositoryHelper;
        private readonly RenewablesRepositoryHelper _renewablesRepositoryHelper;
        private Guid _selectedRenew;
        private Guid _selectedCar;
        private Guid _selectedPerson;

        public MainForm()
        {
            InitializeComponent();
            _carsRepositoryHelper = new CarsRepositoryHelper();
            _personsRepositoryHelper = new PersonsRepositoryHelper();
            _renewablesRepositoryHelper = new RenewablesRepositoryHelper();
            _renewables = new Renewables();
            _cars = new Cars();
            _persons = new Persons();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }



        private void LoadData()
        {
            var renewList = _renewablesRepositoryHelper.GetRenewables();
            foreach (var itemRenew in renewList) _renewables.InitAdd(itemRenew);
            LoadRenew(_renewables.GetList().FirstOrDefault()?.Id ?? Guid.Empty);
            LoadRenewablesDataGrid(_renewables.GetList());

            var cars = _carsRepositoryHelper.GetCars();
            foreach (var itemCar in cars) _cars.InitAdd(itemCar);
            LoadCar(_cars.GetList().FirstOrDefault()?.Id ?? Guid.Empty);
            LoadCarDataGrid(_cars.GetList());

            var persons = _personsRepositoryHelper.GetPersons();
            foreach (var itemPerson in persons) _persons.InitAdd(itemPerson);
            LoadPerson(_persons.GetList().FirstOrDefault()?.Id ?? Guid.Empty);
            LoadPersonDataGrid(_persons.GetList());

        }

        private void LoadPerson(Guid id)
        {
            var person = _persons.GetList().FirstOrDefault(w => w.Id.Equals(id));
            if (person == null) return;
            textPersonName.Text = person.FullName;
            textPersonEmail.Text = person.Email;
            textPersonPhone.Text = person.Phone;
        }


        private void SavePerson()
        {
            var person = new PersonModel();
            person.Id = _selectedPerson != Guid.Empty ? _selectedPerson : Guid.NewGuid();
            person.FullName = textPersonName.Text;
            person.Email = textPersonEmail.Text;
            person.Phone = textPersonPhone.Text;

            if (string.IsNullOrWhiteSpace(person.FullName))
            {
                MessageBox.Show("Kérem, töltse ki a 'Név' mezőt!", "Error");
                return;
            }
            _persons.Add(person);
            LoadPersonDataGrid(_persons.GetList());
        }


        private void LoadCar(Guid id)
        {
            var car = _cars.GetList().FirstOrDefault(w => w.Id.Equals(id));
            if (car == null) return;
            textCarLp.Text = car.LicencePlate;
            textCarMM.Text = car.ModelAndMake;
            textCarYear.Text = car.Year.ToString();

        }

        private void SaveCar()
        {
            var car = new CarModel();
            car.Id = _selectedCar != Guid.Empty ? _selectedCar : Guid.NewGuid();
            car.LicencePlate = textCarLp.Text;
            car.ModelAndMake = textCarMM.Text;
            car.Year = textCarYear.Text;

            if (string.IsNullOrWhiteSpace(car.LicencePlate))
            {
                MessageBox.Show("Kérem, töltse ki a 'Rendszám' mezőt!", "Error");
                return;
            }
            _cars.Add(car);
            LoadCarDataGrid(_cars.GetList());
        }

        private void LoadCarDataGrid(List<CarModel> data)
        {
            if (data == null || !data.Any()) return;
            dataGridViewCar.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewCar.Rows.Add(item.Id, item.LicencePlate, item.ModelAndMake, item.Year);
                textRenewAppliesTo.AutoCompleteCustomSource.Add(item.LicencePlate);
            }

            _selectedCar = data.FirstOrDefault()?.Id ?? Guid.Empty;
        }


        private void LoadPersonDataGrid(List<PersonModel> data)
        {
            if (data == null || !data.Any()) return;
            dataGridViewPerson.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewPerson.Rows.Add(item.Id, item.FullName, item.Email, item.Phone);
                textRenewAppliesTo.AutoCompleteCustomSource.Add(item.FullName);
            }

            _selectedPerson = data.FirstOrDefault()?.Id ?? Guid.Empty;
        }


        private void LoadRenew(Guid id)
        {
            var renew = _renewables.GetList().FirstOrDefault(w => w.Id.Equals(id));
            if (renew == null) return;
            textRenewName.Text = renew.Name;
            textRenewAppliesTo.Text = renew.AppliesTo;
            dateTimePickerExp.Value = renew.ExpiryDate;
            richTextBoxRemarks.Text = renew.Remarks;
        }

        private void SaveRenew()
        {
            var renew = new RenewableModel();
            renew.Id = _selectedRenew != Guid.Empty ? _selectedRenew : Guid.NewGuid();
            renew.Name = textRenewName.Text;
            renew.AppliesTo = textRenewAppliesTo.Text;
            renew.ExpiryDate = dateTimePickerExp.Value;
            renew.Remarks = richTextBoxRemarks.Text;

            if (string.IsNullOrWhiteSpace(renew.Name) || string.IsNullOrWhiteSpace(renew.AppliesTo) ||
               !textRenewAppliesTo.AutoCompleteCustomSource.Contains(renew.AppliesTo.Trim()))
            {
                MessageBox.Show("A megadott név vagy rendszám még nem szerepel a rendszerben, kérem, próbálja újra a hiányzó adatok pótlása után!", "Error");
                return;
            }
            _renewables.Add(renew);
            LoadRenewablesDataGrid(_renewables.GetList());
        }

        private void LoadRenewablesDataGrid(List<RenewableModel> data)
        {
            if (data == null || !data.Any()) return;
            dataGridViewRenew.Rows.Clear();
            foreach (var item in data)
            {
                dataGridViewRenew.Rows.Add(item.Id, item.Name, item.AppliesTo, item.ExpiryDate.ToShortDateString(), item.Remarks);
                textRenewName.AutoCompleteCustomSource.Add(item.Name);
            }

            _selectedRenew = data.FirstOrDefault()?.Id ?? Guid.Empty;
            LoadAlert(data);
        }


        private void LoadAlert(List<RenewableModel> alertList)
        {
            if (alertList == null || !alertList.Any()) return;

            var ccDays = ConfigurationManager.AppSettings["ConcernDays"];
            int cdays = 0;
            int.TryParse(ccDays, out cdays);
            if (cdays < 1) cdays = 30;

            var checkDay = DateTime.Today.AddDays(cdays);

            dataGridViewAlert.Rows.Clear();
            foreach (var item in alertList)
            {
                if (item.ExpiryDate <= checkDay)
                    dataGridViewAlert.Rows.Add(item.ExpiryDate, item.Name, item.AppliesTo, item.Remarks);
            }
        }

        private void dataGridViewRenew_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRenew.SelectedRows.Count > 0)
            {

                string idstring = dataGridViewRenew.SelectedRows[0].Cells["RenewId"].Value.ToString();
                _selectedRenew = Guid.Parse(idstring);
                LoadRenew(_selectedRenew);
            }
        }

        private void btnRenewSave_Click(object sender, EventArgs e)
        {

            SaveRenew();
            dataGridViewRenew.AllowUserToAddRows = false;
            ClearRenewables();

        }

        private void btnRenewDelete_Click(object sender, EventArgs e)
        {
            dataGridViewRenew.ClearSelection();
            dataGridViewRenew.Rows.Clear();
            dataGridViewRenew.AllowUserToAddRows = true;
            dataGridViewRenew.AllowUserToDeleteRows = true;
            dataGridViewAlert.ClearSelection();
            dataGridViewAlert.Rows.Clear();
            dataGridViewAlert.AllowUserToAddRows = true;
            dataGridViewAlert.AllowUserToDeleteRows = true;

            _renewables.Remove(_selectedRenew);
            LoadRenewablesDataGrid(_renewables.GetList());
            dataGridViewRenew.AllowUserToDeleteRows = false;
            dataGridViewAlert.AllowUserToDeleteRows = false;
            if (_renewables.GetList().Count > 0)
            {
                dataGridViewRenew.AllowUserToAddRows = false;
                dataGridViewAlert.AllowUserToAddRows = false;
            }

            ClearRenewables();
        }

        private void btnRenewNew_Click(object sender, EventArgs e)
        {
            ClearRenewables();
        }

        private void ClearRenewables()
        {
            _selectedRenew = Guid.Empty;
            dataGridViewRenew.ClearSelection();
            textRenewName.Text = string.Empty;
            textRenewAppliesTo.Text = string.Empty;
            dateTimePickerExp.Value = DateTime.Now;
            richTextBoxRemarks.Text = string.Empty;
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            ClearCar();
        }

        private void ClearCar()
        {
            _selectedCar = Guid.Empty;
            dataGridViewCar.ClearSelection();
            textCarLp.Text = string.Empty;
            textCarMM.Text = string.Empty;
            textCarYear.Text = string.Empty;

        }


        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            SaveCar();
            dataGridViewCar.AllowUserToAddRows = false;
            ClearCar();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            dataGridViewCar.ClearSelection();
            dataGridViewCar.Rows.Clear();
            dataGridViewCar.AllowUserToAddRows = true;
            dataGridViewCar.AllowUserToDeleteRows = true;

            var car = _cars.GetList().FirstOrDefault(w => w.Id.Equals(_selectedCar));
            var list = _renewables.GetList().Where(w => w.AppliesTo.Trim().Equals(car.LicencePlate.Trim()));
            if (car == null)
            {
                dataGridViewCar.AllowUserToDeleteRows = false;
                if (_cars.GetList().Count > 0) dataGridViewCar.AllowUserToAddRows = false;
                return;
            }

            if (list != null && list.Any())
            {

                List<Guid> removables = new List<Guid>();
                foreach (var item in list)
                {
                    removables.Add(item.Id);
                }

                foreach (var ritem in removables)
                {
                    _renewables.Remove(ritem);
                }

                LoadRenewablesDataGrid(_renewables.GetList());
            }

            _cars.Remove(_selectedCar);
            LoadCarDataGrid(_cars.GetList());
            dataGridViewCar.AllowUserToDeleteRows = false;
            if (_cars.GetList().Count > 0) dataGridViewCar.AllowUserToAddRows = false;
            ClearCar();
        }

        private void dataGridViewCar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCar.SelectedRows.Count > 0)
            {

                string idstring = dataGridViewCar.SelectedRows[0].Cells["CarId"].Value.ToString();
                _selectedCar = Guid.Parse(idstring);
                LoadCar(_selectedCar);
            }
        }

        private void dataGridViewPerson_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPerson.SelectedRows.Count > 0)
            {

                string idstring = dataGridViewPerson.SelectedRows[0].Cells["PersonId"].Value.ToString();
                _selectedPerson = Guid.Parse(idstring);
                LoadPerson(_selectedPerson);
            }
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            ClearPerson();
        }

        private void ClearPerson()
        {
            _selectedPerson = Guid.Empty;
            dataGridViewPerson.ClearSelection();
            textPersonName.Text = string.Empty;
            textPersonEmail.Text = string.Empty;
            textPersonPhone.Text = string.Empty;
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            SavePerson();
            dataGridViewPerson.AllowUserToAddRows = false;
            ClearPerson();
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            dataGridViewPerson.ClearSelection();
            dataGridViewPerson.Rows.Clear();
            dataGridViewPerson.AllowUserToAddRows = true;
            dataGridViewPerson.AllowUserToDeleteRows = true;

            var person = _persons.GetList().FirstOrDefault(w => w.Id.Equals(_selectedPerson));
            var list = _renewables.GetList().Where(w => w.AppliesTo.Trim().Equals(person.FullName.Trim()));
            if (person == null)
            {
                dataGridViewPerson.AllowUserToDeleteRows = false;
                if (_persons.GetList().Count > 0) dataGridViewPerson.AllowUserToAddRows = false;
                return;
            }

            if (list != null && list.Any())
            {

                List<Guid> removables = new List<Guid>();
                foreach (var item in list)
                {
                    removables.Add(item.Id);
                }

                foreach (var ritem in removables)
                {
                    _renewables.Remove(ritem);
                }

                LoadRenewablesDataGrid(_renewables.GetList());
            }
            _persons.Remove(_selectedPerson);
            LoadPersonDataGrid(_persons.GetList());
            dataGridViewPerson.AllowUserToDeleteRows = false;
            if (_persons.GetList().Count > 0) dataGridViewPerson.AllowUserToAddRows = false;
            ClearPerson();
        }
    }
}
