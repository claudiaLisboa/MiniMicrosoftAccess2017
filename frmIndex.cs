using DAO;
using System;
using System.Windows.Forms;

namespace MiniMicrosoftAccess2017
{
    public partial class frmIndex : Form
    {
        TableDef myTb;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void clearFormFields()
        {
            txt_indexName.Clear();
            chk_unique.Checked = false;
            chk_primary.Checked = false;
            chk_ignoreNulls.Checked = false;

            foreach (int i in chklst_fields.CheckedIndices)
            {
                chklst_fields.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void loadTableFields()
        {
            string tableName = cbo_table.Text;
            myTb = clsGlobal.myDB.TableDefs[tableName];

            chklst_fields.Items.Clear();

            foreach (Field fld in myTb.Fields)
            {
                chklst_fields.Items.Add(fld.Name);
            }
        }

        private void loadTableIndexes()
        {
            string tableName = cbo_table.Text;
            myTb = clsGlobal.myDB.TableDefs[tableName];

            grd_indexes.Rows.Clear();

            foreach (Index idx in myTb.Indexes)
            {
                // Getting the names of the fields used in index idx.
                string indexFields = string.Empty;
                foreach (Field fld in (DAO.IndexFields)idx.Fields)
                {
                    if (indexFields != string.Empty)
                    {
                        indexFields += ",";
                    }
                    indexFields += fld.Name;
                }

                // Creating a row in grd_indexes.
                int rowId = grd_indexes.Rows.Add();
                // Grabbing the new row.
                DataGridViewRow row = grd_indexes.Rows[rowId];
                // Populating the cells.
                row.Cells["col_indexName"].Value = idx.Name;
                row.Cells["col_fields"].Value = indexFields;
                row.Cells["col_unique"].Value = idx.Unique.ToString();
                row.Cells["col_primary"].Value = idx.Primary.ToString();
                row.Cells["col_ignoreNulls"].Value = idx.IgnoreNulls.ToString();
            }
        }

        private void loadTables()
        {
            cbo_table.Items.Clear();
            cbo_table.Sorted = true;

            foreach (TableDef tdf in clsGlobal.myDB.TableDefs)
            {
                // Ignoring system and temporary tables.
                if ((tdf.Attributes == 0))
                {
                    cbo_table.Items.Add(tdf.Name);
                }
            }
        }

        private Boolean validateFormFields()
        {
            if (String.IsNullOrEmpty(txt_indexName.Text.Trim()))
            {
                MessageBox.Show("Please provide a name for the new index.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_indexName.Focus();
                return false;
            }

            if (chklst_fields.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please choose the fields for the new index.", this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                chklst_fields.Focus();
                return false;
            }

            return true;
        }

        private void cbo_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTableFields();
            loadTableIndexes();
            clearFormFields();
            grp_indexes.Enabled = true;
        }

        private void btn_createIndex_Click(object sender, EventArgs e)
        {
            if (!validateFormFields())
            {
                return;
            }

            try
            {
                // Retrieving the table.
                string tableName = cbo_table.Text;
                myTb = clsGlobal.myDB.TableDefs[tableName];

                // Retrieving the name of the new index.
                string indexName = txt_indexName.Text.Trim();

                // Creating the new index.
                Index idx = myTb.CreateIndex(indexName);

                // Adding the chosen fields to the new index.
                foreach (object itemChecked in chklst_fields.CheckedItems)
                {
                    string fieldName = itemChecked.ToString();
                    Field fld = idx.CreateField(fieldName);
                    ((IndexFields)idx.Fields).Append(fld);
                }

                // Setting the properties of the new index.
                idx.Unique = chk_unique.Checked;
                idx.Primary = chk_primary.Checked;
                idx.IgnoreNulls = chk_ignoreNulls.Checked;

                // Appending the new index to the table.
                myTb.Indexes.Append(idx);

                loadTableIndexes();
                clearFormFields();
            }
            catch (Exception exc)
            {
                string message = "The following error occurred while creating the new index:\n\n";
                message += exc.Message;

                MessageBox.Show(message, this.MdiParent.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            loadTables();
        }
    }
}
