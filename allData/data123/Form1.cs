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
namespace data123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ab;User ID=sa;Password=aptech");
        private void button1_Click(object sender, EventArgs e)
        {
           

            string query = "insert into ab  values('" + textBox1.Text + "', '" + textBox2.Text + "' , '" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(query);
            con.Open();

            //SqlCommand cmd;
           
            //cmd = new SqlCommand("insert into abc values '" + textBox1.Text + "', '" + textBox2.Text + "' , '" + textBox3.Text + "'" );
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
            MessageBox.Show("insert");
            con.Close();
            //dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand("update abc set name='" + textBox2.Text + "' , email='"+textBox3.Text+"' where id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();  
 }

        private void button3_Click(object sender, EventArgs e)
        {
          con.Open();
         string query=" delete from abc where id ='" + textBox1.Text + "' ";
           
            SqlCommand sc = new SqlCommand(query);
            sc.Connection = con;
            sc.ExecuteNonQuery();
            MessageBox.Show("delete");
            con.Close();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string SQL;
            SQL = "select * from abc where'" + textBox1.Text + "' "; 
            SqlDataAdapter da = new SqlDataAdapter(SQL, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SeaGreen;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SeaGreen;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.BlueViolet;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Gray;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
