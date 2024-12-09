using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleSQLApp.MainFiles;
using MySql.Data.MySqlClient;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            userNameField.ForeColor = Color.Gray;

            userNameField.Text = "Введите имя";

        }

        private void closeButtonReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButtonReg_MouseMove(object sender, MouseEventArgs e)
        {
            closeButtonReg.BackColor = Color.FromArgb(255, 0, 0);
            closeButtonReg.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void closeButtonReg_MouseLeave(object sender, EventArgs e)
        {
            closeButtonReg.BackColor = Color.FromArgb(0, 139, 151);
            closeButtonReg.ForeColor = SystemColors.ButtonFace;
        }
        Point lastPoint;
        private void MainPanelReg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanelReg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainUpReg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainUpReg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;

            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;

            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите Имя пользователя", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (userSurnameField.Text == "")
            {
                MessageBox.Show("Введите Фамилию пользователя!", "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loginPassField.Text == "")
            {
                MessageBox.Show("Введите Логин пользователя", "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passPassField.Text == "")
            {
                MessageBox.Show("Введите пароль пользователя", "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isUserExist())
            { return; }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginPassField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passPassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            {

            }
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан");
            }
            else { MessageBox.Show("Аккаунт был не создан"); }

            db.clousedConnection();

        }

        public bool isUserExist()
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginPassField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть!\nВведите другой", "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void registerLabelReg_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginform loginform = new loginform();
            loginform.Show();
        }

        private void registerLabelReg_MouseMove(object sender, MouseEventArgs e)
        {
            registerLabelReg.ForeColor = Color.FromArgb(53, 79, 216);
        }

        private void registerLabelReg_MouseLeave(object sender, EventArgs e)
        {
            registerLabelReg.ForeColor = Color.FromArgb(255,255,255);
        }
    }
}
