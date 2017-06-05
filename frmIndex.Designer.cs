namespace MiniMicrosoftAccess2017
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.btn_createIndex = new System.Windows.Forms.Button();
            this.lbl_indexName = new System.Windows.Forms.Label();
            this.txt_indexName = new System.Windows.Forms.TextBox();
            this.grd_indexes = new System.Windows.Forms.DataGridView();
            this.col_indexName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fields = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_unique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_primary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ignoreNulls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_indexes = new System.Windows.Forms.GroupBox();
            this.chklst_fields = new System.Windows.Forms.CheckedListBox();
            this.lbl_fields = new System.Windows.Forms.Label();
            this.chk_ignoreNulls = new System.Windows.Forms.CheckBox();
            this.chk_primary = new System.Windows.Forms.CheckBox();
            this.chk_unique = new System.Windows.Forms.CheckBox();
            this.grp_table = new System.Windows.Forms.GroupBox();
            this.cbo_table = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_indexes)).BeginInit();
            this.grp_indexes.SuspendLayout();
            this.grp_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_createIndex
            // 
            this.btn_createIndex.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createIndex.Location = new System.Drawing.Point(1142, 52);
            this.btn_createIndex.Name = "btn_createIndex";
            this.btn_createIndex.Size = new System.Drawing.Size(184, 68);
            this.btn_createIndex.TabIndex = 7;
            this.btn_createIndex.Text = "Create Index";
            this.btn_createIndex.UseVisualStyleBackColor = true;
            this.btn_createIndex.Click += new System.EventHandler(this.btn_createIndex_Click);
            // 
            // lbl_indexName
            // 
            this.lbl_indexName.AutoSize = true;
            this.lbl_indexName.Location = new System.Drawing.Point(25, 54);
            this.lbl_indexName.Name = "lbl_indexName";
            this.lbl_indexName.Size = new System.Drawing.Size(176, 35);
            this.lbl_indexName.TabIndex = 0;
            this.lbl_indexName.Text = "Index Name :";
            // 
            // txt_indexName
            // 
            this.txt_indexName.Location = new System.Drawing.Point(212, 52);
            this.txt_indexName.Name = "txt_indexName";
            this.txt_indexName.Size = new System.Drawing.Size(249, 39);
            this.txt_indexName.TabIndex = 1;
            // 
            // grd_indexes
            // 
            this.grd_indexes.AllowUserToAddRows = false;
            this.grd_indexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_indexes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_indexName,
            this.col_fields,
            this.col_unique,
            this.col_primary,
            this.col_ignoreNulls});
            this.grd_indexes.Location = new System.Drawing.Point(25, 290);
            this.grd_indexes.Name = "grd_indexes";
            this.grd_indexes.RowTemplate.Height = 33;
            this.grd_indexes.Size = new System.Drawing.Size(1301, 310);
            this.grd_indexes.TabIndex = 8;
            // 
            // col_indexName
            // 
            this.col_indexName.HeaderText = "Index Name";
            this.col_indexName.Name = "col_indexName";
            this.col_indexName.ReadOnly = true;
            // 
            // col_fields
            // 
            this.col_fields.HeaderText = "Fields";
            this.col_fields.Name = "col_fields";
            this.col_fields.ReadOnly = true;
            // 
            // col_unique
            // 
            this.col_unique.HeaderText = "Unique";
            this.col_unique.Name = "col_unique";
            this.col_unique.ReadOnly = true;
            // 
            // col_primary
            // 
            this.col_primary.HeaderText = "Primary";
            this.col_primary.Name = "col_primary";
            this.col_primary.ReadOnly = true;
            // 
            // col_ignoreNulls
            // 
            this.col_ignoreNulls.HeaderText = "Ignore Nulls";
            this.col_ignoreNulls.Name = "col_ignoreNulls";
            this.col_ignoreNulls.ReadOnly = true;
            // 
            // grp_indexes
            // 
            this.grp_indexes.Controls.Add(this.chklst_fields);
            this.grp_indexes.Controls.Add(this.lbl_fields);
            this.grp_indexes.Controls.Add(this.chk_ignoreNulls);
            this.grp_indexes.Controls.Add(this.chk_primary);
            this.grp_indexes.Controls.Add(this.chk_unique);
            this.grp_indexes.Controls.Add(this.grd_indexes);
            this.grp_indexes.Controls.Add(this.btn_createIndex);
            this.grp_indexes.Controls.Add(this.txt_indexName);
            this.grp_indexes.Controls.Add(this.lbl_indexName);
            this.grp_indexes.Enabled = false;
            this.grp_indexes.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_indexes.Location = new System.Drawing.Point(25, 201);
            this.grp_indexes.Name = "grp_indexes";
            this.grp_indexes.Size = new System.Drawing.Size(1349, 619);
            this.grp_indexes.TabIndex = 1;
            this.grp_indexes.TabStop = false;
            this.grp_indexes.Text = "Table Indexes";
            // 
            // chklst_fields
            // 
            this.chklst_fields.CheckOnClick = true;
            this.chklst_fields.FormattingEnabled = true;
            this.chklst_fields.IntegralHeight = false;
            this.chklst_fields.Location = new System.Drawing.Point(563, 92);
            this.chklst_fields.Name = "chklst_fields";
            this.chklst_fields.Size = new System.Drawing.Size(438, 160);
            this.chklst_fields.TabIndex = 6;
            // 
            // lbl_fields
            // 
            this.lbl_fields.AutoSize = true;
            this.lbl_fields.Location = new System.Drawing.Point(557, 54);
            this.lbl_fields.Name = "lbl_fields";
            this.lbl_fields.Size = new System.Drawing.Size(271, 35);
            this.lbl_fields.TabIndex = 5;
            this.lbl_fields.Text = "Fields for the index :";
            // 
            // chk_ignoreNulls
            // 
            this.chk_ignoreNulls.AutoSize = true;
            this.chk_ignoreNulls.Location = new System.Drawing.Point(31, 214);
            this.chk_ignoreNulls.Name = "chk_ignoreNulls";
            this.chk_ignoreNulls.Size = new System.Drawing.Size(191, 39);
            this.chk_ignoreNulls.TabIndex = 4;
            this.chk_ignoreNulls.Text = "Ignore Nulls";
            this.chk_ignoreNulls.UseVisualStyleBackColor = true;
            // 
            // chk_primary
            // 
            this.chk_primary.AutoSize = true;
            this.chk_primary.Location = new System.Drawing.Point(31, 163);
            this.chk_primary.Name = "chk_primary";
            this.chk_primary.Size = new System.Drawing.Size(140, 39);
            this.chk_primary.TabIndex = 3;
            this.chk_primary.Text = "Primary";
            this.chk_primary.UseVisualStyleBackColor = true;
            // 
            // chk_unique
            // 
            this.chk_unique.AutoSize = true;
            this.chk_unique.Location = new System.Drawing.Point(31, 112);
            this.chk_unique.Name = "chk_unique";
            this.chk_unique.Size = new System.Drawing.Size(133, 39);
            this.chk_unique.TabIndex = 2;
            this.chk_unique.Text = "Unique";
            this.chk_unique.UseVisualStyleBackColor = true;
            // 
            // grp_table
            // 
            this.grp_table.Controls.Add(this.cbo_table);
            this.grp_table.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_table.Location = new System.Drawing.Point(25, 25);
            this.grp_table.Name = "grp_table";
            this.grp_table.Size = new System.Drawing.Size(1349, 134);
            this.grp_table.TabIndex = 0;
            this.grp_table.TabStop = false;
            this.grp_table.Text = "Table";
            // 
            // cbo_table
            // 
            this.cbo_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_table.FormattingEnabled = true;
            this.cbo_table.Location = new System.Drawing.Point(25, 55);
            this.cbo_table.Name = "cbo_table";
            this.cbo_table.Size = new System.Drawing.Size(1301, 43);
            this.cbo_table.TabIndex = 0;
            this.cbo_table.SelectedIndexChanged += new System.EventHandler(this.cbo_table_SelectedIndexChanged);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(1208, 843);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(166, 53);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 923);
            this.Controls.Add(this.grp_indexes);
            this.Controls.Add(this.grp_table);
            this.Controls.Add(this.btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIndex";
            this.Text = "Create Index";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_indexes)).EndInit();
            this.grp_indexes.ResumeLayout(false);
            this.grp_indexes.PerformLayout();
            this.grp_table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_createIndex;
        private System.Windows.Forms.Label lbl_indexName;
        private System.Windows.Forms.TextBox txt_indexName;
        private System.Windows.Forms.DataGridView grd_indexes;
        private System.Windows.Forms.GroupBox grp_indexes;
        private System.Windows.Forms.GroupBox grp_table;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cbo_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_indexName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fields;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_unique;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_primary;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ignoreNulls;
        private System.Windows.Forms.CheckedListBox chklst_fields;
        private System.Windows.Forms.Label lbl_fields;
        private System.Windows.Forms.CheckBox chk_ignoreNulls;
        private System.Windows.Forms.CheckBox chk_primary;
        private System.Windows.Forms.CheckBox chk_unique;
    }
}