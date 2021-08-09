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
    public partial class FrmCategory : Form
    {
        DataSet dataSet = new DataSet();
        Database db = new Database();
        public FrmCategory()
        {
            InitializeComponent();
            gridCategory.UseEmbeddedNavigator = true;
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            gridCategory.DataSource = db.GetData("Category", "*",dataSet);
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
