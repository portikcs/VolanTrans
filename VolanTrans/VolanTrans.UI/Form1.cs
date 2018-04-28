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
                MessageBox.Show("Name is empty!", "Error");
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
                MessageBox.Show("Licence Plate is empty!", "Error");
                return;
            }
            _cars.Add(car);
            LoadCarDataGrid(_cars.GetList());
        }

        private void LoadCarDataGrid(List<CarModel> data )
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
            
            if(string.IsNullOrWhiteSpace(renew.Name) || string.IsNullOrWhiteSpace(renew.AppliesTo) ||
               !textRenewAppliesTo.AutoCompleteCustomSource.Contains(renew.AppliesTo.Trim()))
            {
                MessageBox.Show("Something is wrong!", "Error");
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
        }

        private void btnRenewDelete_Click(object sender, EventArgs e)
        {
            _renewables.Remove(_selectedRenew);
            LoadRenewablesDataGrid(_renewables.GetList());
        }

        private void btnRenewNew_Click(object sender, EventArgs e)
        {
            _selectedRenew = Guid.Empty;
            SaveRenew();
        }

        private void btnNewCar_Click(object sender, EventArgs e)
        {
            _selectedCar = Guid.Empty;
            SaveCar();
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            SaveCar();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            _cars.Remove(_selectedCar);
            LoadCarDataGrid(_cars.GetList());
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
            _selectedPerson = Guid.Empty;
            SavePerson();
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            SavePerson();
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            _persons.Remove(_selectedPerson);
            LoadPersonDataGrid(_persons.GetList());
        }
    }
}
