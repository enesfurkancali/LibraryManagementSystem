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
    public partial class FrmCalendar : Form
    {
        DataSet ds = new DataSet();
        Database db = new Database();
        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            schedulerDataStorage1.Appointments.DataSource = db.GetData("Borrow", "borrowDate, deliveryDate", ds);
            schedulerDataStorage1.Appointments.Mappings.Start = "borrowDate";
            schedulerDataStorage1.Appointments.Mappings.End = "deliveryDate";
            
            //schedulerDataStorage1.Appointments.Mappings.End = "EndDate";
        }
    }
}
