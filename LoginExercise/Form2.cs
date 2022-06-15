using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginExercise
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=User_tabel;User ID=sa;Password=***********");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO member(NIM,NAMA,UMUR) VALUES (@NIM,@NAMA,@UMUR)", con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NAMA", textBox2.Text);
            cmd.Parameters.AddWithValue("UMUR", textBox3.Text);
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Successfully inserted!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=User_tabel;User ID=sa;Password=***********");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE member SET NAMA=@NAMA WHERE NIM=@NIM", con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NAMA", textBox2.Text);
            cmd.Parameters.AddWithValue("UMUR", textBox3.Text);
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Successfully upadated!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=User_tabel;User ID=sa;Password=***********");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE member WHERE NIM=@NIM", con);
            cmd.Parameters.AddWithValue("@NIM", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Successfully delete!!");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=User_tabel;User ID=sa;Password=***********");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM member", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=User_tabel;User ID=sa;Password=***********");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM member", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
