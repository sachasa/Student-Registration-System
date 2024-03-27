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
    public partial class Staticreport : Form
    {
        public Staticreport()
        {
            InitializeComponent();
        }

        private void Staticreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Static_report.Registration' table. You can move, or remove it, as needed.
            this.RegistrationTableAdapter.Fill(this.Static_report.Registration);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
