namespace SQLQueryStress
{
    partial class DataViewer
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
            this.dgvDataViewer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataViewer
            // 
            this.dgvDataViewer.AllowUserToAddRows = false;
            this.dgvDataViewer.AllowUserToDeleteRows = false;
            this.dgvDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDataViewer.Location = new System.Drawing.Point(14, 14);
            this.dgvDataViewer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDataViewer.Name = "dgvDataViewer";
            this.dgvDataViewer.ReadOnly = true;
            this.dgvDataViewer.ShowEditingIcon = false;
            this.dgvDataViewer.Size = new System.Drawing.Size(734, 382);
            this.dgvDataViewer.TabIndex = 0;
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 410);
            this.Controls.Add(this.dgvDataViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataViewer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DataViewer";
            this.Load += new System.EventHandler(this.frmDataViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataViewer;
    }
}