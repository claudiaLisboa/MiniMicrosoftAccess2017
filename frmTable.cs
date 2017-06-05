using System;
using System.Windows.Forms;
using DAO;

namespace MiniMicrosoftAccess2017
{
    public partial class frmTable : Form
    {
        TableDef myTb;

        public frmTable()
        {
            InitializeComponent();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            cbo_fieldType.Items.Add("Short Text");
            cbo_fieldType.Items.Add("Long");
            cbo_fieldType.Items.Add("Integer");
        }

        private void btn_createField_Click(object sender, EventArgs e)
        {
            // **** Field Name ****

            string fieldName = txt_fieldName.Text.Trim();

            if (String.IsNullOrEmpty(fieldName))
            {
                MessageBox.Show("Please provide a name for the new field.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_fieldName.Focus();
                return;
            }


            // **** Field Type ****

            if (cbo_fieldType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the field type.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_fieldType.Focus();
                return;
            }

            DAO.DataTypeEnum fieldType = 0;

            switch (cbo_fieldType.Text)
            {
                case "Short Text":
                    fieldType = DAO.DataTypeEnum.dbText;
                    break;
                case "Long":
                    fieldType = DAO.DataTypeEnum.dbLong;
                    break;
                case "Integer":
                    fieldType = DAO.DataTypeEnum.dbInteger;
                    break;
                default:
                    break;
            }


            // **** Field Size ****

            string strFieldSize = txt_fieldSize.Text.Trim();
            int fieldSize = 0;
            bool bParseFieldSize = int.TryParse(strFieldSize, out fieldSize);

            // Checking the provided field size only if the type chosen is dbText.
            if (fieldType == DAO.DataTypeEnum.dbText)
            {
                if (!(fieldSize > 0))
                {
                    MessageBox.Show("Please enter a valid non-zero field size.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_fieldSize.Focus();
                    return;
                }
            }



            // Creating the field and adding it to the table.
            try
            {
                Field fld = myTb.CreateField(txt_fieldName.Text, fieldType, fieldSize);
                myTb.Fields.Append(fld); // appending the field to table myTb.
                MessageBox.Show("Field was created successfully!", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                string message = "The following error occurred while creating the field:\n\n";
                message += exc.Message;

                MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Adding the field characteristics to the list of fields (grd_fields).
            grd_fields.Rows.Add(txt_fieldName.Text, cbo_fieldType.Text, txt_fieldSize.Text);

            // Clearing the fields.
            txt_fieldName.Clear();
            txt_fieldSize.Clear();
            cbo_fieldType.SelectedIndex = -1;
        }

        private void btn_createTable_Click(object sender, EventArgs e)
        {
            string tableName = txt_tableName.Text.Trim();

            if (String.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Please provide a name for the new table.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_tableName.Focus();
                return;
            }

            try
            {
                // Creating the table in memory. It is not in the database yet.
                myTb = clsGlobal.myDB.CreateTableDef(tableName);

                // Table must have at least one field before being appended to the database.
                // Creating a simple autoincrement field named ID.
                Field fld = myTb.CreateField("ID", DAO.DataTypeEnum.dbLong);
                fld.Attributes = (int)DAO.FieldAttributeEnum.dbAutoIncrField;
                myTb.Fields.Append(fld);

                // Appending table myTb to database myDB.
                clsGlobal.myDB.TableDefs.Append(myTb);
            }
            catch (Exception exc)
            {
                string message = "The following error occurred while creating the new table:\n\n";
                message += exc.Message;

                MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("The table was created successfully!\nYou may now add more fields to it.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Adding the ID field characteristics to the list of fields (grd_fields).
            grd_fields.Rows.Add("ID", "Long");

            // Enabling grp_fields so the user can add more fields to the table, and disabling grp_table.
            grp_table.Enabled = false;
            grp_fields.Enabled = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
