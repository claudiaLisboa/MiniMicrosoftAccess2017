namespace MiniMicrosoftAccess2017
{
    partial class frmTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            this.txt_tableName = new System.Windows.Forms.TextBox();
            this.lbl_tableName = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grp_table = new System.Windows.Forms.GroupBox();
            this.btn_createTable = new System.Windows.Forms.Button();
            this.grp_fields = new System.Windows.Forms.GroupBox();
            this.grd_fields = new System.Windows.Forms.DataGridView();
            this.col_fieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fieldSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_createField = new System.Windows.Forms.Button();
            this.txt_fieldSize = new System.Windows.Forms.TextBox();
            this.cbo_fieldType = new System.Windows.Forms.ComboBox();
            this.lbl_fieldSize = new System.Windows.Forms.Label();
            this.lbl_fieldType = new System.Windows.Forms.Label();
            this.txt_fieldName = new System.Windows.Forms.TextBox();
            this.lbl_fieldName = new System.Windows.Forms.Label();
            this.grp_table.SuspendLayout();
            this.grp_fields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_fields)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tableName
            // 
            this.txt_tableName.Location = new System.Drawing.Point(203, 47);
            this.txt_tableName.Name = "txt_tableName";
            this.txt_tableName.Size = new System.Drawing.Size(230, 39);
            this.txt_tableName.TabIndex = 1;
            // 
            // lbl_tableName
            // 
            this.lbl_tableName.AutoSize = true;
            this.lbl_tableName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tableName.Location = new System.Drawing.Point(25, 55);
            this.lbl_tableName.Name = "lbl_tableName";
            this.lbl_tableName.Size = new System.Drawing.Size(154, 29);
            this.lbl_tableName.TabIndex = 0;
            this.lbl_tableName.Text = "Table Name :";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(680, 788);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(166, 53);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // grp_table
            // 
            this.grp_table.Controls.Add(this.btn_createTable);
            this.grp_table.Controls.Add(this.txt_tableName);
            this.grp_table.Controls.Add(this.lbl_tableName);
            this.grp_table.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_table.Location = new System.Drawing.Point(25, 25);
            this.grp_table.Name = "grp_table";
            this.grp_table.Size = new System.Drawing.Size(821, 134);
            this.grp_table.TabIndex = 0;
            this.grp_table.TabStop = false;
            this.grp_table.Text = "Table";
            // 
            // btn_createTable
            // 
            this.btn_createTable.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createTable.Location = new System.Drawing.Point(617, 38);
            this.btn_createTable.Name = "btn_createTable";
            this.btn_createTable.Size = new System.Drawing.Size(184, 68);
            this.btn_createTable.TabIndex = 2;
            this.btn_createTable.Text = "Create Table";
            this.btn_createTable.UseVisualStyleBackColor = true;
            this.btn_createTable.Click += new System.EventHandler(this.btn_createTable_Click);
            // 
            // grp_fields
            // 
            this.grp_fields.Controls.Add(this.grd_fields);
            this.grp_fields.Controls.Add(this.btn_createField);
            this.grp_fields.Controls.Add(this.txt_fieldSize);
            this.grp_fields.Controls.Add(this.cbo_fieldType);
            this.grp_fields.Controls.Add(this.lbl_fieldSize);
            this.grp_fields.Controls.Add(this.lbl_fieldType);
            this.grp_fields.Controls.Add(this.txt_fieldName);
            this.grp_fields.Controls.Add(this.lbl_fieldName);
            this.grp_fields.Enabled = false;
            this.grp_fields.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_fields.Location = new System.Drawing.Point(25, 201);
            this.grp_fields.Name = "grp_fields";
            this.grp_fields.Size = new System.Drawing.Size(821, 561);
            this.grp_fields.TabIndex = 1;
            this.grp_fields.TabStop = false;
            this.grp_fields.Text = "Table Fields";
            // 
            // grd_fields
            // 
            this.grd_fields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_fields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_fieldName,
            this.col_fieldType,
            this.col_fieldSize});
            this.grd_fields.Location = new System.Drawing.Point(25, 290);
            this.grd_fields.Name = "grd_fields";
            this.grd_fields.RowTemplate.Height = 33;
            this.grd_fields.Size = new System.Drawing.Size(776, 246);
            this.grd_fields.TabIndex = 7;
            // 
            // col_fieldName
            // 
            this.col_fieldName.HeaderText = "Field Name";
            this.col_fieldName.Name = "col_fieldName";
            this.col_fieldName.ReadOnly = true;
            // 
            // col_fieldType
            // 
            this.col_fieldType.HeaderText = "Field Type";
            this.col_fieldType.Name = "col_fieldType";
            this.col_fieldType.ReadOnly = true;
            // 
            // col_fieldSize
            // 
            this.col_fieldSize.HeaderText = "Field Size";
            this.col_fieldSize.Name = "col_fieldSize";
            this.col_fieldSize.ReadOnly = true;
            // 
            // btn_createField
            // 
            this.btn_createField.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createField.Location = new System.Drawing.Point(617, 55);
            this.btn_createField.Name = "btn_createField";
            this.btn_createField.Size = new System.Drawing.Size(184, 68);
            this.btn_createField.TabIndex = 6;
            this.btn_createField.Text = "Create Field";
            this.btn_createField.UseVisualStyleBackColor = true;
            this.btn_createField.Click += new System.EventHandler(this.btn_createField_Click);
            // 
            // txt_fieldSize
            // 
            this.txt_fieldSize.Location = new System.Drawing.Point(212, 181);
            this.txt_fieldSize.MaxLength = 3;
            this.txt_fieldSize.Name = "txt_fieldSize";
            this.txt_fieldSize.Size = new System.Drawing.Size(126, 39);
            this.txt_fieldSize.TabIndex = 5;
            // 
            // cbo_fieldType
            // 
            this.cbo_fieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fieldType.FormattingEnabled = true;
            this.cbo_fieldType.Location = new System.Drawing.Point(212, 112);
            this.cbo_fieldType.Name = "cbo_fieldType";
            this.cbo_fieldType.Size = new System.Drawing.Size(181, 43);
            this.cbo_fieldType.TabIndex = 3;
            // 
            // lbl_fieldSize
            // 
            this.lbl_fieldSize.AutoSize = true;
            this.lbl_fieldSize.Location = new System.Drawing.Point(25, 185);
            this.lbl_fieldSize.Name = "lbl_fieldSize";
            this.lbl_fieldSize.Size = new System.Drawing.Size(150, 35);
            this.lbl_fieldSize.TabIndex = 4;
            this.lbl_fieldSize.Text = "Field Size :";
            // 
            // lbl_fieldType
            // 
            this.lbl_fieldType.AutoSize = true;
            this.lbl_fieldType.Location = new System.Drawing.Point(25, 120);
            this.lbl_fieldType.Name = "lbl_fieldType";
            this.lbl_fieldType.Size = new System.Drawing.Size(157, 35);
            this.lbl_fieldType.TabIndex = 2;
            this.lbl_fieldType.Text = "Field Type :";
            // 
            // txt_fieldName
            // 
            this.txt_fieldName.Location = new System.Drawing.Point(212, 52);
            this.txt_fieldName.Name = "txt_fieldName";
            this.txt_fieldName.Size = new System.Drawing.Size(249, 39);
            this.txt_fieldName.TabIndex = 1;
            // 
            // lbl_fieldName
            // 
            this.lbl_fieldName.AutoSize = true;
            this.lbl_fieldName.Location = new System.Drawing.Point(25, 55);
            this.lbl_fieldName.Name = "lbl_fieldName";
            this.lbl_fieldName.Size = new System.Drawing.Size(169, 35);
            this.lbl_fieldName.TabIndex = 0;
            this.lbl_fieldName.Text = "Field Name :";
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 864);
            this.Controls.Add(this.grp_fields);
            this.Controls.Add(this.grp_table);
            this.Controls.Add(this.btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTable";
            this.Text = "Create Table & Fields";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.grp_table.ResumeLayout(false);
            this.grp_table.PerformLayout();
            this.grp_fields.ResumeLayout(false);
            this.grp_fields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_fields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tableName;
        private System.Windows.Forms.Label lbl_tableName;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox grp_table;
        private System.Windows.Forms.Button btn_createTable;
        private System.Windows.Forms.GroupBox grp_fields;
        private System.Windows.Forms.TextBox txt_fieldSize;
        private System.Windows.Forms.ComboBox cbo_fieldType;
        private System.Windows.Forms.Label lbl_fieldSize;
        private System.Windows.Forms.Label lbl_fieldType;
        private System.Windows.Forms.TextBox txt_fieldName;
        private System.Windows.Forms.Label lbl_fieldName;
        private System.Windows.Forms.Button btn_createField;
        private System.Windows.Forms.DataGridView grd_fields;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fieldSize;
    }
}