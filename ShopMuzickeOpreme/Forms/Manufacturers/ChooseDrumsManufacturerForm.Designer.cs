namespace ShopMuzickeOpreme.Forms.Manufacturers
{
    partial class ChooseDrumsManufacturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseDrumsManufacturerForm));
            this.lblChooseManu = new System.Windows.Forms.Label();
            this.cbChooseManu = new System.Windows.Forms.ComboBox();
            this.btnSelectManu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseManu
            // 
            resources.ApplyResources(this.lblChooseManu, "lblChooseManu");
            this.lblChooseManu.Name = "lblChooseManu";
            // 
            // cbChooseManu
            // 
            this.cbChooseManu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbChooseManu, "cbChooseManu");
            this.cbChooseManu.FormattingEnabled = true;
            this.cbChooseManu.Name = "cbChooseManu";
            // 
            // btnSelectManu
            // 
            this.btnSelectManu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectManu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSelectManu, "btnSelectManu");
            this.btnSelectManu.Name = "btnSelectManu";
            this.btnSelectManu.UseVisualStyleBackColor = false;
            // 
            // ChooseDrumsManufacturer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSelectManu);
            this.Controls.Add(this.cbChooseManu);
            this.Controls.Add(this.lblChooseManu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseDrumsManufacturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseManu;
        private System.Windows.Forms.ComboBox cbChooseManu;
        private System.Windows.Forms.Button btnSelectManu;
    }
}