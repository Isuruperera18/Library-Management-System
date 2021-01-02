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
	public partial class Books : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public Books()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Menu m4 = new Menu();
			m4.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtPubId.Text == "" || txtPubName.Text == "" || txtPubNumber.Text == "" || txtPubStreet.Text == "" || txtPubCity.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Publisher (PublisherID,FullName,Phone_Number,Street,City) values ('" + txtPubId.Text + "','" + txtPubName.Text + "','" + txtPubNumber.Text + "','" + txtPubStreet.Text + "','" + txtPubCity.Text + "')", con);
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
			txtPubId.Text = "";
			txtPubName.Text = "";
			txtPubNumber.Text = "";
			txtPubStreet.Text = "";
			txtPubCity.Text = "";
			txtPubUPId.Text = "";
			txtPubUPNumber.Text = "";
			txtPubDELId.Text = "";
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Publisher", con);
				adpt.Fill(dt);
				DGV3.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("update Publisher set Phone_Number='" + txtPubUPNumber.Text + "' where PublisherID='" + txtPubUPId.Text + "' ", con);
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

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("delete from Publisher where PublisherID='" + txtPubDELId.Text + "' ", con);
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

		private void DGV3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtPubUPId.Text = DGV3.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtPubUPNumber.Text = DGV3.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtPubDELId.Text = DGV3.Rows[e.RowIndex].Cells[0].Value.ToString();
		}
	}
}
