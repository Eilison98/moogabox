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
using System.Configuration;
using moogabox;

namespace moogabox
{

	public partial class Form8 : Form
	{
		private string Constr = "Server=(local);database=moogabox;" +
			   "Integrated Security=true";

		public Form8()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			var Comm = new SqlCommand("delete from TmpReservation", Conn);
			Comm.ExecuteNonQuery();

			Conn.Close();

			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}

		private void Form8_Load(object sender, EventArgs e)
		{

			DataLoad();

		}
		private void DataLoad()
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			string InsertSql = string.Format("insert into Reservation select * from TmpReservation");
			var Com = new SqlCommand(InsertSql, Conn);
			Com.ExecuteNonQuery();

			var Comm = new SqlCommand("Select ID from TmpReservation", Conn);
			var myRead = Comm.ExecuteReader();
			string CurCustomerID = "";

			if (myRead.Read())
			{
				CurCustomerID = myRead[0].ToString();
			}
			myRead.Close();

			int a = 1;
			string TmpRsvCode = DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + a++.ToString("D2");

			InsertSql = "update Reservation set RsvCode = '" + TmpRsvCode + "' where ID = '" + CurCustomerID + "'";

			Com = new SqlCommand(InsertSql, Conn);
			Com.ExecuteNonQuery();

			InsertSql = "Select MvName, StartTime, Hall, SeatNum, RsvCode from Reservation where ID = '" + CurCustomerID + "'";
			Comm = new SqlCommand(InsertSql, Conn);
			
			myRead = Comm.ExecuteReader();
			if (myRead.Read())
			{
				this.txtMovie.Text = myRead[0].ToString();
				this.txtTime.Text = myRead[1].ToString();
				this.txtHallNum.Text = myRead[2].ToString();
				string[] SeatNum = new string[4];
				int length = myRead[3].ToString().Length / 2;

				int j = 0;
				for (int i = 0; i < length; i++)
				{
					SeatNum[i] = myRead[3].ToString().Substring(j, 2);
					j += 2;
					this.txtSeatNum.Text += SeatNum[i];
					if (i >= length - 1) break;
					this.txtSeatNum.Text += ", ";
				}
				this.txtNum.Text = myRead[4].ToString();
			}
			myRead.Close();

			Conn.Close();
		}

		private void Form8_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
