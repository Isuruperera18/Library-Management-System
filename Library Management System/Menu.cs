using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Book2 b1 = new Book2();
			b1.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Books b2 = new Books();
			b2.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Lend l1 = new Lend();
			l1.Show();
			this.Hide();
		}


		private void button5_Click(object sender, EventArgs e)
		{
			Library l2 = new Library();
			l2.Show();
			this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Member m8 = new Member();
			m8.Show();
			this.Hide();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			LibrarianInfo l3 = new LibrarianInfo();
			l3.Show();
			this.Hide();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			BookRecords b5 = new BookRecords();
			b5.Show();
			this.Hide();
		}
	}
}
