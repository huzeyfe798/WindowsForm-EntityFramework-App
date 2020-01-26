using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkCarGalery.Managers;

namespace EntityFrameworkCarGalery
{
    public partial class Form1 : Form
    {
        FormManager formManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formManager = new FormManager();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formManager.ShowBrowseForm(this);
            label1.Visible = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formManager.ShowAddForm(this);
            label1.Visible = false;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formManager.ShowUpdateForm(this);
            label1.Visible = false;
        }


    }
}
