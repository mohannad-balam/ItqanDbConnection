using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItqanDbConnection
{
    public partial class Employee : Form
    {   
        public Employee()
        {
            InitializeComponent();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=APTX4869;Initial Catalog=EmployeesDatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rdr;

        private void ClearTb()
        {
            fnameTb.Clear();
            lnameTb.Clear();
            salaryTb.Clear();
            phoneTb.Clear();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                if(fnameTb.Text == "" || lnameTb.Text == "" || salaryTb.Text == "" || phoneTb.Text == "")
                {
                    MessageBox.Show("information missing");
                    return;
                }
                string query = "INSERT INTO tbEmployee VALUES (@fname,@lname,@salary,@phone)";
                cmd = new SqlCommand(query,Con);
                cmd.Parameters.AddWithValue("@fname", fnameTb.Text);
                cmd.Parameters.AddWithValue("@lname", lnameTb.Text);
                cmd.Parameters.AddWithValue("@salary", double.Parse(salaryTb.Text));
                cmd.Parameters.AddWithValue("@phone", phoneTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
                ClearTb();
                loadEmployees();
            }catch(Exception ex)
            {
                Con.Close();
                MessageBox.Show(ex.Message);
            }
        }


        public void loadEmployees()
        {
            employeeDgv.Rows.Clear();
            try
            {
                Con.Open();
                string query = "SELECT * FROM tbEmployee";
                cmd = new SqlCommand(query,Con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    employeeDgv.Rows.Add(rdr[0].ToString(),rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString());
                }
                rdr.Close();
                Con.Close();
            }catch(Exception ex)
            {
                Con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }

        int empId = 0;
        private void employeeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = employeeDgv.Columns[e.ColumnIndex].Name;
            if(colName == "edit")
            {
                empId = int.Parse(employeeDgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(empId.ToString());
                fnameTb.Text = employeeDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                lnameTb.Text = employeeDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                salaryTb.Text = employeeDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                phoneTb.Text = employeeDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else if(colName == "delete")
            {
                try
                {
                    if(MessageBox.Show("are you sure ?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Con.Open();
                        empId = int.Parse(employeeDgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                        string query = "DELETE FROM tbEmployee WHERE id = @id";
                        cmd = new SqlCommand(query,Con);
                        cmd.Parameters.AddWithValue("@id", empId);
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        loadEmployees();
                    }
                    
                }catch(Exception ex)
                {
                    Con.Close();
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = "UPDATE tbEmployee SET first_name=@fname, last_name=@lname, salary=@salary, phone=@phone WHERE id=@id";
                cmd = new SqlCommand(query,Con);
                cmd.Parameters.AddWithValue("@fname", fnameTb.Text);
                cmd.Parameters.AddWithValue("@lname", lnameTb.Text);
                cmd.Parameters.AddWithValue("@salary", double.Parse(salaryTb.Text));
                cmd.Parameters.AddWithValue("@phone", phoneTb.Text);
                cmd.Parameters.AddWithValue("@id", empId);
                cmd.ExecuteNonQuery();
                Con.Close();
                loadEmployees();
            }catch(Exception ex)
            {
                Con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
