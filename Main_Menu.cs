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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Apply obj = new Apply();
            obj.ShowDialog();

            
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            Fees_Calculator obj = new Fees_Calculator();
            obj.ShowDialog();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Time_table obj = new Time_table();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staticreport obj = new Staticreport();
            obj.ShowDialog();
        }

        private void btn_DynReport_Click(object sender, EventArgs e)
        {
            DynamicReport obj = new DynamicReport();
            obj.ShowDialog();
            
        }
    }
}
