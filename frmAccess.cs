using System;
using System.Windows.Forms;
using DAO;

namespace MiniMicrosoftAccess2017
{
    public partial class frmAccess : Form
    {
        private Boolean bDatabaseManipulationEnabled = false;

        public frmAccess()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void frmAccess_Load(object sender, EventArgs e)
        {
            DBEngine dbe = new DBEngine();

            // Disabling database manipulation.
            this.toggleDatabaseManipulation(false);
        }

        private void mnu_newDatabase_Click(object sender, EventArgs e)
        {
            // From: http://stackoverflow.com/questions/27436531/how-to-bring-mdi-child-form-to-front

            // Looping through all open forms...
            foreach (Form openFrm in Application.OpenForms)
            {
                // If frmDatabase is already opened set focus to it.
                if (openFrm.GetType() == typeof(frmDataBase))
                {
                    openFrm.Activate();
                    return;
                }
            }

            // If frmDatabase is not opened, create it.
            frmDataBase frm = new frmDataBase();
            frm.MdiParent = this; // Setting frmAccess as MdiParent of frm.
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnu_createTableAndFields_Click(object sender, EventArgs e)
        {
            frmTable frm = new frmTable();
            frm.MdiParent = this; // Setting frmAccess as MdiParent of frm.
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnu_createIndex_Click(object sender, EventArgs e)
        {
            frmIndex frm = new frmIndex();
            frm.MdiParent = this; // Setting frmAccess as MdiParent of frm.
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnu_createRelation_Click(object sender, EventArgs e)
        {
            frmRelation frm = new frmRelation();
            frm.MdiParent = this; // Setting frmAccess as MdiParent of frm.
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void mnu_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the program ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void toggleDatabaseManipulation(Boolean toggle)
        {
            this.bDatabaseManipulationEnabled = toggle;
            this.toggleDatabaseManipulationMenus(toggle);
        }

        private void toggleDatabaseManipulationMenus(Boolean toggle)
        {
            mnu_createTableAndFields.Enabled = toggle;
            mnu_createIndex.Enabled = toggle;
            mnu_createRelation.Enabled = toggle;
        }
    }
}
