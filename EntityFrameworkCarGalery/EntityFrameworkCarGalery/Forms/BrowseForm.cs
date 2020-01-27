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
    public partial class BrowseForm : Form
    {
        private VehicleService vehicleService;

        private TypeService typeService;

        private BrandService brandService;

        private ModelService modelService;


        public BrowseForm()
        {
            InitializeComponent();
        }

        public void FillGrid(List<Vehicle> list1)
        {
            try
            {
                vehicleGridB.DataSource = list1;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        public void FillCombobox()
        {
            List<Type> list1 = new List<Type>();
            List<Model> models = new List<Model>();
            List<Brand> brands = new List<Brand>();
            list1 = typeService.GetList();

            list1.Insert(0,new Type()
            {
                Name = "---Seçiniz---"
            });

            typesFilter.DataSource = null;
            modelsFilter.DataSource = null;
            brandsFilter.DataSource = null;


            modelsFilter.ValueMember = "Id";
            modelsFilter.DisplayMember = "Name";

            brandsFilter.ValueMember = "Id";
            brandsFilter.DisplayMember = "Name";

            typesFilter.ValueMember = "Id";
            typesFilter.DisplayMember = "Name";
            typesFilter.DataSource = list1;
            


        }



        public void SetVisibilty()
        {
            vehicleGridB.Columns["TypeId"].Visible = false;
            vehicleGridB.Columns["BrandId"].Visible = false;
            vehicleGridB.Columns["ModelId"].Visible = false;
            vehicleGridB.Columns["Type"].Visible = false;
            vehicleGridB.Columns["Brand"].Visible = false;
            vehicleGridB.Columns["Model"].Visible = false;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            int index2 = Convert.ToInt32(modelsFilter.SelectedValue);
            int index1 = Convert.ToInt32(typesFilter.SelectedValue);
            int index = Convert.ToInt32(brandsFilter.SelectedValue);


            List<Vehicle> list1 = null;
            list1 = vehicleService.GetFilterId(index1,index2,index);
            if (list1 != null)
            {
                FillGrid(list1);
                SetVisibilty();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string text = searchText.Text;
            FillGrid(vehicleService.SearchList(text));

        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {
            vehicleService = new VehicleService();
            typeService = new TypeService();
            brandService = new BrandService();
            modelService = new ModelService();

            FillGrid(vehicleService.GetList());
            FillCombobox();
            SetVisibilty();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchText.Text = "";
            FillGrid(vehicleService.GetList());
            FillCombobox();
            SetVisibilty();
        }

        private void typesFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(typesFilter.SelectedValue);
            List<Brand> list1 = null;

            //MessageBox.Show(index.ToString());
            list1 = vehicleService.GetBrandFromType(index).Distinct().ToList();

            list1.Insert(0,new Brand()
            {
                Name = "--Seçiniz--"
            });
            if (list1 != null)
            {
                brandsFilter.DataSource = list1;
            }
        }

        private void brandsFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index1 = Convert.ToInt32(typesFilter.SelectedValue);
            int index = Convert.ToInt32(brandsFilter.SelectedValue);
            List<Model> list1 = null;

            //MessageBox.Show(index.ToString());
            list1 = vehicleService.GetModelFromType(index,index1).Distinct().ToList();

            list1.Insert(0,new Model()
            {
                Name = "--Seçiniz--"
            });
            if (list1 != null)
            {
                modelsFilter.DataSource = list1;
            }
        }
    }
}
