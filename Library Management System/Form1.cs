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
	public partial class Form1 : Form
	{
		//String Connection
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		public Form1()
		{
			InitializeComponent();
			con = new SqlConnection(path);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Member m1 = new Member();
			m1.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string username, password;

			username = txtUsername.Text;
			password = txtPassword.Text;

			if(username=="admin" && password=="admin123")
			{
				Menu m9 = new Menu();
				m9.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Incorrect Credentials");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(txtLibID.Text=="" || txtLibNIC.Text=="" || txtLibFirstname.Text=="" || txtLibLastname.Text=="" || txtLibLibraryname.Text=="" || txtLibEmail.Text=="" || txtLibPhonenumber.Text=="" || txtLibStreet.Text=="" || txtLibCity.Text=="" || txtLibPassword.Text=="")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Librarian (LibrarianID,NIC,First_Name,Last_Name,Library_Name,Email,Phone_Number,Street,City,PWD) values ('" + txtLibID.Text + "','" + txtLibNIC.Text + "','" + txtLibFirstname.Text + "','" + txtLibLastname.Text + "','" + txtLibLibraryname.Text + "','" + txtLibEmail.Text + "','" + txtLibPhonenumber.Text + "','" + txtLibStreet.Text + "','" + txtLibCity.Text + "','" + txtLibPassword.Text + "')", con);
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
			txtLibID.Text = "";
			txtLibNIC.Text = "";
			txtLibFirstname.Text = "";
			txtLibLastname.Text = "";
			txtLibLibraryname.Text = "";
			txtLibEmail.Text = "";
			txtLibPhonenumber.Text = "";
			txtLibStreet.Text = "";
			txtLibCity.Text = "";
			txtLibPassword.Text = "";
		}
	}
}
