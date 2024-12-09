namespace ExampleSQLApp
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            MainUpReg = new Label();
            MainPanelReg = new Panel();
            registerLabelReg = new Label();
            userSurnameField = new TextBox();
            userNameField = new TextBox();
            buttonRegister = new Button();
            passPassField = new TextBox();
            pictureBox2 = new PictureBox();
            loginPassField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButtonReg = new Label();
            MainPanelReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainUpReg
            // 
            MainUpReg.BorderStyle = BorderStyle.FixedSingle;
            MainUpReg.Dock = DockStyle.Fill;
            MainUpReg.Font = new Font("Yu Gothic UI Semibold", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            MainUpReg.ForeColor = SystemColors.ButtonFace;
            MainUpReg.Location = new Point(0, 0);
            MainUpReg.Name = "MainUpReg";
            MainUpReg.Size = new Size(800, 100);
            MainUpReg.TabIndex = 0;
            MainUpReg.Text = "Регистрация";
            MainUpReg.TextAlign = ContentAlignment.MiddleCenter;
            MainUpReg.MouseDown += MainUpReg_MouseDown;
            MainUpReg.MouseMove += MainUpReg_MouseMove;
            // 
            // MainPanelReg
            // 
            MainPanelReg.BackColor = Color.FromArgb(86, 167, 18);
            MainPanelReg.Controls.Add(registerLabelReg);
            MainPanelReg.Controls.Add(userSurnameField);
            MainPanelReg.Controls.Add(userNameField);
            MainPanelReg.Controls.Add(buttonRegister);
            MainPanelReg.Controls.Add(passPassField);
            MainPanelReg.Controls.Add(pictureBox2);
            MainPanelReg.Controls.Add(loginPassField);
            MainPanelReg.Controls.Add(pictureBox1);
            MainPanelReg.Controls.Add(panel2);
            MainPanelReg.Dock = DockStyle.Fill;
            MainPanelReg.Location = new Point(0, 0);
            MainPanelReg.Name = "MainPanelReg";
            MainPanelReg.Size = new Size(800, 450);
            MainPanelReg.TabIndex = 1;
            MainPanelReg.MouseDown += MainPanelReg_MouseDown;
            MainPanelReg.MouseMove += MainPanelReg_MouseMove;
            // 
            // registerLabelReg
            // 
            registerLabelReg.AutoSize = true;
            registerLabelReg.Cursor = Cursors.Hand;
            registerLabelReg.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            registerLabelReg.ForeColor = Color.White;
            registerLabelReg.Location = new Point(325, 421);
            registerLabelReg.Name = "registerLabelReg";
            registerLabelReg.Size = new Size(137, 20);
            registerLabelReg.TabIndex = 8;
            registerLabelReg.Text = "Войти в аккаунт";
            registerLabelReg.Click += registerLabelReg_Click;
            registerLabelReg.MouseLeave += registerLabelReg_MouseLeave;
            registerLabelReg.MouseMove += registerLabelReg_MouseMove;
            // 
            // userSurnameField
            // 
            userSurnameField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userSurnameField.Location = new Point(463, 147);
            userSurnameField.Multiline = true;
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(267, 64);
            userSurnameField.TabIndex = 7;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameField.Location = new Point(92, 147);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(267, 64);
            userNameField.TabIndex = 6;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(0, 255, 231);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 118, 185);
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 104, 95);
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRegister.ForeColor = Color.Snow;
            buttonRegister.Location = new Point(258, 351);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(305, 53);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Зарегистироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passPassField
            // 
            passPassField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passPassField.Location = new Point(464, 254);
            passPassField.Name = "passPassField";
            passPassField.Size = new Size(267, 48);
            passPassField.TabIndex = 4;
            passPassField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(384, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginPassField
            // 
            loginPassField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPassField.Location = new Point(92, 254);
            loginPassField.Multiline = true;
            loginPassField.Name = "loginPassField";
            loginPassField.Size = new Size(267, 64);
            loginPassField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 254);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 139, 151);
            panel2.Controls.Add(closeButtonReg);
            panel2.Controls.Add(MainUpReg);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // closeButtonReg
            // 
            closeButtonReg.AutoSize = true;
            closeButtonReg.Cursor = Cursors.Hand;
            closeButtonReg.Font = new Font("Segoe UI", 18F);
            closeButtonReg.ForeColor = SystemColors.ButtonFace;
            closeButtonReg.Location = new Point(775, -10);
            closeButtonReg.Name = "closeButtonReg";
            closeButtonReg.Size = new Size(25, 32);
            closeButtonReg.TabIndex = 1;
            closeButtonReg.Text = "x";
            closeButtonReg.Click += closeButtonReg_Click;
            closeButtonReg.MouseLeave += closeButtonReg_MouseLeave;
            closeButtonReg.MouseMove += closeButtonReg_MouseMove;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanelReg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            MainPanelReg.ResumeLayout(false);
            MainPanelReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label MainUpReg;
        private Panel MainPanelReg;
        private Button buttonRegister;
        private TextBox passPassField;
        private PictureBox pictureBox2;
        private TextBox loginPassField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label closeButtonReg;
        private TextBox userSurnameField;
        private TextBox userNameField;
        private Label registerLabelReg;
    }
}