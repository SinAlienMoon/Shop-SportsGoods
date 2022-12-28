using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop_SportsGoods
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();

        private void Entrance_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9MI6173\SQLEXPRESS; Initial Catalog=Trade; Integrated Security=True;");
            dataBase.openConnection();

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT * FROM [User] WHERE UserLogin=@UserLogin AND UserPassword=@UserPassword";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@UserLogin", Login.Text);
                sqlCmd.Parameters.AddWithValue("@UserPassword", pass.Text);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                if (count != 0)
                {
                    Shop shop = new Shop();
                    shop.Show();
                    this.Hide();
                    MessageBox.Show("Вы успешно вошли!");
                }
                else
                {
                    Caphca capcha = new Caphca();
                    capcha.Show();
                    this.Hide();
                    MessageBox.Show("Почта или пароль введены неверно.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                dataBase.closeConnection();
            }


        }

        private void BtnEnt_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
            this.Hide();
            MessageBox.Show("Добро пожаловать!");
        }
    }
}
