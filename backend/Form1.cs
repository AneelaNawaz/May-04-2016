using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace backend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            OleDbCommand cmd = new OleDbCommand("SELECT * from My_table;",con);

            DataTable table = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.ReadOnly = true;
          
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           
        }





           
            

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
        }
        }
    }

