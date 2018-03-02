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


namespace Week2
{
    public partial class frm_Registration : Form
    {
        public frm_Registration()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        string connstr = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void grbox_registration_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("INSERT INTO students (Name, Address) VALUES (@Name, @Address)", conn);

            cmd.Parameters.AddWithValue("@Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@Address", txt_address.Text);

            conn.Open();
            if(cmd.ExecuteNonQuery()==1)
            {
                lbl_label.ForeColor = System.Drawing.Color.Green;
                lbl_label.Text = "Successfully added!";
             }
            conn.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM students WHERE Name LIKE'" + txt_search.Text + "%'", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                grd_search.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data to show");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Registration_Load(object sender, EventArgs e)
        {

        }
        SqlDataReader rdr;
        private void btn_showall_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("SELECT * FROM students", conn);
            DataTable dt = new DataTable();

            conn.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dt.Load(rdr);
                grd_search.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data to show");
            }
            conn.Close();
        }

        public int ID;
        private void grd_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = grd_search.Rows[e.RowIndex];

            ID = Convert.ToInt32(row.Cells["id"].Value);
            txt_name.Text = row.Cells["name"].Value.ToString();
            txt_address.Text = row.Cells["address"].Value.ToString();
        }

        private void btn_button_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            cmd = new SqlCommand("Update students Set Name=@Name, Address=@Address WHERE ID=@id", conn);

            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@Name", txt_name.Text);
            cmd.Parameters.AddWithValue("@Address", txt_address.Text);

            conn.Open();
            if(cmd.ExecuteNonQuery()==1)
                {
                ShowAll();
                lbl_label.ForeColor = System.Drawing.Color.Green;
                lbl_label.Text = "Successfully Updated";
            }
            conn.Close();

        }

    }
}
