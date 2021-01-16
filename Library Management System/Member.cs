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
	public partial class Member : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public Member()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Menu m2 = new Menu();
			m2.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtMemId.Text == "" || txtMemNIC.Text == "" || txtMemFirstname.Text == "" || txtMemLastname.Text == "" || txtMemEmail.Text == "" || txtMemPhonenumber.Text == "" || txtMemStreet.Text == "" || txtMemCity.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Member (MemberID,NIC,First_Name,Last_Name,Email,Phone_Number,Street,City) values ('" + txtMemId.Text + "','" + txtMemNIC.Text + "','" + txtMemFirstname.Text + "','" + txtMemLastname.Text + "','" + txtMemEmail.Text + "','" + txtMemPhonenumber.Text + "','" + txtMemStreet.Text + "','" + txtMemCity.Text + "')", con);
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

		public void clear()
		{
			txtMemId.Text = "";
			txtMemNIC.Text = "";
			txtMemFirstname.Text = "";
			txtMemLastname.Text = "";
			txtMemEmail.Text = "";
			txtMemPhonenumber.Text = "";
			txtMemStreet.Text = "";
			txtMemCity.Text = "";
			txtMemUPId.Text = "";
			txtMemUPPhonenumber.Text = "";
			txtMemDELId.Text = "";
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Member", con);
				adpt.Fill(dt);
				DGV2.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DGV2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMemUPId.Text = DGV2.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtMemUPPhonenumber.Text = DGV2.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtMemDELId.Text = DGV2.Rows[e.RowIndex].Cells[0].Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("update Member set Phone_Number='" + txtMemUPPhonenumber.Text + "' where MemberID='" + txtMemUPId.Text + "' ",con);
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

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("delete from Member where MemberID='" + txtMemDELId.Text + "' ", con);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data has been deleted");
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
