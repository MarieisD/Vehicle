using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            userName.Text = "Name";
            userName.ForeColor = Color.LightBlue;
            userSurname.Text = "Surname";
            userSurname.ForeColor = Color.LightBlue;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.CornflowerBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text == "Name")
            {
                userName.Text = "";
                userName.ForeColor = Color.Black;
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "Name";
                userName.ForeColor = Color.LightBlue;
            }
        }

        private void userSurname_Enter(object sender, EventArgs e)
        {
            if (userSurname.Text == "Surname")
            {
                userSurname.Text = "";
                userSurname.ForeColor = Color.Black;
            }
        }

        private void userSurname_Leave(object sender, EventArgs e)
        {
            if (userSurname.Text == "")
            {
                userSurname.Text = "Surname";
                userSurname.ForeColor = Color.LightBlue;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (userName.Text == "Name")
            {
                MessageBox.Show("Enter your name");
                return;
            }

            if (userSurname.Text == "Surname")
            {
                MessageBox.Show("Enter your surname");
                return;
            }
            if (log.Text == "")
            {
                MessageBox.Show("Enter your login");
                return;
            }
            if (pass.Text == "")
            {
                MessageBox.Show("Enter your password");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@log, @pass, @name, @surname)", db.getConnection());

            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = log.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurname.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
                MessageBox.Show("Not created");

            db.closeConnection();   
        }
        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = log.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This login exists. Enter a new login");
                return true;
            }

            else
                return false;

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}