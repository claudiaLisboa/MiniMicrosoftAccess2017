using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.IO;


namespace MiniMicrosoftAccess2017
{
    public partial class frmDataBase : Form
    {
        // Starting database engine.
        DBEngine dbe = new DBEngine();

        public frmDataBase()
        {
            InitializeComponent();
        }

        private void frmDataBase_Load(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Microsoft Access Databases2007 - 2016 Databases(*.accdb) | *.accdb | Microsoft Access Database(2002-2003 format)(*.mdb) | *.mdb";
        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        
        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                // Deleting the existing Database before creating a new one.
                if (File.Exists(saveFileDialog1.FileName))
                {
                    File.Delete(saveFileDialog1.FileName);
                }
            }
            catch (IOException exc)
            {
                MessageBox.Show("This database exists and is already open in another application. Please close it before proceeding.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                clsGlobal.myDB = dbe.CreateDatabase(saveFileDialog1.FileName, DAO.LanguageConstants.dbLangGeneral);
            }
            catch (Exception exc)
            {
                string message = "The following error occurred while creating the database:\n\n";
                message += exc.Message;

                MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // If there was a database opened the reference to it is lost at this point
                // so database manipulation must be disabled.
                ((frmAccess)this.MdiParent).toggleDatabaseManipulation(false);
                return;
            }

            MessageBox.Show("The database was created successfully!\nYou may now use the menu Database > Create Table to add tables to it.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Enabling database manipulation.
            ((frmAccess)this.MdiParent).toggleDatabaseManipulation(true);

            this.Close();
        }

        //
        // Used for testing purposes only.
        //
        private void btn_open_Click(object sender, EventArgs e)
        {
            //    // Checking if database exists.
            //    if (!File.Exists(saveFileDialog1.FileName))
            //    {
            //        MessageBox.Show("The database you chose does not exist.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }

            //    try
            //    {
            //        clsGlobal.myDB = dbe.OpenDatabase(saveFileDialog1.FileName);
            //    }
            //    catch (Exception exc)
            //    {
            //        string message = "The following error occurred while opening the database:\n\n";
            //        message += exc.Message;

            //        MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        // If there was a database opened the reference to it is lost at this point
            //        // so database manipulation must be disabled.
            //        ((frmAccess)this.MdiParent).toggleDatabaseManipulation(false);
            //        return;
            //    }

            //    MessageBox.Show("The database you chose is open now!", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Enabling database manipulation.
            //    ((frmAccess)this.MdiParent).toggleDatabaseManipulation(true);

            //    this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name and location.
            string fileFullLocation = saveFileDialog1.FileName;

            txt_fileName.Text = Path.GetFileName(fileFullLocation);
            txt_location.Text = Path.GetDirectoryName(fileFullLocation);
        }
    }
}
