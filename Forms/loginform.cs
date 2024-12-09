using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleSQLApp.MainFiles;
using MySql.Data.MySqlClient;

namespace ExampleSQLApp
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, 64);


        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) // Если пользователь найден
            {
                MessageBox.Show("Добро пожаловать!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else // Если пользователь не найден
            {
                MessageBox.Show("Логин или пароль неверны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void closeButtonLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButtonLogin_MouseLeave(object sender, EventArgs e)
        {
            closeButtonLogin.BackColor = Color.FromArgb(0, 139, 151);
            closeButtonLogin.ForeColor = SystemColors.ButtonFace;
        }

        private void closeButtonLogin_MouseMove(object sender, MouseEventArgs e)
        {
            closeButtonLogin.BackColor = Color.FromArgb(255, 0, 0);
            closeButtonLogin.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RegLabelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void RegLabelLogin_MouseLeave(object sender, EventArgs e)
        {
            RegLabelLogin.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void RegLabelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            RegLabelLogin.ForeColor = Color.FromArgb(53, 79, 216);
        }
    }
}
