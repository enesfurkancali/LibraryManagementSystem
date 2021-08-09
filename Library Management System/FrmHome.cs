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
    public partial class FrmHome : Form
    {
        BinaryImage img = new BinaryImage();
        DataSet ds = new DataSet();
        Database db = new Database();
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblBook.Text+=db.GetData("Book", "*", ds).Rows.Count;
            lblAuthor.Text += db.GetData("Author", "*", ds).Rows.Count;
            lblBorrow.Text += db.GetData("Borrow", "*", ds).Rows.Count;
            lblCategory.Text += db.GetData("Category", "*", ds).Rows.Count;
            lblMember.Text += db.GetData("Member", "*", ds).Rows.Count;
            lblPublisher.Text += db.GetData("Publisher", "*", ds).Rows.Count;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
