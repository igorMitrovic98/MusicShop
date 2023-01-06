namespace ShopMuzickeOpreme.Forms.Guitars
{
    partial class AddUpdateGuitarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateGuitarForm));
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.numPlayerNumber = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbGuitarSupplier = new System.Windows.Forms.ComboBox();
            this.cbGuitarManufacturer = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.numericUpDownStrings = new System.Windows.Forms.NumericUpDown();
            this.lblStrings = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrings)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(12, 46);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(175, 27);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(12, 194);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(175, 27);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 27);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(12, 21);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(77, 22);
            this.lblBarcode.TabIndex = 3;
            this.lblBarcode.Text = "Barcode";
            this.lblBarcode.Click += new System.EventHandler(this.lblBarcode_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 22);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(12, 169);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 22);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // dateDate
            // 
            this.dateDate.Location = new System.Drawing.Point(12, 269);
            this.dateDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(265, 22);
            this.dateDate.TabIndex = 6;
            this.dateDate.ValueChanged += new System.EventHandler(this.dateDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 243);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(136, 22);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Production date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectImage.Location = new System.Drawing.Point(12, 336);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(129, 28);
            this.btnSelectImage.TabIndex = 8;
            this.btnSelectImage.Text = "Select image";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(12, 310);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(112, 22);
            this.lblImage.TabIndex = 9;
            this.lblImage.Text = "Guitar image";
            this.lblImage.Click += new System.EventHandler(this.lblImage_Click);
            // 
            // numPlayerNumber
            // 
            this.numPlayerNumber.Location = new System.Drawing.Point(16, 409);
            this.numPlayerNumber.Margin = new System.Windows.Forms.Padding(4);
            this.numPlayerNumber.Name = "numPlayerNumber";
            this.numPlayerNumber.Size = new System.Drawing.Size(160, 22);
            this.numPlayerNumber.TabIndex = 10;
            this.numPlayerNumber.ValueChanged += new System.EventHandler(this.numPlayerNumber_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(12, 383);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(77, 22);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // cbGuitarSupplier
            // 
            this.cbGuitarSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuitarSupplier.FormattingEnabled = true;
            this.cbGuitarSupplier.Location = new System.Drawing.Point(16, 484);
            this.cbGuitarSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cbGuitarSupplier.Name = "cbGuitarSupplier";
            this.cbGuitarSupplier.Size = new System.Drawing.Size(160, 24);
            this.cbGuitarSupplier.TabIndex = 12;
            this.cbGuitarSupplier.SelectedIndexChanged += new System.EventHandler(this.cbGuitarSupplier_SelectedIndexChanged);
            // 
            // cbGuitarManufacturer
            // 
            this.cbGuitarManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuitarManufacturer.FormattingEnabled = true;
            this.cbGuitarManufacturer.Location = new System.Drawing.Point(16, 552);
            this.cbGuitarManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.cbGuitarManufacturer.Name = "cbGuitarManufacturer";
            this.cbGuitarManufacturer.Size = new System.Drawing.Size(160, 24);
            this.cbGuitarManufacturer.TabIndex = 13;
            this.cbGuitarManufacturer.SelectedIndexChanged += new System.EventHandler(this.cbGuitarManufacturer_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(12, 458);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(76, 22);
            this.lblSupplier.TabIndex = 14;
            this.lblSupplier.Text = "Supplier";
            this.lblSupplier.Click += new System.EventHandler(this.lblSupplier_Click);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(12, 526);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(115, 22);
            this.lblManufacturer.TabIndex = 15;
            this.lblManufacturer.Text = "Manufacturer";
            this.lblManufacturer.Click += new System.EventHandler(this.lblManufacturer_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(228, 122);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(175, 27);
            this.txtType.TabIndex = 16;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(233, 97);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(51, 22);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Type";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // numericUpDownStrings
            // 
            this.numericUpDownStrings.Location = new System.Drawing.Point(228, 199);
            this.numericUpDownStrings.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownStrings.Name = "numericUpDownStrings";
            this.numericUpDownStrings.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownStrings.TabIndex = 18;
            this.numericUpDownStrings.ValueChanged += new System.EventHandler(this.numericUpDownStrings_ValueChanged);
            // 
            // lblStrings
            // 
            this.lblStrings.AutoSize = true;
            this.lblStrings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrings.Location = new System.Drawing.Point(233, 169);
            this.lblStrings.Name = "lblStrings";
            this.lblStrings.Size = new System.Drawing.Size(151, 22);
            this.lblStrings.TabIndex = 19;
            this.lblStrings.Text = "Number of strings";
            this.lblStrings.Click += new System.EventHandler(this.lblStrings_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(288, 611);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 39);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(16, 611);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 39);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddUpdateGuitarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 657);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStrings);
            this.Controls.Add(this.numericUpDownStrings);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cbGuitarManufacturer);
            this.Controls.Add(this.cbGuitarSupplier);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numPlayerNumber);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateGuitarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guitar";
            this.Load += new System.EventHandler(this.AddUpdateGuitarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.NumericUpDown numPlayerNumber;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbGuitarSupplier;
        private System.Windows.Forms.ComboBox cbGuitarManufacturer;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown numericUpDownStrings;
        private System.Windows.Forms.Label lblStrings;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}