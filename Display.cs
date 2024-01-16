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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        
        SqlDataAdapter DataAdapter;

        private void Display_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=DESKTOP-8254JNC;Initial Catalog=Student_Registration_Form;Integrated Security=True");
        }

        private void btn_view_Click(object sender, EventArgs e)
        {try
            {
                connection.Open();
                DataAdapter = new SqlDataAdapter("Select * from Registration", connection);
                DataTable dt = new DataTable();
                DataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
