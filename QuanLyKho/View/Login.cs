using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Login()
        {
            InitializeComponent();
            this.MouseDown += YourForm_MouseDown;
            this.MouseMove += YourForm_MouseMove;
            this.MouseUp += YourForm_MouseUp;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.textBox2.AutoSize = false;
            this.textBox1.AutoSize = false;
            this.textBox2.Size = new System.Drawing.Size(247, 45);
            this.textBox1.Size = new System.Drawing.Size(247, 45);
            this.pictureBox1.Image = new Bitmap(Utility.ImagePath + "BackgroundLogin.jpg");
        }
        private void YourForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void YourForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void YourForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.textBox2.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", textBox2, textBox2.Width, 0, 2000);
                textBox2.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.textBox1.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", textBox1, textBox1.Width, 0, 2000);
                textBox1.Focus();
                return;
            }
            using(var db = new Context())
            {
                Utility.Employee = db.Administrators.SingleOrDefault(i => i.UserName == textBox2.Text && i.Password == textBox1.Text);
            }
            if (Utility.Employee != null)
            {
              
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
