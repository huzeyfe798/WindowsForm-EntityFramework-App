using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkCarGalery.Entities;
using EntityFrameworkCarGalery.Services;

namespace EntityFrameworkCarGalery.Forms
{
    public partial class UpdateForm : Form
    {
        private VehicleService vehicleService;

        private TypeService typeService;

        private BrandService brandService;

        private ModelService modelService;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            brandService = new BrandService();
            modelService = new ModelService();
            typeService = new TypeService();
            vehicleService = new VehicleService();

            FillGrid();
            
            SetVisibilty();

            FillCombo();
        }

        private void FillCombo()
        {
            brandCB.ValueMember = "Id";
            brandCB.DisplayMember = "Name";
            cbM.ValueMember = "Id";
            cbM.DisplayMember = "Name";
            cbT.ValueMember = "Id";
            cbT.DisplayMember = "Name";


            brandCB.DataSource = brandService.GetList();
            cbM.DataSource = modelService.GetList();
            cbT.DataSource = typeService.GetList();
        }
        private void FillGrid()
        {
            try
            {
                VehicleGridView.DataSource = vehicleService.GetList();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void SetVisibilty()
        {
            VehicleGridView.Columns["TypeId"].Visible = false;
            VehicleGridView.Columns["BrandId"].Visible = false;
            VehicleGridView.Columns["ModelId"].Visible = false;
            VehicleGridView.Columns["Type"].Visible = false;
            VehicleGridView.Columns["Brand"].Visible = false;
            VehicleGridView.Columns["Model"].Visible = false;
        }

        private void UpdateVehicleBut_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = GetIdFromDataGridView();
                var vehicle = vehicleService.GetById(id.Value);
                vehicle.Name = vehicleNameText.Text;
                vehicle.FuelType = fuelTypeText.Text;
                vehicle.Year = yearText.Text;
                vehicle.Km = kmText.Text;
                vehicle.BrandId = Convert.ToInt32(brandCB.SelectedValue);
                vehicle.ModelId = Convert.ToInt32(cbM.SelectedValue);
                vehicle.BrandId = Convert.ToInt32(cbT.SelectedValue);
                vehicleService.Update(vehicle);
                FillGrid();
                SetVisibilty();
                ClearForm();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void ClearVehicleBut_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

  

        public void ClearForm()
        {
            vehicleNameText.Text = "";
            fuelTypeText.Text = "";
            yearText.Text = "";
            kmText.Text = "";
            brandCB.SelectedIndex = 0;
            cbM.SelectedIndex = 0;
            cbT.SelectedIndex = 0;
        }

        int? GetIdFromDataGridView()
        {
            int? result = null;
            if (VehicleGridView.SelectedRows.Count == 1)
                result = Convert.ToInt32(VehicleGridView.SelectedRows[0].Cells[0].Value);
            return result;
        }

        private void VehicleGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            int? id = GetIdFromDataGridView();
            if (id.HasValue)
            {
                Vehicle vehicle = vehicleService.GetById(id.Value);
                if (vehicle != null)
                {
                    vehicleNameText.Text = vehicle.Name;
                    fuelTypeText.Text = vehicle.FuelType;
                    yearText.Text = vehicle.Year;
                    kmText.Text = vehicle.Km;
                    brandCB.SelectedValue = vehicle.BrandId;
                    cbM.SelectedValue = vehicle.ModelId;
                    cbT.SelectedIndex = vehicle.TypeId;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int? id = GetIdFromDataGridView();
            if (id.HasValue)
            {
                vehicleService.Delete(id.Value);
                FillGrid();
                SetVisibilty();
                ClearForm();
            }
        }
    }
}
