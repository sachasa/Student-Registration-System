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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
       

        private void Update_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=DESKTOP-8254JNC;Initial Catalog=Student_Registration_Form;Integrated Security=True");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - DOB_picker.Value.Year;
            txt_Age.Text = age.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_First.Text) || txt_First.Text.Any(char.IsDigit))
                    MessageBox.Show("Please Enter First Name or Please Enter Letters Only", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrEmpty(txt_Last.Text) || txt_Last.Text.Any(char.IsDigit))
                    MessageBox.Show("Please Enter First Name or Please Enter Letters Only", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrEmpty(txt_Address.Text))
                    MessageBox.Show("Please Enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrEmpty(txt_School.Text))
                    MessageBox.Show("Please Enter school", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txt_ConNumber.Text.Length != 9 || txt_ConNumber.Text.Any(char.IsLetter))
                    MessageBox.Show("Contact number must contain 9 numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (com_subject.SelectedIndex == -1 || com_type.SelectedIndex == -1)
                    MessageBox.Show("Please enter your subject or class type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    connection.Open();
                command = new SqlCommand("Update Registration set First_Name='" + txt_First.Text + "',Last_name='" + txt_Last.Text + "',Student_Address='" + txt_Address.Text + "',school='" + txt_School.Text + "',Date_of_birth='" + DOB_picker.Value + "',Age='" + txt_Age.Text + "',Contact_number='" + txt_ConNumber.Text + "',Select_subject='" + com_subject.Items[com_subject.SelectedIndex].ToString() + "',Class_type='" + com_type.Items[com_type.SelectedIndex].ToString() + "' where Student_ID='" + txt_ID.Text + "'", connection);
                int i = command.ExecuteNonQuery();
                if (i == 1)
                { MessageBox.Show("Data update successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                    MessageBox.Show("Data can not update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                command.Dispose();
            }
            catch(SqlException)
            {
                MessageBox.Show("Data base error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_upClear_Click(object sender, EventArgs e)
        {
            txt_First.Clear();
            txt_Last.Clear();
            txt_Address.Clear();
            txt_School.Clear();
            DOB_picker.ResetText();
            txt_Age.Clear();
            txt_ConNumber.Clear();
            com_subject.Items.Remove(com_subject.SelectedItem);
            com_type.Items.Remove(com_type.SelectedItem);
        }

        private void btn_upExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("Select * from Registration", connection);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                connection.Close();
                dataGridView1.DataSource = dt;
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

            txt_ID.Text = dataGridView1.CurrentRow.Cells["Student_ID"].Value.ToString();
            txt_First.Text = dataGridView1.CurrentRow.Cells["First_Name"].Value.ToString();
            txt_Last.Text = dataGridView1.CurrentRow.Cells["Last_name"].Value.ToString();
            txt_Address.Text = dataGridView1.CurrentRow.Cells["Student_Address"].Value.ToString();
            txt_School.Text = dataGridView1.CurrentRow.Cells["school"].Value.ToString();
            DOB_picker.Text = dataGridView1.CurrentRow.Cells["Date_of_birth"].Value.ToString();
            txt_Age.Text = dataGridView1.CurrentRow.Cells["Age"].Value.ToString();
            txt_ConNumber.Text = dataGridView1.CurrentRow.Cells["Contact_number"].Value.ToString();
            com_subject.Text = dataGridView1.CurrentRow.Cells["Select_subject"].Value.ToString();
            com_type.Text = dataGridView1.CurrentRow.Cells["Class_type"].Value.ToString();
        }
    }
}
