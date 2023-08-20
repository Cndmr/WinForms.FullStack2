using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.FullStack2.Defaults;
using WinForms.FullStack2.DTO;
using WinForms.FullStack2.Entities;

namespace WinForms.FullStack2.Forms
{
    public partial class ProductsForm : Form
    {
        string userFullname;
        Product selectedProduct;

        public ProductsForm(string userFullname)
        {
            InitializeComponent();
            this.userFullname = userFullname;
            Reload();
        }

        public void Reload()
        {
            var notes = ListProduct();
            listProduct.DataSource = null;
            listProduct.DataSource = notes;
            listProduct.DisplayMember = "Name";
            listProduct.ValueMember = "Id";
        }
        private List<Product> ListProduct()
        {
            var productList = new List<Product>();
            SqlConnection connection = new SqlConnection("server = .\\SQLEXPRESS; database =TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Select * From Products";
            connection.Open();
            var reader = command.ExecuteReader();
            command.Parameters.Clear();

            while (reader.Read())
            {
                var product = new Product();
                product.Id = Convert.ToInt32(reader[0]);
                product.Name = Convert.ToString(reader[1]);
                product.Stock = Convert.ToInt32(reader[2]);
                productList.Add(product);
            }
            reader.Close();
            connection.Close();
            return productList;
        }

        private void listNote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            var item = listProduct.SelectedItem as Product;
            lblTest.Text = item.Stock.ToString();
            lblUser.Text = userFullname;
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listNote_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listProduct.SelectedItem != null)
            {
                selectedProduct = listProduct.SelectedItem as Product;
                txtStock.Text = selectedProduct.Stock + "";
                txtProductName.Text = selectedProduct.Name;
                lblTest.Text = selectedProduct.Stock.ToString();
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                if (!string.IsNullOrEmpty(txtStock.Text) && !string.IsNullOrEmpty(txtProductName.Text))
                {
                    UpdateProduct(new Product { Name = txtProductName.Text, Stock = int.Parse(txtStock.Text), Id = selectedProduct.Id });
                }

            }
            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELECTED);
            }

        }
        private int UpdateProduct(Product updatedProduct)
        {
            SqlConnection connection = new SqlConnection("server = .\\SQLEXPRESS; database =TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "update Products set Name=@name, Stock=@stock where Id =@id";

            command.Parameters.AddWithValue("@name", updatedProduct.Name);
            command.Parameters.AddWithValue("@stock", updatedProduct.Stock);
            command.Parameters.AddWithValue("@id", updatedProduct.Id);

            connection.Open();
            int effectedRows = command.ExecuteNonQuery();

            connection.Close();
            bool edit = true;

            if (edit)
            {
                MessageBox.Show(MessageDefaults.SUCCESS, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(MessageDefaults.ERROR, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return effectedRows;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            selectedProduct = null;

        }
        private void ClearText()
        {
            txtProductName.Text = string.Empty;
            txtStock.Text = string.Empty;
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {
                SqlConnection connection = new SqlConnection("server = .\\SQLEXPRESS; database =TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Products values(@name,@stock)";
                var stock = int.Parse(txtStock.Text);
                command.Parameters.AddWithValue("@name", txtProductName.Text);
                command.Parameters.AddWithValue("@stock", stock);
                connection.Open();
                var effectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();
                if (effectedRows > 0)
                {
                    MessageBox.Show(MessageDefaults.SUCCESS, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(MessageDefaults.ERROR, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoved_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                SqlConnection connection = new SqlConnection("server = .\\SQLEXPRESS; database =TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "delete from Products  where Id =@id";
                command.Parameters.AddWithValue("@id", selectedProduct.Id);
                connection.Open();
                command.ExecuteReader();
                connection.Close();
                command.Parameters.Clear();
            }
            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELECTED);
            }
        }


    }
}

