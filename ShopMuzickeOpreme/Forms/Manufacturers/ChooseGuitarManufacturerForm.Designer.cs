namespace ShopMuzickeOpreme.Forms.Manufacturers
{
    partial class ChooseGuitarManufacturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGuitarManufacturerForm));
            this.cbChooseManu = new System.Windows.Forms.ComboBox();
            this.lblChooseManu = new System.Windows.Forms.Label();
            this.btnSelectManu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbChooseManu
            // 
            this.cbChooseManu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChooseManu.FormattingEnabled = true;
            this.cbChooseManu.Location = new System.Drawing.Point(17, 68);
            this.cbChooseManu.Margin = new System.Windows.Forms.Padding(4);
            this.cbChooseManu.Name = "cbChooseManu";
            this.cbChooseManu.Size = new System.Drawing.Size(203, 28);
            this.cbChooseManu.TabIndex = 2;
            // 
            // lblChooseManu
            // 
            this.lblChooseManu.AutoSize = true;
            this.lblChooseManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblChooseManu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblChooseManu.Location = new System.Drawing.Point(13, 22);
            this.lblChooseManu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseManu.Name = "lblChooseManu";
            this.lblChooseManu.Size = new System.Drawing.Size(191, 24);
            this.lblChooseManu.TabIndex = 3;
            this.lblChooseManu.Text = "Choose Manufacturer";
            // 
            // btnSelectManu
            // 
            this.btnSelectManu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectManu.FlatAppearance.BorderSize = 0;
            this.btnSelectManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSelectManu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectManu.Location = new System.Drawing.Point(17, 128);
            this.btnSelectManu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectManu.Name = "btnSelectManu";
            this.btnSelectManu.Size = new System.Drawing.Size(161, 36);
            this.btnSelectManu.TabIndex = 4;
            this.btnSelectManu.Text = "Select";
            this.btnSelectManu.UseVisualStyleBackColor = false;
            // 
            // ChooseGuitarManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 193);
            this.Controls.Add(this.btnSelectManu);
            this.Controls.Add(this.lblChooseManu);
            this.Controls.Add(this.cbChooseManu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseGuitarManufacturer";
            this.Text = "Guitar Manufacturers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChooseManu;
        private System.Windows.Forms.Label lblChooseManu;
        private System.Windows.Forms.Button btnSelectManu;
    }
}