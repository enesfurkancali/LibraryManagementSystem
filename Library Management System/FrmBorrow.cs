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
    public partial class FrmBorrow : Form
    {
        DataSet dataSet = new DataSet();
        Database db = new Database();
        public FrmBorrow()
        {
            InitializeComponent();
            gridBorrow.UseEmbeddedNavigator = true;
        }

        private void FrmBorrow_Load(object sender, EventArgs e)
        {
            gridBorrow.DataSource = db.GetData("Borrow", "*",dataSet);

            var lookUpEditBook = new RepositoryItemLookUpEdit();
            var lookUpEditMember= new RepositoryItemLookUpEdit();

            gridView1.Columns[1].ColumnEdit = lookUpEditBook;
            lookUpEditBook.ValueMember = "bookId";
            lookUpEditBook.DisplayMember = "bookName";
            lookUpEditBook.DataSource = db.GetData("Book", "*",dataSet);

            gridView1.Columns[2].ColumnEdit = lookUpEditMember;
            lookUpEditMember.ValueMember = "memberId";
            lookUpEditMember.DisplayMember = "memberName";
            lookUpEditMember.DataSource = db.GetData("Member", "*",dataSet);
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
