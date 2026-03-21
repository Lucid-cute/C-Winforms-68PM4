using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlSinhvien
{
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
        }
        private void reloadTable()
        {
            DatabaseDataContext db = new DatabaseDataContext();
            var classes = db.Classes.Select(c => new
            {
                id = c.id,
                name = c.name,
                count = db.Students.Count(s => s.classId == c.id)
            }).ToList();
            Console.WriteLine("helo");
            Console.WriteLine(classes);
            dataGridView1.DataSource = classes;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                MessageBox.Show("Không điền id");
                return;
            }
            else
            {
                DatabaseDataContext db = new DatabaseDataContext();
                Class newClass = new Class();
                newClass.name = textBox2.Text;

                db.Classes.InsertOnSubmit(newClass);
                db.SubmitChanges();
                reloadTable();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            reloadTable();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["id"].Value.ToString();
            textBox2.Text = row.Cells["name"].Value.ToString();
            textBox3.Text = row.Cells["svCount"].Value.ToString();

            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //xoa
            if(textBox1.ReadOnly == true)
            {
                DatabaseDataContext db = new DatabaseDataContext();
                int id = int.Parse(textBox1.Text);
                var classs = db.Classes.FirstOrDefault(c => c.id == id);
                if (classs != null) { 
                    classs.name = textBox2.Text;
                    db.SubmitChanges();
                    reloadTable();
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn lớp");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sua
            if (textBox1.ReadOnly == true)
            {
                DatabaseDataContext db = new DatabaseDataContext();
                int id = int.Parse(textBox1.Text);
                var classs = db.Classes.FirstOrDefault(c => c.id == id);
                if (classs != null)
                {
                    db.Classes.DeleteOnSubmit(classs);
                    db.SubmitChanges();
                    reloadTable();
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn lớp");
            }
        }

        private void qlsv_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm();
            
            studentForm.ShowDialog();
            this.Close();
            
        }
    }
}
