namespace MiniMicrosoftAccess2017
{
    partial class frmRelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelation));
            this.btn_close = new System.Windows.Forms.Button();
            this.grp_relation = new System.Windows.Forms.GroupBox();
            this.btn_addRelation = new System.Windows.Forms.Button();
            this.lbl_step3Instructions = new System.Windows.Forms.Label();
            this.lbl_step3 = new System.Windows.Forms.Label();
            this.btn_addFieldPair = new System.Windows.Forms.Button();
            this.cbo_rigthTableFields = new System.Windows.Forms.ComboBox();
            this.cbo_leftTableFields = new System.Windows.Forms.ComboBox();
            this.lbl_rightTableFields = new System.Windows.Forms.Label();
            this.lbl_leftTableFields = new System.Windows.Forms.Label();
            this.lbl_step2Instructions = new System.Windows.Forms.Label();
            this.lbl_step2 = new System.Windows.Forms.Label();
            this.lbl_rightTable = new System.Windows.Forms.Label();
            this.lbl_leftTable = new System.Windows.Forms.Label();
            this.lbl_step1Instructions = new System.Windows.Forms.Label();
            this.lbl_step1 = new System.Windows.Forms.Label();
            this.cbo_rightTable = new System.Windows.Forms.ComboBox();
            this.cbo_leftTable = new System.Windows.Forms.ComboBox();
            this.grd_relationFields = new System.Windows.Forms.DataGridView();
            this.col_leftField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rightField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_relationName = new System.Windows.Forms.TextBox();
            this.lbl_relationName = new System.Windows.Forms.Label();
            this.grp_relation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_relationFields)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(858, 1006);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(166, 53);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // grp_relation
            // 
            this.grp_relation.Controls.Add(this.btn_addRelation);
            this.grp_relation.Controls.Add(this.lbl_step3Instructions);
            this.grp_relation.Controls.Add(this.lbl_step3);
            this.grp_relation.Controls.Add(this.btn_addFieldPair);
            this.grp_relation.Controls.Add(this.cbo_rigthTableFields);
            this.grp_relation.Controls.Add(this.cbo_leftTableFields);
            this.grp_relation.Controls.Add(this.lbl_rightTableFields);
            this.grp_relation.Controls.Add(this.lbl_leftTableFields);
            this.grp_relation.Controls.Add(this.lbl_step2Instructions);
            this.grp_relation.Controls.Add(this.lbl_step2);
            this.grp_relation.Controls.Add(this.lbl_rightTable);
            this.grp_relation.Controls.Add(this.lbl_leftTable);
            this.grp_relation.Controls.Add(this.lbl_step1Instructions);
            this.grp_relation.Controls.Add(this.lbl_step1);
            this.grp_relation.Controls.Add(this.cbo_rightTable);
            this.grp_relation.Controls.Add(this.cbo_leftTable);
            this.grp_relation.Controls.Add(this.grd_relationFields);
            this.grp_relation.Controls.Add(this.txt_relationName);
            this.grp_relation.Controls.Add(this.lbl_relationName);
            this.grp_relation.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_relation.Location = new System.Drawing.Point(25, 25);
            this.grp_relation.Name = "grp_relation";
            this.grp_relation.Size = new System.Drawing.Size(999, 953);
            this.grp_relation.TabIndex = 0;
            this.grp_relation.TabStop = false;
            this.grp_relation.Text = "Relation";
            // 
            // btn_addRelation
            // 
            this.btn_addRelation.AutoSize = true;
            this.btn_addRelation.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRelation.Location = new System.Drawing.Point(81, 867);
            this.btn_addRelation.Name = "btn_addRelation";
            this.btn_addRelation.Size = new System.Drawing.Size(306, 49);
            this.btn_addRelation.TabIndex = 18;
            this.btn_addRelation.Text = "Add Relation To Database";
            this.btn_addRelation.UseVisualStyleBackColor = true;
            this.btn_addRelation.Click += new System.EventHandler(this.btn_addRelation_Click);
            // 
            // lbl_step3Instructions
            // 
            this.lbl_step3Instructions.AutoSize = true;
            this.lbl_step3Instructions.Location = new System.Drawing.Point(147, 740);
            this.lbl_step3Instructions.Name = "lbl_step3Instructions";
            this.lbl_step3Instructions.Size = new System.Drawing.Size(566, 35);
            this.lbl_step3Instructions.TabIndex = 15;
            this.lbl_step3Instructions.Text = "Name the relation and add it to the database";
            // 
            // lbl_step3
            // 
            this.lbl_step3.AutoSize = true;
            this.lbl_step3.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step3.Location = new System.Drawing.Point(25, 740);
            this.lbl_step3.Name = "lbl_step3";
            this.lbl_step3.Size = new System.Drawing.Size(96, 35);
            this.lbl_step3.TabIndex = 14;
            this.lbl_step3.Text = "Step 3";
            // 
            // btn_addFieldPair
            // 
            this.btn_addFieldPair.AutoSize = true;
            this.btn_addFieldPair.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFieldPair.Location = new System.Drawing.Point(81, 438);
            this.btn_addFieldPair.Name = "btn_addFieldPair";
            this.btn_addFieldPair.Size = new System.Drawing.Size(306, 49);
            this.btn_addFieldPair.TabIndex = 12;
            this.btn_addFieldPair.Text = "Add Field Pair To Relation";
            this.btn_addFieldPair.UseVisualStyleBackColor = true;
            this.btn_addFieldPair.Click += new System.EventHandler(this.btn_addFieldPair_Click);
            // 
            // cbo_rigthTableFields
            // 
            this.cbo_rigthTableFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rigthTableFields.FormattingEnabled = true;
            this.cbo_rigthTableFields.Location = new System.Drawing.Point(566, 350);
            this.cbo_rigthTableFields.Name = "cbo_rigthTableFields";
            this.cbo_rigthTableFields.Size = new System.Drawing.Size(390, 43);
            this.cbo_rigthTableFields.TabIndex = 11;
            // 
            // cbo_leftTableFields
            // 
            this.cbo_leftTableFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_leftTableFields.FormattingEnabled = true;
            this.cbo_leftTableFields.Location = new System.Drawing.Point(81, 350);
            this.cbo_leftTableFields.Name = "cbo_leftTableFields";
            this.cbo_leftTableFields.Size = new System.Drawing.Size(390, 43);
            this.cbo_leftTableFields.TabIndex = 9;
            // 
            // lbl_rightTableFields
            // 
            this.lbl_rightTableFields.AutoSize = true;
            this.lbl_rightTableFields.Location = new System.Drawing.Point(560, 310);
            this.lbl_rightTableFields.Name = "lbl_rightTableFields";
            this.lbl_rightTableFields.Size = new System.Drawing.Size(249, 35);
            this.lbl_rightTableFields.TabIndex = 10;
            this.lbl_rightTableFields.Text = "Right Table Fields :";
            // 
            // lbl_leftTableFields
            // 
            this.lbl_leftTableFields.AutoSize = true;
            this.lbl_leftTableFields.Location = new System.Drawing.Point(75, 310);
            this.lbl_leftTableFields.Name = "lbl_leftTableFields";
            this.lbl_leftTableFields.Size = new System.Drawing.Size(235, 35);
            this.lbl_leftTableFields.TabIndex = 8;
            this.lbl_leftTableFields.Text = "Left Table Fields :";
            // 
            // lbl_step2Instructions
            // 
            this.lbl_step2Instructions.AutoSize = true;
            this.lbl_step2Instructions.Location = new System.Drawing.Point(147, 250);
            this.lbl_step2Instructions.Name = "lbl_step2Instructions";
            this.lbl_step2Instructions.Size = new System.Drawing.Size(592, 35);
            this.lbl_step2Instructions.TabIndex = 7;
            this.lbl_step2Instructions.Text = "Choose field pairs and add them to the relation";
            // 
            // lbl_step2
            // 
            this.lbl_step2.AutoSize = true;
            this.lbl_step2.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step2.Location = new System.Drawing.Point(25, 250);
            this.lbl_step2.Name = "lbl_step2";
            this.lbl_step2.Size = new System.Drawing.Size(96, 35);
            this.lbl_step2.TabIndex = 6;
            this.lbl_step2.Text = "Step 2";
            // 
            // lbl_rightTable
            // 
            this.lbl_rightTable.AutoSize = true;
            this.lbl_rightTable.Location = new System.Drawing.Point(560, 120);
            this.lbl_rightTable.Name = "lbl_rightTable";
            this.lbl_rightTable.Size = new System.Drawing.Size(170, 35);
            this.lbl_rightTable.TabIndex = 4;
            this.lbl_rightTable.Text = "Right Table :";
            // 
            // lbl_leftTable
            // 
            this.lbl_leftTable.AutoSize = true;
            this.lbl_leftTable.Location = new System.Drawing.Point(75, 120);
            this.lbl_leftTable.Name = "lbl_leftTable";
            this.lbl_leftTable.Size = new System.Drawing.Size(156, 35);
            this.lbl_leftTable.TabIndex = 2;
            this.lbl_leftTable.Text = "Left Table :";
            // 
            // lbl_step1Instructions
            // 
            this.lbl_step1Instructions.AutoSize = true;
            this.lbl_step1Instructions.Location = new System.Drawing.Point(147, 60);
            this.lbl_step1Instructions.Name = "lbl_step1Instructions";
            this.lbl_step1Instructions.Size = new System.Drawing.Size(515, 35);
            this.lbl_step1Instructions.TabIndex = 1;
            this.lbl_step1Instructions.Text = "Choose the pair of tables for the relation";
            // 
            // lbl_step1
            // 
            this.lbl_step1.AutoSize = true;
            this.lbl_step1.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step1.Location = new System.Drawing.Point(25, 60);
            this.lbl_step1.Name = "lbl_step1";
            this.lbl_step1.Size = new System.Drawing.Size(96, 35);
            this.lbl_step1.TabIndex = 0;
            this.lbl_step1.Text = "Step 1";
            // 
            // cbo_rightTable
            // 
            this.cbo_rightTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rightTable.FormattingEnabled = true;
            this.cbo_rightTable.Location = new System.Drawing.Point(566, 160);
            this.cbo_rightTable.Name = "cbo_rightTable";
            this.cbo_rightTable.Size = new System.Drawing.Size(390, 43);
            this.cbo_rightTable.TabIndex = 5;
            this.cbo_rightTable.SelectedIndexChanged += new System.EventHandler(this.cbo_rightTable_SelectedIndexChanged);
            // 
            // cbo_leftTable
            // 
            this.cbo_leftTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_leftTable.FormattingEnabled = true;
            this.cbo_leftTable.Location = new System.Drawing.Point(81, 160);
            this.cbo_leftTable.Name = "cbo_leftTable";
            this.cbo_leftTable.Size = new System.Drawing.Size(390, 43);
            this.cbo_leftTable.TabIndex = 3;
            this.cbo_leftTable.SelectedIndexChanged += new System.EventHandler(this.cbo_leftTable_SelectedIndexChanged);
            // 
            // grd_relationFields
            // 
            this.grd_relationFields.AllowUserToAddRows = false;
            this.grd_relationFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_relationFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_leftField,
            this.col_rightField});
            this.grd_relationFields.Location = new System.Drawing.Point(81, 500);
            this.grd_relationFields.Name = "grd_relationFields";
            this.grd_relationFields.RowTemplate.Height = 33;
            this.grd_relationFields.Size = new System.Drawing.Size(875, 190);
            this.grd_relationFields.TabIndex = 13;
            // 
            // col_leftField
            // 
            this.col_leftField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_leftField.HeaderText = "Left Field";
            this.col_leftField.Name = "col_leftField";
            this.col_leftField.ReadOnly = true;
            // 
            // col_rightField
            // 
            this.col_rightField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_rightField.HeaderText = "Right Field";
            this.col_rightField.Name = "col_rightField";
            this.col_rightField.ReadOnly = true;
            // 
            // txt_relationName
            // 
            this.txt_relationName.Location = new System.Drawing.Point(316, 798);
            this.txt_relationName.Name = "txt_relationName";
            this.txt_relationName.Size = new System.Drawing.Size(249, 39);
            this.txt_relationName.TabIndex = 17;
            // 
            // lbl_relationName
            // 
            this.lbl_relationName.AutoSize = true;
            this.lbl_relationName.Location = new System.Drawing.Point(75, 800);
            this.lbl_relationName.Name = "lbl_relationName";
            this.lbl_relationName.Size = new System.Drawing.Size(209, 35);
            this.lbl_relationName.TabIndex = 16;
            this.lbl_relationName.Text = "Relation Name :";
            // 
            // frmRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 1084);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.grp_relation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelation";
            this.Text = "Create Relation";
            this.Load += new System.EventHandler(this.frmRelation_Load);
            this.grp_relation.ResumeLayout(false);
            this.grp_relation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_relationFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox grp_relation;
        private System.Windows.Forms.ComboBox cbo_rightTable;
        private System.Windows.Forms.ComboBox cbo_leftTable;
        private System.Windows.Forms.DataGridView grd_relationFields;
        private System.Windows.Forms.TextBox txt_relationName;
        private System.Windows.Forms.Label lbl_relationName;
        private System.Windows.Forms.Label lbl_leftTable;
        private System.Windows.Forms.Label lbl_step1Instructions;
        private System.Windows.Forms.Label lbl_step1;
        private System.Windows.Forms.Label lbl_rightTable;
        private System.Windows.Forms.Label lbl_rightTableFields;
        private System.Windows.Forms.Label lbl_leftTableFields;
        private System.Windows.Forms.Label lbl_step2Instructions;
        private System.Windows.Forms.Label lbl_step2;
        private System.Windows.Forms.ComboBox cbo_rigthTableFields;
        private System.Windows.Forms.ComboBox cbo_leftTableFields;
        private System.Windows.Forms.Button btn_addFieldPair;
        private System.Windows.Forms.Button btn_addRelation;
        private System.Windows.Forms.Label lbl_step3Instructions;
        private System.Windows.Forms.Label lbl_step3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_leftField;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rightField;
    }
}