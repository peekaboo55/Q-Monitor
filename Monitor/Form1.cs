using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AxWMPLib;

namespace Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
        }

        MySqlConnection con = new MySqlConnection("Server=localhost;Database=smart_bank;Uid=root;Pwd = ; ");
        MySqlCommand cmd;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtFooter.Left < 0 && (Math.Abs(txtFooter.Left) > txtFooter.Width))
                txtFooter.Left = this.Width;
            
            txtFooter.Left -= 1;                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            con.Open();
            query1();
            con.Close();
            con.Open();
            query2();
            con.Close();
            con.Open();
            query3();
            con.Close();
            con.Open();
            query4();
            con.Close();
        }

        private void query1()
        {
            string status1 = "SELECT * FROM counter WHERE id = 1";
            cmd = new MySqlCommand(status1, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtStatus1.Text = reader.GetString("status");
                txtNumber1.Text = reader.GetString("number");
            }
        }

        private void query2()
        {
            string status = "SELECT * FROM counter WHERE id = 2";
            cmd = new MySqlCommand(status, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtStatus2.Text = reader.GetString("status");
                txtNumber2.Text = reader.GetString("number");
            }
        }

        private void query3()
        {
            string status = "SELECT * FROM counter WHERE id = 3";
            cmd = new MySqlCommand(status, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtStatus3.Text = reader.GetString("status");
                txtNumber3.Text = reader.GetString("number");
            }
        }

        private void query4()
        {
            string status = "SELECT * FROM counter WHERE id = 4";
            cmd = new MySqlCommand(status, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtStatus4.Text = reader.GetString("status");
                txtNumber4.Text = reader.GetString("number");
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //txtStatus1.Text = /*database grep using i*/;
            //i++;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
