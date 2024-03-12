using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Student_Registration_Form
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var id = new string(Enumerable.Repeat(chars, 3)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            txt_ID.Text = id;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=DESKTOP-8254JNC;Initial Catalog=Student_Registration_Form;Integrated Security=True");
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {


            try
            {


                if (txt_First.Text.Length == 0 || txt_First.Text.Any(char.IsDigit))
                    MessageBox.Show("Please Enter First Name or Please Enter Letters Only", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error); 
                else if (txt_Last.Text.Length == 0 || txt_Last.Text.Any(char.IsDigit))
                    MessageBox.Show("Please Enter First Name or Please Enter Letters Only", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txt_Address.Text.Length == 0)
                    MessageBox.Show("Please Enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txt_School.Text.Length == 0)
                    MessageBox.Show("Please Enter school", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txt_ConNumber.Text.Length != 9 || txt_ConNumber.Text.Any(char.IsLetter))
                    MessageBox.Show("Contact number must contain 10 numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (com_subject.SelectedIndex == -1 || com_type.SelectedIndex == -1)
                    MessageBox.Show("Please enter your subject or class type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                else
                connection.Open(); 
                command = new SqlCommand("insert into Registration values('" + txt_ID.Text + "','" + txt_First.Text + "','" + txt_Last.Text + "','" + txt_Address.Text + "','" + txt_School.Text + "','" + DOB_picker.Value + "','" + txt_Age.Text + "','" + txt_ConNumber.Text + "','" + com_subject.Items[com_subject.SelectedIndex].ToString() + "','" + com_type.Items[com_type.SelectedIndex].ToString() + "')", connection);
                int i = command.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Successfully Registerted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Data can not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    command.Dispose();
                }
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

        private void DOB_picker_ValueChanged(object sender, EventArgs e)
        {
                int age = DateTime.Now.Year - DOB_picker.Value.Year;
                txt_Age.Text = age.ToString();
            
        }

        private void btn_ClearReg_Click(object sender, EventArgs e)
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

        private void btn_ExitReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
