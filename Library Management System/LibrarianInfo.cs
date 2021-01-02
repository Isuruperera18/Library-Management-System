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
	public partial class LibrarianInfo : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public LibrarianInfo()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Menu m10 = new Menu();
			m10.Show();
			this.Hide();
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Librarian", con);
				adpt.Fill(dt);
				DGV1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtLibUPId.Text = DGV1.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtLibUPPhonenumber.Text = DGV1.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtLibUPPassword.Text = DGV1.Rows[e.RowIndex].Cells[9].Value.ToString();
			txtLibDELId.Text = DGV1.Rows[e.RowIndex].Cells[0].Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("update Librarian set Phone_Number='" + txtLibUPPhonenumber.Text + "' , PWD='" + txtLibUPPassword.Text + "' where LibrarianID='" + txtLibUPId.Text + "' ", con);
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

		public void clear()
		{
			txtLibUPId.Text = "";
			txtLibUPPhonenumber.Text = "";
			txtLibUPPassword.Text = "";
			txtLibDELId.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("delete from Librarian where LibrarianID='" + txtLibDELId.Text + "' ", con);
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
