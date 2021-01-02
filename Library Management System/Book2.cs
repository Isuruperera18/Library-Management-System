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
	public partial class Book2 : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		public Book2()
		{
			InitializeComponent();
			con = new SqlConnection(path);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Menu m3 = new Menu();
			m3.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtBoISBN.Text == "" || txtBoTitle.Text == "" || txtBoPrice.Text == "" || txtBoPubId.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Books (ISBN,Title,Price ,PublisherID) values ('" + txtBoISBN.Text + "','" + txtBoTitle.Text + "','" + txtBoPrice.Text + "','" + txtBoPubId.Text + "')", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been saved");
					clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void clear()
		{
			txtBoISBN.Text = "";
			txtBoTitle.Text = "";
			txtBoPrice.Text = "";
			txtBoPubId.Text = "";
			txtAuName.Text = "";
			txtAuISBN.Text = "";
			txtCoNumber.Text = "";
			txtCoISBN.Text = "";
			txtCoTitle.Text = "";
			txtCoYear.Text = "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (txtAuName.Text == "" || txtAuISBN.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Author (Author_Name,ISBN) values ('" + txtAuName.Text + "','" + txtAuISBN.Text + "')", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been saved");
					clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (txtCoNumber.Text == "" || txtCoISBN.Text == "" || txtCoTitle.Text == "" || txtCoYear.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into CopyRecords (Copy_Number,ISBN,Title,Copy_Year) values ('" + txtCoNumber.Text + "','" + txtCoISBN.Text + "','" + txtCoTitle.Text + "','" + txtCoYear.Text + "')", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been saved");
					clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
