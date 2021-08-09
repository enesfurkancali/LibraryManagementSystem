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
    public partial class Form1 : Form
    {
        Database db = new Database();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.GetData("Admin", "*", ds);

            if(textBox1.Text == ds.Tables[0].Rows[0][0].ToString() && textBox2.Text == ds.Tables[0].Rows[0][1].ToString())
            {  
                var form2 = new Form2();
                //this.Hide();
                form2.Show();                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
