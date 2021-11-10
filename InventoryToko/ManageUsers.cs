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

namespace InventoryToko
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        //Connect ke Data Base SQL Server
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\dwi\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void CloseTb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            { 
            }
        }

        private void AddBt_Click(object sender, EventArgs e)
        {            
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('"+IdUserTxt.Text+"','" + UserNameTxt.Text + "','" + FullNameTxt.Text + "','" + PasswordTxt.Text + "','" + TelephoneTxt.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Di Simpan");
                Con.Close();
                populate();
                IdUserTxt.Text = "";
                UserNameTxt.Text = "";
                FullNameTxt.Text = "";
                PasswordTxt.Text = "";
                TelephoneTxt.Text = "";
            }
            catch
            {
            }
        }

        private void clearBt_Click(object sender, EventArgs e)
        {
                IdUserTxt.Text = "";
                UserNameTxt.Text = "";
                FullNameTxt.Text = "";
                PasswordTxt.Text = "";
                TelephoneTxt.Text = ""; 
        }

        private void DelBt_Click(object sender, EventArgs e)
        {
            if (TelephoneTxt.Text == "") 
            {
                MessageBox.Show("Enter the user no telpon");
            }
            else
            {
                Con.Open();
                String myquery = "DELETE from UserTbl WHERE IdUser='" + IdUserTxt.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sukses Di hapus");
                Con.Close();
                populate();
            }
        }

        private void UsersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.UsersGv.Rows[e.RowIndex];
            IdUserTxt.Text = row.Cells["IdUser"].Value.ToString();
            UserNameTxt.Text = row.Cells["Username"].Value.ToString();
            FullNameTxt.Text = row.Cells["Ufullname"].Value.ToString();
            PasswordTxt.Text = row.Cells["Upassword"].Value.ToString();
            TelephoneTxt.Text = row.Cells["Uphone"].Value.ToString();
            //UserNameTxt.Text = UsersGv.SelectedRows[0].Cells["Username"].Value.ToString();
           //FullNameTxt.Text = UsersGv.SelectedRows[0].Cells[1].Value.ToString();
            //PasswordTxt.Text = UsersGv.SelectedRows[0].Cells[2].Value.ToString();
            //TelephoneTxt.Text = UsersGv.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void UsersGv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET Username='" + UserNameTxt.Text + "', Ufullname = '" + FullNameTxt.Text + "', Upassword = '" + PasswordTxt.Text + "', Uphone = '" + TelephoneTxt.Text + "' WHERE IdUser = '" + IdUserTxt.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Di UBAH");
                Con.Close();
                populate();

                IdUserTxt.Text = "";
                UserNameTxt.Text = "";
                FullNameTxt.Text = "";
                PasswordTxt.Text = "";
                TelephoneTxt.Text = "";
            }
            catch
            {
            }
        }

    }
}
