using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> carReports = new BindingList<CarReport>();
        public Form1()
        {
            InitializeComponent();
            dgvcardate.DataSource = carReports;
        }

      
        private void btAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
