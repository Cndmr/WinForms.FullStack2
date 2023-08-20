using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.FullStack2.Defaults;
using WinForms.FullStack2.DTO;

namespace WinForms.FullStack2.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLoginForm form = new();
            form.Show();
            this.Hide();
        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtNickName.Text))
            {
                using (SqlConnection connection = new SqlConnection("server = .\\SQLEXPRESS; database =TutorialDb; integrated security=true;"))
                {
                    connection.Open();

                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", connection);
                    checkCommand.Parameters.AddWithValue("@username", txtNickName.Text);
                    int existingUserCount = (int)checkCommand.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kullanımda.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string hashedPassword = HashPassword(txtPass.Text);

                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Users VALUES (@username, @password, @fullname)";
                    command.Parameters.AddWithValue("@fullname", txtName.Text);
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.Parameters.AddWithValue("@username", txtNickName.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(MessageDefaults.SUCCESS, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserLoginForm form = new UserLoginForm();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(MessageDefaults.ERROR, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(MessageDefaults.ATTENTION, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); 
                }
                return builder.ToString();
            }
        }

        
    }
}
