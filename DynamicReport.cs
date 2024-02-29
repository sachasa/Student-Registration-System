using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_Form
{
    public partial class DynamicReport : Form
    {
        public DynamicReport()
        {
            InitializeComponent();
        }

        private void DynamicReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dynamic_report.Registration' table. You can move, or remove it, as needed.
            this.RegistrationTableAdapter.Fill(this.Dynamic_report.Registration, com_subject.Text, com_type.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
