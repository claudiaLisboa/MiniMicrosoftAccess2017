using DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MiniMicrosoftAccess2017
{
    public partial class frmRelation : Form
    {
        public frmRelation()
        {
            InitializeComponent();
        }

        private void clearFormFields()
        {
            // Step 1 fields
            // Unselecting the tables in Step 1. This will clear both ComboBox controls of Step 2.
            // Also reenabling the controls because they may have been disabled if the user added a field pair.
            cbo_leftTable.SelectedIndex = -1;
            cbo_leftTable.Enabled = true;
            cbo_rightTable.SelectedIndex = -1;
            cbo_rightTable.Enabled = true;
            // Step 2 fields
            grd_relationFields.Rows.Clear();
            // Step 3 fields
            txt_relationName.Clear();

            cbo_leftTable.Focus();
        }

        private void loadTableFields(ComboBox cbo, string tableName)
        {
            cbo.Items.Clear();

            if (!String.IsNullOrEmpty(tableName))
            {
                TableDef tbDef = clsGlobal.myDB.TableDefs[tableName];

                foreach (Field fld in tbDef.Fields)
                {
                    cbo.Items.Add(fld.Name);
                }
            }
        }

        private void loadTables(ComboBox cbo)
        {
            cbo.Items.Clear();
            cbo.Sorted = true;

            foreach (TableDef tdf in clsGlobal.myDB.TableDefs)
            {
                // Ignoring system and temporary tables.
                if ((tdf.Attributes == 0))
                {
                    cbo.Items.Add(tdf.Name);
                }
            }
        }

        private void cbo_leftTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTableFields(cbo_leftTableFields, cbo_leftTable.Text);
        }

        private void cbo_rightTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTableFields(cbo_rigthTableFields, cbo_rightTable.Text);
        }

        private void btn_addFieldPair_Click(object sender, EventArgs e)
        {
            // Checking whether the user has chosen both fields.
            if ((cbo_leftTableFields.SelectedIndex == -1) || (cbo_rigthTableFields.SelectedIndex == -1))
            {
                string message = "Please choose one field from the Left Table and one field from the Right Table before adding the field pair.";
                MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            // Disabling the controls on Step 1 when adding a field pair to the grd_relationFields.
            // This way the user will have to finish creating and adding the relation before choosing any other table pair.
            cbo_leftTable.Enabled = false;
            cbo_rightTable.Enabled = false;


            // Adding the field pair to grd_relationFields.
            // Creating a row in grd_relationFields.
            int rowId = grd_relationFields.Rows.Add();
            // Grabbing the new row.
            DataGridViewRow row = grd_relationFields.Rows[rowId];
            // Populating the cells.
            row.Cells["col_leftField"].Value = cbo_leftTableFields.Text;
            row.Cells["col_rightField"].Value = cbo_rigthTableFields.Text;


            // Unselecting the fields.
            cbo_leftTableFields.SelectedIndex = -1;
            cbo_rigthTableFields.SelectedIndex = -1;
        }

        private void btn_addRelation_Click(object sender, EventArgs e)
        {
            // Checking whether the user has added any field pair to the relation.
            if (grd_relationFields.Rows.Count == 0)
            {
                string message = "Please add at least one field pair to the relation.";
                MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_leftTableFields.Focus();
                return;
            }

            string relationName = txt_relationName.Text.Trim();

            // Checking whether the user provided a name for the relation.
            if (String.IsNullOrEmpty(relationName))
            {
                string message = "Please enter the name of the relation before adding it to the database.";
                MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_relationName.Focus();
                return;
            }


            try
            {
                string leftTable = cbo_leftTable.Text;
                string rightTable = cbo_rightTable.Text;

                // Creating the relation.
                Relation rel = clsGlobal.myDB.CreateRelation(relationName, leftTable, rightTable);

                // Adding the field pairs to the relation.
                foreach (DataGridViewRow row in grd_relationFields.Rows)
                {
                    string leftField = row.Cells["col_leftField"].Value.ToString();
                    string rightField = row.Cells["col_rightField"].Value.ToString();

                    Field fld = rel.CreateField(leftField);
                    fld.ForeignName = rightField;

                    rel.Fields.Append(fld);
                }

                // Adding the relation to the database.
                clsGlobal.myDB.Relations.Append(rel);
            }
            catch (Exception exc)
            {
                string message = "The following error occurred while creating and adding the new relation:\n\n";
                message += exc.Message;

                MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("The relation has been added successfully.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearFormFields();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRelation_Load(object sender, EventArgs e)
        {
            loadTables(cbo_leftTable);
            loadTables(cbo_rightTable);
        }
    }
}
