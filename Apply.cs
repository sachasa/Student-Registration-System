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
    public partial class Apply : Form
    {
        public Apply()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update obj = new Update();
            obj.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete obj = new Delete();
            obj.ShowDialog();
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            Display obj = new Display();
            obj.ShowDialog();
        }
    }
}
