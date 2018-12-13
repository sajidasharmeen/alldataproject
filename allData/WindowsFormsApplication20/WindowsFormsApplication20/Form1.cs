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

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\users\sajida\documents\visual studio 2013\Projects\WindowsFormsApplication20\WindowsFormsApplication20\Database1.mdf");



        string valuee = "";
        private void button1_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked)
            {
                valuee = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                valuee = radioButton2.Text;
            }
            else
            {
                valuee = radioButton3.Text;
            }





            string query = "insert into abc values('" + textBox1.Text + "', '" + textBox2.Text + "','" + valuee + "' )";
            SqlCommand cmd = new SqlCommand(query);
            con.Open();

            //SqlCommand cmd;

            //cmd = new SqlCommand("insert into abc values '" + textBox1.Text + "', '" + textBox2.Text + "' , '" + textBox3.Text + "'" );
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
            MessageBox.Show("insert");
            con.Close();

           

            
        
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            string sql = "select * from login where id='" + textBox1.Text + "' AND pwd = '" + textBox2.Text + "'    ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {


            

                MessageBox.Show("login");
                Form2 obj = new Form2();
                obj.Show();


            }

            else
            {

                MessageBox.Show("invalid");

            }




            con.Close();
        }


       
            
       


    }
}
