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
    public partial class Form2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataSet dataSet = new DataSet();
        Database db = new Database();
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);

        }

        FrmHomee frmHomee;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmHomee == null)
            {
                frmHomee = new FrmHomee();
                frmHomee.MdiParent = this;
                frmHomee.Show();
            }
        }

        FrmBook frmBook;
        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBook == null)
            {
                frmBook = new FrmBook();
                frmBook.MdiParent = this;
                frmBook.Show();
            }
        }

        FrmMember frmMember;
        private void btnMember_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMember == null)
            {
                frmMember = new FrmMember();
                frmMember.MdiParent = this;
                frmMember.Show();
            }
        }

        FrmBorrow frmBorrow;
        private void btnBorrow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBorrow == null)
            {
                frmBorrow = new FrmBorrow();
                frmBorrow.MdiParent = this;
                frmBorrow.Show();
            }
        }

        FrmCategory frmCategory;
        private void btnCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCategory == null)
            {
                frmCategory = new FrmCategory();
                frmCategory.MdiParent = this;
                frmCategory.Show();
            }
        }

        FrmAuthor frmAuthor;
        private void btnAuthor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAuthor == null)
            {
                frmAuthor = new FrmAuthor();
                frmAuthor.MdiParent = this;
                frmAuthor.Show();
            }
        }

        FrmPublisher frmPublisher;
        private void btnPublisher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPublisher == null)
            {
                frmPublisher = new FrmPublisher();
                frmPublisher.MdiParent = this;
                frmPublisher.Show();
            }
        }
        Form1 frm = new Form1();
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frm.Show();
            //this.Hide();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frm.Show();
            //this.Hide();
        }

        FrmCalendar frmCalendar;
        private void barButtonItem2_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCalendar == null)
            {
                frmCalendar = new FrmCalendar();
                frmCalendar.MdiParent = this;
                frmCalendar.Show();
            }
        }
    }
}
