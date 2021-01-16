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


namespace Library_Management_System
{
	public partial class Library : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
		SqlConnection con;
		SqlDataAdapter adpt;
		DataTable dt;
		public Library()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Menu m7 = new Menu();
			m7.Show();
			this.Hide();
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Branch", con);
				adpt.Fill(dt);
				DGV5.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
