using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButtonMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButtonMain_MouseLeave(object sender, EventArgs e)
        {
            closeButtonMain.BackColor = Color.FromArgb(0, 139, 151);
            closeButtonMain.ForeColor = SystemColors.ButtonFace;
        }

        private void closeButtonMain_MouseMove(object sender, MouseEventArgs e)
        {
            closeButtonMain.BackColor = Color.FromArgb(255, 0, 0);
            closeButtonMain.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
