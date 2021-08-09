using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FrmPublisher : Form
    {
        DataSet dataSet = new DataSet();
        Database db = new Database();
        public FrmPublisher()
        {
            InitializeComponent();
            gridPublisher.UseEmbeddedNavigator = true;
        }

        private void FrmPublisher_Load(object sender, EventArgs e)
        {
            gridPublisher.DataSource = db.GetData("Publisher","*",dataSet);
            gridView1.ClearSelection();
           // db.UpdateData("Publisher", "publisherName", dataSet.Tables[0]);
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            DataTable editDatatable = dataSet.Tables[0].GetChanges();
            if (editDatatable != null)
            {
                db.UpdateDataTable(editDatatable);
                dataSet.AcceptChanges();
            }
        }
    }
}
