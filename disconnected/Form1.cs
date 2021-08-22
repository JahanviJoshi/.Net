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

namespace disconnected
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            //con.ConnectionString = "Data Source= DESKTOP-JCLI3CL\SQLEXPRESS; Initial Catalog=College ;Integrated Security=True";
            con.ConnectionString = @"Data Source=DESKTOP-JCLI3CL\SQLEXPRESS;Initial Catalog=College;Integrated Security=True";
            con.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "select Ans from Result";
            SqlCommand cm = new SqlCommand(q, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = 0;
            foreach (DataRow row in dt.Rows)
                {
                    if (radioButton2.Checked)
                    {
                        if (radioButton2.Text == row["Ans"].ToString())
                        { count++; }
                    }
                    if (radioButton7.Checked)
                    {
                        if (radioButton7.Text == row["Ans"].ToString())
                        { count++; }
                    }
                    if (radioButton12.Checked)
                    {
                        if (radioButton12.Text == row["Ans"].ToString())
                        { count++; }
                    }
                    if (radioButton13.Checked)
                    {
                        if (radioButton13.Text == row["Ans"].ToString())
                        { count++; }
                    }
                }
                label8.Text = "Result is:" + count.ToString();
                con.Close();
            
        }
    }
}
