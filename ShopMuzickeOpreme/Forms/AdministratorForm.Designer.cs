namespace ShopMuzickeOpreme.Forms
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManufacturers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnGuitars = new System.Windows.Forms.Button();
            this.btnDrums = new System.Windows.Forms.Button();
            this.btnPiano = new System.Windows.Forms.Button();
            this.btnInstruments = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxWelcome = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcome)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopMuzickeOpreme.Properties.Resources.store;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnManufacturers
            // 
            this.btnManufacturers.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnManufacturers, "btnManufacturers");
            this.btnManufacturers.Name = "btnManufacturers";
            this.btnManufacturers.UseVisualStyleBackColor = false;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSuppliers, "btnSuppliers");
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGuitars
            // 
            this.btnGuitars.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnGuitars, "btnGuitars");
            this.btnGuitars.Name = "btnGuitars";
            this.btnGuitars.UseVisualStyleBackColor = false;
            // 
            // btnDrums
            // 
            this.btnDrums.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnDrums, "btnDrums");
            this.btnDrums.Name = "btnDrums";
            this.btnDrums.UseVisualStyleBackColor = false;
            // 
            // btnPiano
            // 
            this.btnPiano.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnPiano, "btnPiano");
            this.btnPiano.Name = "btnPiano";
            this.btnPiano.UseVisualStyleBackColor = false;
            this.btnPiano.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnInstruments
            // 
            this.btnInstruments.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnInstruments, "btnInstruments");
            this.btnInstruments.Name = "btnInstruments";
            this.btnInstruments.UseVisualStyleBackColor = false;
            this.btnInstruments.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnStaff, "btnStaff");
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Name = "lblUser";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnStaff);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picBoxWelcome);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // picBoxWelcome
            // 
            this.picBoxWelcome.Image = global::ShopMuzickeOpreme.Properties.Resources.Welcome;
            resources.ApplyResources(this.picBoxWelcome, "picBoxWelcome");
            this.picBoxWelcome.Name = "picBoxWelcome";
            this.picBoxWelcome.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnGuitars);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // AdministratorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnInstruments);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPiano);
            this.Controls.Add(this.btnDrums);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnManufacturers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcome)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManufacturers;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnGuitars;
        private System.Windows.Forms.Button btnDrums;
        private System.Windows.Forms.Button btnPiano;
        private System.Windows.Forms.Button btnInstruments;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBoxWelcome;
    }
}