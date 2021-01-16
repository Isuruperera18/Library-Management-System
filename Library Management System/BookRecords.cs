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
	public partial class BookRecords : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public BookRecords()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Menu m12 = new Menu();
			m12.Show();
			this.Hide();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Books", con);
				adpt.Fill(dt);
				DGV6.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DGV6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtBoUPISBN.Text = DGV6.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtBoUPPrice.Text = DGV6.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtBoDELISBN.Text = DGV6.Rows[e.RowIndex].Cells[0].Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("update Books set Price='" + txtBoUPPrice.Text + "' where ISBN='" + txtBoUPISBN.Text + "' ", con);
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
			txtBoUPISBN.Text = "";
			txtBoUPPrice.Text = "";
			txtBoDELISBN.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("delete from Books where ISBN='" + txtBoDELISBN.Text + "' ", con);
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
