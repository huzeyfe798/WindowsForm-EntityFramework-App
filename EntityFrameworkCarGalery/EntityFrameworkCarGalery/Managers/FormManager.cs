using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkCarGalery.Forms;

namespace EntityFrameworkCarGalery.Managers
{
    class FormManager
    {
        private static BrowseForm browseForm = null;
        private static AddForm addForm = null;
        private static UpdateForm updateForm = null;


        public void ShowBrowseForm(Form mainForm)
        {
            if(browseForm == null || browseForm.IsDisposed)
                browseForm = new BrowseForm();
            browseForm.MdiParent = mainForm;
            browseForm.WindowState = FormWindowState.Maximized;
            browseForm.Show();
            browseForm.Focus();
            

        }
        public void ShowAddForm(Form mainForm)
        {
            if (addForm == null || addForm.IsDisposed)
                addForm = new AddForm();
            addForm.MdiParent = mainForm;
            addForm.WindowState = FormWindowState.Maximized;
            addForm.Show();
            addForm.Focus();


        }
        public void ShowUpdateForm(Form mainForm)
        {
            if (updateForm == null || updateForm.IsDisposed)
                updateForm = new UpdateForm();
            updateForm.MdiParent = mainForm;
            updateForm.WindowState = FormWindowState.Maximized;
            updateForm.Show();
            updateForm.Focus();


        }

    }
}
