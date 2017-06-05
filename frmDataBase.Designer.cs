namespace MiniMicrosoftAccess2017
{
    partial class frmDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataBase));
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fileName = new System.Windows.Forms.Label();
            this.btnChooseLocation = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(195, 103);
            this.txt_location.Name = "txt_location";
            this.txt_location.ReadOnly = true;
            this.txt_location.Size = new System.Drawing.Size(447, 31);
            this.txt_location.TabIndex = 3;
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(195, 30);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(447, 31);
            this.txt_fileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location :";
            // 
            // lbl_fileName
            // 
            this.lbl_fileName.AutoSize = true;
            this.lbl_fileName.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fileName.Location = new System.Drawing.Point(25, 25);
            this.lbl_fileName.Name = "lbl_fileName";
            this.lbl_fileName.Size = new System.Drawing.Size(160, 35);
            this.lbl_fileName.TabIndex = 0;
            this.lbl_fileName.Text = "File Name :";
            // 
            // btnChooseLocation
            // 
            this.btnChooseLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChooseLocation.BackgroundImage")));
            this.btnChooseLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseLocation.Location = new System.Drawing.Point(706, 87);
            this.btnChooseLocation.Name = "btnChooseLocation";
            this.btnChooseLocation.Size = new System.Drawing.Size(74, 63);
            this.btnChooseLocation.TabIndex = 4;
            this.btnChooseLocation.UseVisualStyleBackColor = true;
            this.btnChooseLocation.Click += new System.EventHandler(this.btnChooseLocation_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_create.BackgroundImage")));
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_create.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(33, 171);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(135, 142);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Create";
            this.btn_create.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_open.BackgroundImage")));
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.Font = new System.Drawing.Font("Trebuchet MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Location = new System.Drawing.Point(216, 171);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(135, 142);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Open";
            this.btn_open.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Visible = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // frmDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 519);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btnChooseLocation);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_fileName);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDataBase";
            this.Text = "Create/Open a Database";
            this.Load += new System.EventHandler(this.frmDataBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChooseLocation;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fileName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_open;
    }
}