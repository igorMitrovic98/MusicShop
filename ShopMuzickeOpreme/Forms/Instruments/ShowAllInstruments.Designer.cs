namespace ShopMuzickeOpreme.Forms.Instruments
{
    partial class ShowAllInstruments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllInstruments));
            this.lvAllInstruments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAllInstruments
            // 
            this.lvAllInstruments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAllInstruments.FullRowSelect = true;
            this.lvAllInstruments.HideSelection = false;
            resources.ApplyResources(this.lvAllInstruments, "lvAllInstruments");
            this.lvAllInstruments.Name = "lvAllInstruments";
            this.lvAllInstruments.UseCompatibleStateImageBehavior = false;
            this.lvAllInstruments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnOpenPlayer
            // 
            this.btnOpenPlayer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenPlayer.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnOpenPlayer, "btnOpenPlayer");
            this.btnOpenPlayer.Name = "btnOpenPlayer";
            this.btnOpenPlayer.UseVisualStyleBackColor = false;
            this.btnOpenPlayer.Click += new System.EventHandler(this.btnOpenPlayer_Click);
            // 
            // ShowAllInstruments
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenPlayer);
            this.Controls.Add(this.lvAllInstruments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowAllInstruments";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAllInstruments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenPlayer;
    }
}