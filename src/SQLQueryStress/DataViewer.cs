#region

using System;
using System.Data;
using System.Windows.Forms;

#endregion

namespace SQLQueryStress
{
    public partial class DataViewer : Form
    {
        public DataViewer()
        {
            InitializeComponent();
        }

        public DataTable DataView { get; set; }

        private void frmDataViewer_Load(object sender, EventArgs e)
        {
            dgvDataViewer.DataSource = DataView;

            foreach (DataGridViewColumn col in dgvDataViewer.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvDataViewer.Columns.GetLastColumn( DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void Repaint()
        {
            dgvDataViewer.Invalidate();
        }
    }
}