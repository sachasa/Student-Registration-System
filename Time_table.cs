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
    public partial class Time_table : Form
    {
        public Time_table()
        {
            InitializeComponent();
        }

        private void btn_ExitTime_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
