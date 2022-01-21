using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace userManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string seqCount()
        {
            try
            {
                string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
                string Query = "SELECT MAX(userSeq)+1 AS seqMax FROM dawoon.dc_user;";
                MySqlConnection con = new MySqlConnection(Connect);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    return rdr["seqMax"].ToString();
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }
        private void showData()
        {
            try
            {
                string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
                string Query = "select * from dawoon.dc_user;";
              
                MySqlConnection con = new MySqlConnection(Connect);
                MySqlCommand Comm = new MySqlCommand(Query, con);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = Comm;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[dataGridView1.Columns.Count - 4].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 3].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkBoxDelShow_CheckedChanged(object sender, EventArgs e)
        {
            
            buttonSearch_Click(sender, e);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요");
                textBoxId.Focus();
                return;
            }
            try
            {
                string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
                string Query = "insert into dawoon.dc_user(userSeq,userID,userDate,userNm,userPhone,userAddress,email,memo,flagYN,regDate,issueDate,issueID) values('"
                    + seqCount() + "','" + textBoxId.Text.Trim() + "','" + textBoxDate.Text.Trim() + "','" 
                    + textBoxName.Text.Trim() + "','" + textBoxPhone.Text.Trim() + "','" + textBoxAddress.Text.Trim() 
                    + "','" + textBoxEmail.Text.Trim() + "','" + textBoxMemo.Text.Trim() + "','Y',now(),now(),'CDY');";
                MySqlConnection con = new MySqlConnection(Connect);
                MySqlCommand Comm = new MySqlCommand(Query, con);
                MySqlDataReader Read;
                con.Open();
                Read = Comm.ExecuteReader();
                MessageBox.Show("저장완료");
                con.Close();
                clear();
                buttonSearch_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string seqstr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
                string Query = "update dawoon.dc_user set flagYN='N' WHERE userSeq=" + seqstr;
                MySqlConnection con = new MySqlConnection(Connect);
                MySqlCommand Comm = new MySqlCommand(Query, con);
                MySqlDataReader Read;
                con.Open();
                Read = Comm.ExecuteReader();
                MessageBox.Show("삭제완료");
                con.Close();
                buttonSearch_Click(sender, e);
                clear();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string seqstr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
                string Query = "update dawoon.dc_user set userSeq='" + seqstr + "',userID='" + textBoxId.Text + "',userDate='" + textBoxDate.Text + "',userNm='" + textBoxName.Text + "',userPhone='" + textBoxPhone.Text + "',userAddress='" + textBoxAddress.Text + "',email='" + textBoxEmail.Text + "',memo='" + textBoxMemo.Text + "' where userSeq='" + seqstr + "';";
                MySqlConnection con = new MySqlConnection(Connect);
                MySqlCommand Comm = new MySqlCommand(Query, con);
                MySqlDataReader Read;
                con.Open();
                Read = Comm.ExecuteReader();
                MessageBox.Show("수정완료");
                while (Read.Read())
                {

                }
                con.Close();
                buttonSearch_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxMemo.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSearch_Click(sender, e);
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == "")
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string Connect = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
            string Query = "select * from dawoon.dc_user;";
            string searchtext = textBoxSearch.Text.Trim();
            string keyText = comboBoxSearch.Text;
            string field = "";
            if (keyText == "회원ID") field = "userID";
            else if (keyText == "등록일") field = "userDate";
            else if (keyText == "이름") field = "userNm";
            else if (keyText == "연락처") field = "userPhone";
            else if (keyText == "주소") field = "userAddress";
            else if (keyText == "이메일") field = "email";
            else if (keyText == "메모") field = "memo";
            string flagYN = "";
            if (checkBoxDelShow.Checked == true)
            {
                flagYN = "";
            }
            else
            {
                flagYN = "AND flagYN = 'Y'";
            }
            Query = "select * from dawoon.dc_user WHERE " + field + " like '%" + searchtext + "%' " + flagYN;
           
            //

            MySqlConnection con = new MySqlConnection(Connect);
            MySqlCommand Comm = new MySqlCommand(Query, con);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = Comm;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[dataGridView1.Columns.Count - 4].Visible = false;
            dataGridView1.Columns[dataGridView1.Columns.Count - 3].Visible = false;
            dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
        }
        private void clear()
        {
            textBoxName.Text = "";
            textBoxMemo.Text = "";
            textBoxPhone.Text = "";
            textBoxSearch.Text = "";
            textBoxId.Text = "";
            textBoxDate.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
        }
    }
}
