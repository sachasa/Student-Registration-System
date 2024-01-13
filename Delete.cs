using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Registration_Form
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;

        private void Delete_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=DESKTOP-8254JNC;Initial Catalog=Student_Registration_Form;Integrated Security=True");
        }

        private void btn_Dele_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new SqlCommand("Delete from Registration where Student_ID='" + txt_ID.Text + "' ", connection);
                int i = command.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Data deleted successfully", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Data cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Data base error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_ClearDel_Click(object sender, EventArgs e)
        {
            txt_ID.Clear();
        }

        private void btn_ExitDel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
