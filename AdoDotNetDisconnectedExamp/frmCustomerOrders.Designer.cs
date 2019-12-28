namespace AdoDotNetDisconnectedExamp
{
    partial class frmCustomerOrders
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
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.dgvCustomerOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCustomer
            // 
            this.lstCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.Location = new System.Drawing.Point(0, 0);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(214, 450);
            this.lstCustomer.TabIndex = 0;
            // 
            // dgvCustomerOrder
            // 
            this.dgvCustomerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerOrder.Location = new System.Drawing.Point(214, 0);
            this.dgvCustomerOrder.Name = "dgvCustomerOrder";
            this.dgvCustomerOrder.Size = new System.Drawing.Size(586, 450);
            this.dgvCustomerOrder.TabIndex = 1;
            // 
            // frmCustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCustomerOrder);
            this.Controls.Add(this.lstCustomer);
            this.Name = "frmCustomerOrders";
            this.Text = "frmCustomerOrders";
            this.Load += new System.EventHandler(this.frmCustomerOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.DataGridView dgvCustomerOrder;
    }
}