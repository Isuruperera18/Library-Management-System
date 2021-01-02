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
	public partial class Lend : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public Lend()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Menu m5 = new Menu();
			m5.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtLeId.Text == "" || txtLeISBN.Text == "" || txtLeMemId.Text == "" || txtLeCoNumber.Text == "" || txtLeIssuedate.Text == "" || txtLeReturneddate.Text == "" || txtLeDuedate.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Lend (LendingID,ISBN,MemberID,Copy_Number,Issue_Date,Returned_Date,Due_Date) values ('" + txtLeId.Text + "','" + txtLeISBN.Text + "','" + txtLeMemId.Text + "','" + txtLeCoNumber.Text + "','" + txtLeIssuedate.Text + "','" + txtLeReturneddate.Text + "','" + txtLeDuedate.Text + "')", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been saved");
					clear();
					display();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Lend", con);
				adpt.Fill(dt);
				DGV4.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void clear()
		{
			txtLeId.Text = "";
			txtLeISBN.Text = "";
			txtLeMemId.Text = "";
			txtLeCoNumber.Text = "";
			txtLeIssuedate.Text = "";
			txtLeReturneddate.Text = "";
			txtLeDuedate.Text = "";
		}

		private void DGV4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtLeUPId.Text = DGV4.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtLeUPRetureddate.Text = DGV4.Rows[e.RowIndex].Cells[5].Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("update Lend set Returned_Date='" + txtLeUPRetureddate.Text + "' where LendingID='" + txtLeUPId.Text + "' ", con);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data has been updated");
				clear();
				display();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
