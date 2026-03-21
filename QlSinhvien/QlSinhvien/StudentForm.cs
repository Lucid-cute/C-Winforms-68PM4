using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QlSinhvien
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void reload_table()
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var students = db.Students.Select(s => new
            {
                id = s.id,
                name = s.name,
                email = s.email,
                mssv = s.mssv,
                classOf = db.Classes.FirstOrDefault(cl => cl.id == s.classId).name
            }).ToList();
            dataGridView1.DataSource = students;

            txtId.ReadOnly = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length != 0)
            {
                MessageBox.Show("Không điền id");
                return;
            }
            else
            {
                DatabaseDataContext db = new DatabaseDataContext();
                Student student = new Student();
                student.mssv = txtMssv.Text;
                student.name = txtName.Text;
                student.email = txtEmail.Text;
                student.classId = (int)comboBox1.SelectedValue;

                db.Students.InsertOnSubmit(student);
                db.SubmitChanges();
                reload_table();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reload_table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sua
            if (txtId.ReadOnly == true)
            {
                DatabaseDataContext db = new DatabaseDataContext();
                int id = int.Parse(txtId.Text);
                var student = db.Students.FirstOrDefault(c => c.id == id);
                if (student != null)
                {
                    student.name = txtName.Text;
                    student.email = txtEmail.Text;
                    student.classId = (int)comboBox1.SelectedValue;
                    student.mssv = txtMssv.Text;
                    db.SubmitChanges();
                    reload_table();
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //xoa
            if (txtId.ReadOnly == true)
            {
                DatabaseDataContext db = new DatabaseDataContext();
                int id = int.Parse(txtId.Text);
                var student = db.Students.FirstOrDefault(c => c.id == id);
                if (student != null)
                {
                    db.Students.DeleteOnSubmit(student);
                    db.SubmitChanges();
                    reload_table();
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn sinh viên");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtId.Text = row.Cells["id"].Value.ToString();
            txtName.Text = row.Cells["name"].Value.ToString();
            txtMssv.Text = row.Cells["mssv"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            comboBox1.Text = row.Cells["classOf"].Value.ToString();

            txtId.ReadOnly = true;
            
        }

        private void qlclass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassForm classForm = new ClassForm();
            classForm.ShowDialog();
            this.Close();

        }
    }
}
