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
using Type = EntityFrameworkCarGalery.Entities.Type;

namespace EntityFrameworkCarGalery.Forms
{
    public partial class AddForm : Form
    {
        private VehicleService vehicleService;

        private TypeService typeService;

        private BrandService brandService;

        private ModelService modelService;
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddTypeBut_Click(object sender, EventArgs e)
        {
            
            typeService.AddList(new Type(){Name = textTypeName.Text});
            FillCombobox();

        }

        private void ClearTypeBut_Click(object sender, EventArgs e)
        {
            textTypeName.Text = "";
        }

        private void AddBMBut_Click(object sender, EventArgs e)
        {
            List<Brand> br1 = brandService.GetList();
            int brand = 0;
            foreach (var v1 in br1)
            {
                if (v1.Name == brandCombo.Text)
                {
                    
                    brand = v1.Id;
                }
            }

            modelService.AddList(new Model(ModelTextName.Text,brand));
            FillCombobox();
        }

        private void ClearBMBut_Click(object sender, EventArgs e)
        {
            BrandTextName.Text = "";
            ModelTextName.Text = "";
        }

        private void AddVehicleBut_Click(object sender, EventArgs e)
        {
            List<Brand> br1 = brandService.GetList();
            List<Model> m1 = modelService.GetList();
            List<Type> t1 = typeService.GetList();
            int brand = 0;
            int model = 0;
            int type = 0;
            foreach (var v1 in br1)
            {
                if (v1.Name == brandCB.Text)
                {
                    brand = v1.Id;
                }
            }
            foreach (var v1 in m1)
            {
                if (v1.Name == cbM.Text)
                {
                    model = v1.Id;
                }
            }
            foreach (var v1 in t1)
            {
                if (v1.Name == cbT.Text)
                {
                    type = v1.Id;
                }
            }
            Vehicle v2 = new Vehicle(vehicleNameText.Text, type, brand, model, fuelTypeText.Text, yearText.Text, kmText.Text);
            vehicleService.AddList(v2);
            FillCombobox();
        }

        private void ClearVehicleBut_Click(object sender, EventArgs e)
        {
            vehicleNameText.Text = "";
            fuelTypeText.Text = "";
            yearText.Text = "";
            kmText.Text = "";
        }

        private void FillCombobox()
        {
            brandCB.ValueMember = "Id";
            brandCB.DisplayMember = "Name";
            cbM.ValueMember = "Id";
            cbM.DisplayMember = "Name";
            cbT.ValueMember = "Id";
            cbT.DisplayMember = "Name";
            brandCombo.ValueMember = "Id";
            brandCombo.DisplayMember = "Name";

            brandCB.DataSource = brandService.GetList();
            cbM.DataSource = modelService.GetList();
            cbT.DataSource = typeService.GetList();
            brandCombo.DataSource = brandService.GetList();

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            brandService = new BrandService();
            modelService = new ModelService();
            typeService = new TypeService();
            vehicleService = new VehicleService();

            FillCombobox();
        }

        private void clearBrand_Click(object sender, EventArgs e)
        {
            BrandTextName.Text = "";

        }

        private void AddBrand_Click(object sender, EventArgs e)
        {
            brandService.AddList(new Brand() { Name = BrandTextName.Text });
            FillCombobox();
        }
    }
}
