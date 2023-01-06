namespace ShopMuzickeOpreme.Forms.Manufacturers
{
    partial class AddNewManufacturer
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblManufacturerImage = new System.Windows.Forms.Label();
            this.tbManufacturerName = new System.Windows.Forms.TextBox();
            this.lblManufacturerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(319, 203);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 47);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnCountry
            // 
            this.btnCountry.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCountry.FlatAppearance.BorderSize = 0;
            this.btnCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCountry.Location = new System.Drawing.Point(56, 203);
            this.btnCountry.Margin = new System.Windows.Forms.Padding(4);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(108, 47);
            this.btnCountry.TabIndex = 16;
            this.btnCountry.Text = "Save";
            this.btnCountry.UseVisualStyleBackColor = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSelectImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectImage.Location = new System.Drawing.Point(56, 149);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(133, 33);
            this.btnSelectImage.TabIndex = 15;
            this.btnSelectImage.Text = "Select image";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            // 
            // lblManufacturerImage
            // 
            this.lblManufacturerImage.AutoSize = true;
            this.lblManufacturerImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblManufacturerImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblManufacturerImage.Location = new System.Drawing.Point(52, 110);
            this.lblManufacturerImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturerImage.Name = "lblManufacturerImage";
            this.lblManufacturerImage.Size = new System.Drawing.Size(177, 24);
            this.lblManufacturerImage.TabIndex = 14;
            this.lblManufacturerImage.Text = "Manufacturer image";
            // 
            // tbManufacturerName
            // 
            this.tbManufacturerName.Location = new System.Drawing.Point(56, 68);
            this.tbManufacturerName.Margin = new System.Windows.Forms.Padding(4);
            this.tbManufacturerName.Name = "tbManufacturerName";
            this.tbManufacturerName.Size = new System.Drawing.Size(180, 22);
            this.tbManufacturerName.TabIndex = 13;
            // 
            // lblManufacturerName
            // 
            this.lblManufacturerName.AutoSize = true;
            this.lblManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblManufacturerName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblManufacturerName.Location = new System.Drawing.Point(52, 30);
            this.lblManufacturerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturerName.Name = "lblManufacturerName";
            this.lblManufacturerName.Size = new System.Drawing.Size(173, 24);
            this.lblManufacturerName.TabIndex = 12;
            this.lblManufacturerName.Text = "Manufacturer name";
            // 
            // AddNewManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 280);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblManufacturerImage);
            this.Controls.Add(this.tbManufacturerName);
            this.Controls.Add(this.lblManufacturerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewManufacturer";
            this.Text = "AddNewManufacturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblManufacturerImage;
        private System.Windows.Forms.TextBox tbManufacturerName;
        private System.Windows.Forms.Label lblManufacturerName;
    }
}