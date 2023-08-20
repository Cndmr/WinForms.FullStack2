using System.Data;
using System.Data.SqlClient;
using WinForms.FullStack2.DTO;
using WinForms.FullStack2.Forms;

namespace WinForms.FullStack2
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                var response = GetUser(txtUserName.Text, txtPass.Text);

                if (response != null)
                {
                    NavigationForm form = new NavigationForm(response);

                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }


            }
            else
            {
                MessageBox.Show("Alanları Boş bırakmayınız");
            }

        }
        private UserLoginResponseDto GetUser(string username, string password)
        {
            SqlConnection connection = new SqlConnection("server = .\\SQLEXPRESS; database =TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Users where UserName=@username and Password=@password";

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();
            var reader = command.ExecuteReader();
            command.Parameters.Clear();

            var id = 0;
            string fullname = "";
            UserLoginResponseDto responseDto = null;
            while (reader.Read())
            {
                responseDto = new UserLoginResponseDto();
                responseDto.Id = Convert.ToInt32(reader[0]);
                responseDto.FullName = Convert.ToString(reader[1]);

            }
            reader.Close();
            connection.Close();
            return responseDto;
        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new();
            register.Show();
            this.Hide();
        }

        private void UserLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
