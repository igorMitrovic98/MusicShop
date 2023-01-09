namespace ShopMuzickeOpreme.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxWelcome = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBasket = new System.Windows.Forms.Button();
            this.btnGuitars = new System.Windows.Forms.Button();
            this.btnPiano = new System.Windows.Forms.Button();
            this.btnDrums = new System.Windows.Forms.Button();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSettings);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Name = "lblUser";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = false;
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
            this.panel3.Controls.Add(this.btnBasket);
            this.panel3.Controls.Add(this.btnGuitars);
            this.panel3.Controls.Add(this.btnPiano);
            this.panel3.Controls.Add(this.btnDrums);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnBasket
            // 
            this.btnBasket.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnBasket, "btnBasket");
            this.btnBasket.Image = global::ShopMuzickeOpreme.Properties.Resources.icons8_shopping_basket_64;
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.UseVisualStyleBackColor = false;
            // 
            // btnGuitars
            // 
            this.btnGuitars.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnGuitars, "btnGuitars");
            this.btnGuitars.Name = "btnGuitars";
            this.btnGuitars.UseVisualStyleBackColor = false;
            // 
            // btnPiano
            // 
            this.btnPiano.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnPiano, "btnPiano");
            this.btnPiano.Name = "btnPiano";
            this.btnPiano.UseVisualStyleBackColor = false;
            // 
            // btnDrums
            // 
            this.btnDrums.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.btnDrums, "btnDrums");
            this.btnDrums.Name = "btnDrums";
            this.btnDrums.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcome)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxWelcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuitars;
        private System.Windows.Forms.Button btnPiano;
        private System.Windows.Forms.Button btnDrums;
        private System.Windows.Forms.Button btnBasket;
    }
}