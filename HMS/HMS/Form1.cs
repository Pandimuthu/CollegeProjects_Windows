using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		
		SqlConnection con = new SqlConnection(@"Data Source = localhost; Initial Catalog = Hospital Management; Integrated Security = True");
		private void Form1_Load(object sender, EventArgs e)
		{
			panel1.Visible = false;
			con.Open();
		    SqlCommand cmd=new SqlCommand("select ID from dbo.DoctorDetails order by 1 Desc",con);
			int count = Convert.ToInt32(cmd.ExecuteScalar());
			txtid.Text = (count + 1).ToString();
			con.Close();
		}

		private void adddoc_Click(object sender, EventArgs e)
		{
			panel1.Visible = true;
		}

		private void btnsave_Click_1(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtname.Text) && !string.IsNullOrEmpty(cbgender.Text))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("insert into dbo.DoctorDetails values('" + txtname.Text + "'," + txtage.Text + ",'" + cbgender.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "'," + txtcontact.Text + ",'" + txtspecialist.Text + "','" + txtsalary.Text + "')", con);
				int i = cmd.ExecuteNonQuery();
				if (i > 0)
				{
					MessageBox.Show("Data is saved");
				}
				con.Close();
			}

		}

		private void btnclose_Click_1(object sender, EventArgs e)
		{
			panel1.Visible = false;
		}
	}
}
