namespace ShopMuzickeOpreme.Forms.Suppliers
{
    partial class AddSupplierForm
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
            this.lblSupplierImage = new System.Windows.Forms.Label();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(312, 207);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 47);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCountry.FlatAppearance.BorderSize = 0;
            this.btnCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCountry.Location = new System.Drawing.Point(49, 207);
            this.btnCountry.Margin = new System.Windows.Forms.Padding(4);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(108, 47);
            this.btnCountry.TabIndex = 10;
            this.btnCountry.Text = "Save";
            this.btnCountry.UseVisualStyleBackColor = false;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSelectImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectImage.Location = new System.Drawing.Point(49, 153);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(133, 33);
            this.btnSelectImage.TabIndex = 9;
            this.btnSelectImage.Text = "Select image";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblSupplierImage
            // 
            this.lblSupplierImage.AutoSize = true;
            this.lblSupplierImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSupplierImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSupplierImage.Location = new System.Drawing.Point(45, 114);
            this.lblSupplierImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierImage.Name = "lblSupplierImage";
            this.lblSupplierImage.Size = new System.Drawing.Size(137, 24);
            this.lblSupplierImage.TabIndex = 8;
            this.lblSupplierImage.Text = "Supplier image";
            this.lblSupplierImage.Click += new System.EventHandler(this.lblSupplierImage_Click);
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(49, 72);
            this.tbSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(180, 22);
            this.tbSupplierName.TabIndex = 7;
            this.tbSupplierName.TextChanged += new System.EventHandler(this.tbSupplierName_TextChanged);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSupplierName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSupplierName.Location = new System.Drawing.Point(45, 34);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(133, 24);
            this.lblSupplierName.TabIndex = 6;
            this.lblSupplierName.Text = "Supplier name";
            this.lblSupplierName.Click += new System.EventHandler(this.lblSupplierName_Click);
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 289);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblSupplierImage);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.lblSupplierName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSupplierForm";
            this.Text = "AddSupplierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblSupplierImage;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
    }
}