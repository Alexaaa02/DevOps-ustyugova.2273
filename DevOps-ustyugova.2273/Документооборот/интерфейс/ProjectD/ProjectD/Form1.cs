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

namespace ProjectD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 45);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

           DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //выборка данных из бд
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee` WHERE `Login` = @uL  AND `Pass` =  @uP", db.getConnection());
            //@uL - заглушка
             command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
             command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
             {
            this.Hide();
                Form2 menuForm = new Form2();
                menuForm.Show();
           }
            else
            MessageBox.Show("Не верно введены данные");
        }
    }
}
