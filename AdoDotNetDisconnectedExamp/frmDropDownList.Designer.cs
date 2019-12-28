namespace AdoDotNetDisconnectedExamp
{
    partial class frmDropDownList
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
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.dgvDropDown = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDropDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbox
            // 
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Location = new System.Drawing.Point(12, 12);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(143, 21);
            this.cbbox.TabIndex = 0;
            // 
            // dgvDropDown
            // 
            this.dgvDropDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDropDown.Location = new System.Drawing.Point(161, 1);
            this.dgvDropDown.Name = "dgvDropDown";
            this.dgvDropDown.Size = new System.Drawing.Size(591, 356);
            this.dgvDropDown.TabIndex = 1;
            // 
            // frmDropDownList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDropDown);
            this.Controls.Add(this.cbbox);
            this.Name = "frmDropDownList";
            this.Text = "frmDropDownList";
            this.Load += new System.EventHandler(this.frmDropDownList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDropDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbox;
        private System.Windows.Forms.DataGridView dgvDropDown;
    }
}