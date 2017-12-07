namespace WirelessManager
{
    partial class WirelessManagerForm
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
            this.NetworksGridView = new System.Windows.Forms.DataGridView();
            this.NameColumt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityColumt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthenticationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NetworksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NetworksGridView
            // 
            this.NetworksGridView.AllowUserToAddRows = false;
            this.NetworksGridView.AllowUserToDeleteRows = false;
            this.NetworksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NetworksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumt,
            this.QualityColumt,
            this.AuthenticationColumn,
            this.MACColumn});
            this.NetworksGridView.Location = new System.Drawing.Point(0, -2);
            this.NetworksGridView.Name = "NetworksGridView";
            this.NetworksGridView.ReadOnly = true;
            this.NetworksGridView.Size = new System.Drawing.Size(504, 240);
            this.NetworksGridView.TabIndex = 0;
            // 
            // NameColumt
            // 
            this.NameColumt.HeaderText = "Name";
            this.NameColumt.Name = "NameColumt";
            this.NameColumt.ReadOnly = true;
            // 
            // QualityColumt
            // 
            this.QualityColumt.HeaderText = "Quality";
            this.QualityColumt.Name = "QualityColumt";
            this.QualityColumt.ReadOnly = true;
            // 
            // AuthenticationColumn
            // 
            this.AuthenticationColumn.HeaderText = "Authentication";
            this.AuthenticationColumn.Name = "AuthenticationColumn";
            this.AuthenticationColumn.ReadOnly = true;
            // 
            // MACColumn
            // 
            this.MACColumn.HeaderText = "MAC";
            this.MACColumn.Name = "MACColumn";
            this.MACColumn.ReadOnly = true;
            // 
            // WirelessManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 311);
            this.Controls.Add(this.NetworksGridView);
            this.Name = "WirelessManagerForm";
            this.Text = "Wireless Manager";
            ((System.ComponentModel.ISupportInitialize)(this.NetworksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NetworksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumt;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityColumt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthenticationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACColumn;
    }
}

