namespace MiniMicrosoftAccess2017
{
    partial class frmAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccess));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_database = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_newDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_createTableAndFields = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_createIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_createRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_window = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_database,
            this.mnu_window,
            this.mnu_exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnu_window;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1848, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_database
            // 
            this.mnu_database.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_newDatabase,
            this.toolStripSeparator1,
            this.mnu_createTableAndFields,
            this.mnu_createIndex,
            this.mnu_createRelation});
            this.mnu_database.Name = "mnu_database";
            this.mnu_database.Size = new System.Drawing.Size(125, 38);
            this.mnu_database.Text = "Database";
            // 
            // mnu_newDatabase
            // 
            this.mnu_newDatabase.Name = "mnu_newDatabase";
            this.mnu_newDatabase.Size = new System.Drawing.Size(340, 38);
            this.mnu_newDatabase.Text = "New Database";
            this.mnu_newDatabase.Click += new System.EventHandler(this.mnu_newDatabase_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(337, 6);
            // 
            // mnu_createTableAndFields
            // 
            this.mnu_createTableAndFields.Name = "mnu_createTableAndFields";
            this.mnu_createTableAndFields.Size = new System.Drawing.Size(340, 38);
            this.mnu_createTableAndFields.Text = "Create Table && Fields";
            this.mnu_createTableAndFields.Click += new System.EventHandler(this.mnu_createTableAndFields_Click);
            // 
            // mnu_createIndex
            // 
            this.mnu_createIndex.Name = "mnu_createIndex";
            this.mnu_createIndex.Size = new System.Drawing.Size(340, 38);
            this.mnu_createIndex.Text = "Create Index";
            this.mnu_createIndex.Click += new System.EventHandler(this.mnu_createIndex_Click);
            // 
            // mnu_createRelation
            // 
            this.mnu_createRelation.Name = "mnu_createRelation";
            this.mnu_createRelation.Size = new System.Drawing.Size(340, 38);
            this.mnu_createRelation.Text = "Create Relation";
            this.mnu_createRelation.Click += new System.EventHandler(this.mnu_createRelation_Click);
            // 
            // mnu_window
            // 
            this.mnu_window.Name = "mnu_window";
            this.mnu_window.Size = new System.Drawing.Size(114, 38);
            this.mnu_window.Text = "Window";
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.Size = new System.Drawing.Size(64, 38);
            this.mnu_exit.Text = "Exit";
            this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
            // 
            // frmAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 1066);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAccess";
            this.Text = "Access 2017";
            this.Load += new System.EventHandler(this.frmAccess_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_database;
        private System.Windows.Forms.ToolStripMenuItem mnu_newDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnu_createTableAndFields;
        private System.Windows.Forms.ToolStripMenuItem mnu_exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_window;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_createIndex;
        private System.Windows.Forms.ToolStripMenuItem mnu_createRelation;
    }
}