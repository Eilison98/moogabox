using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using moogabox;


namespace moogabox
{
    public partial class Form0 : Form
    {
        private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true";
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(Constr);
            Conn.Open();

            SqlCommand Comm = new SqlCommand("Select * from Member where ID = '" + this.txtId.Text + "'", Conn);
            SqlDataReader reader = Comm.ExecuteReader();
            if (reader.Read())
            {
                string strpwd = reader["PW"].ToString();
                int Who = Convert.ToInt32(reader["Who"].ToString());

                if (strpwd == this.txtPw.Text)
                {
                    reader.Close();
                    Conn.Close();

                    if (Who == 0)
                    {
                        Form1 frm1 = new Form1();
                        frm1.Show();
                        this.Hide();
                    }

                    else if (Who == 1)
                    {
                        ManagerForm1 MForm1 = new ManagerForm1();
                        MForm1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렸습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClear();
                }
            }
            else
            {
                MessageBox.Show("해당 사용자가 없습니다.", "알람", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClear();
            }
            reader.Close();
            Conn.Close();
        }

        private void txtClear()
        {
            this.txtId.Text = "";
            this.txtPw.Text = "";
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            회원가입 frm10 = new 회원가입();
            DialogResult result = frm10.ShowDialog();
            if(result == DialogResult.Cancel || result == DialogResult.OK)
            {
                frm10.Close();
            }
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtId;
        }
    }
}
