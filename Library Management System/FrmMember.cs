using DevExpress.XtraEditors.Repository;
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
    public partial class FrmMember : Form
    {
        DataSet dataSet = new DataSet();
        Database db = new Database();
        public FrmMember()
        {
            InitializeComponent();
            gridMember.UseEmbeddedNavigator = true;
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            gridMember.DataSource = db.GetData("Member", "*",dataSet);

            var cmb = new RepositoryItemComboBox();
            cmb.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmb.Items.Add("Kadın");
            cmb.Items.Add("Erkek");
            cmb.Items.Add("Diğer");

            gridView1.Columns[3].ColumnEdit = cmb;
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
