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

namespace Inword_Outword
{
    public partial class Add_Assigned_To : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        public Add_Assigned_To()
        {
            InitializeComponent();
        }

        private void filldatagrid()
        {

            cn = new
           SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string sql = "select * from faculty";
            cmd = new SqlCommand(sql, cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvfaculty.DataSource = dt;
            dgvfaculty.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            cn.Close();
        }
        private void Add_Assigned_To_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'akimssDataSet.faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this.akimssDataSet.faculty);
            SqlConnection conn = new SqlConnection("Data source=LAPTOP-GR01H1AK;Initial catalog=akimss;integrated security=true");
            SqlCommand cmd = new SqlCommand("select c_id,c_name from course", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table1 = new DataTable();
            da.Fill(table1);

            DataRow itemrow = table1.NewRow();
            itemrow[1] = "Select Department";
            table1.Rows.InsertAt(itemrow, 0);

            cmbc_name.DataSource = table1;
            cmbc_name.DisplayMember = "c_name";
            cmbc_name.ValueMember = "c_id";


            cmbdesig.SelectedIndex = 0;
            cmbc_name.SelectedIndex = 0;

            filldatagrid();
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
           
        }
        private void clearall()
        {
            lbl_f_id.Text = "";
            txtf_name.Text = "";
            cmbdesig.Text = "Select Designation";
            cmbc_name.Text = "Select Department";
            lbl_c_id.Text = "";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    cn = new
                    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "insert into faculty(f_name,f_desig,c_name,c_id) values (@lblf_name,@lblf_desig,@lblc_name,@lblc_id)";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lblf_name", txtf_name.Text);
                    cmd.Parameters.AddWithValue("@lblf_desig", cmbdesig.Text);
                    cmd.Parameters.AddWithValue("@lblc_name", cmbc_name.Text);
                    cmd.Parameters.AddWithValue("@lblc_id", lbl_c_id.Text);

                    int r;
                    cn.Open();
                    r = cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records are saved" + r, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldatagrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvassigned_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_f_id.Text = dgvfaculty.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtf_name.Text = dgvfaculty.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbdesig.Text = dgvfaculty.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbc_name.Text = dgvfaculty.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    cn = new
    SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sql = "update faculty set f_name=@lblf_name, f_desig=@lblf_desig, c_name=@lblc_name, c_id=@lblc_id where f_id=@lblf_id";
                    cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@lblf_name", txtf_name.Text);
                    cmd.Parameters.AddWithValue("@lblf_desig", cmbdesig.Text);
                    cmd.Parameters.AddWithValue("@lblc_name", cmbc_name.Text);
                    cmd.Parameters.AddWithValue("@lblf_id", lbl_f_id.Text);
                    cmd.Parameters.AddWithValue("@lblc_id", lbl_c_id.Text);
                    int r;
                    cn.Open();
                    r = cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records Updated are " + r, "Updated..", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    filldatagrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new
               SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string sql = "delete from faculty where f_id=@lblf_id ";
                cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@lblf_id", lbl_f_id.Text);
                int r;
                cn.Open();
                r = cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Records Deleted are " + r, "Deleted..", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                filldatagrid();
                clearall();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnout_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvassigned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbc_name_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_c_id.Text = cmbc_name.SelectedValue.ToString();
        }
        private bool validate ()
        {
            if (txtf_name.Text == "")
            {
                MessageBox.Show("Please Enter Assigned To Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtf_name.Focus();
                return false;
            }
            else if (cmbdesig.Text == "Select Designation")
            {
                MessageBox.Show("Please Enter Assigned To Designation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               cmbdesig.Focus();
                return false;
            }
            else if (cmbc_name.Text == "Select Department")
            {

                MessageBox.Show("Please Select Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbc_name.Focus();
                return false;
            }
            return true;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cmbc_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blkpen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            e.Graphics.DrawRectangle(blkpen, 0, 0, 420, 210);
        }

        private void cmbc_name_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void inwardToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inward i = new Inward();

            i.Show();
            Visible = false;
        }

        private void outwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            outward o = new outward();
            o.Show();
            Visible = false;
        }

        private void inwardToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void academicYearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            a.ShowDialog();
        }
    }
}
