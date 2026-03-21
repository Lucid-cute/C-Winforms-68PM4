using System;
using System.Linq;

namespace QlSinhvien
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qlclass = new System.Windows.Forms.Button();
            this.qlsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.mssv,
            this.name,
            this.email,
            this.classOf});
            this.dataGridView1.Location = new System.Drawing.Point(339, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 621);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // mssv
            // 
            this.mssv.HeaderText = "Mssv";
            this.mssv.MinimumWidth = 6;
            this.mssv.Name = "mssv";
            // 
            // name
            // 
            this.name.HeaderText = "Họ tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // classOf
            // 
            this.classOf.HeaderText = "Lớp";
            this.classOf.MinimumWidth = 6;
            this.classOf.Name = "classOf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mssv";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(30, 272);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 30);
            this.txtName.TabIndex = 21;
            // 
            // txtMssv
            // 
            this.txtMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMssv.Location = new System.Drawing.Point(23, 179);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(224, 30);
            this.txtMssv.TabIndex = 20;
            this.txtMssv.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(23, 104);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(224, 30);
            this.txtId.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 598);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 52);
            this.button4.TabIndex = 18;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 63);
            this.button3.TabIndex = 17;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ tên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(30, 366);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 30);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 450);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Lớp";
            // 
            // qlclass
            // 
            this.qlclass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.qlclass.Location = new System.Drawing.Point(1, -1);
            this.qlclass.Name = "qlclass";
            this.qlclass.Size = new System.Drawing.Size(165, 30);
            this.qlclass.TabIndex = 26;
            this.qlclass.Text = "Quản lý lớp";
            this.qlclass.UseVisualStyleBackColor = true;
            this.qlclass.Click += new System.EventHandler(this.qlclass_Click);
            // 
            // qlsv
            // 
            this.qlsv.Location = new System.Drawing.Point(162, -1);
            this.qlsv.Name = "qlsv";
            this.qlsv.Size = new System.Drawing.Size(165, 30);
            this.qlsv.TabIndex = 27;
            this.qlsv.Text = "Quản lý sinh viên";
            this.qlsv.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.qlsv);
            this.Controls.Add(this.qlclass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Student_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["id"].DataPropertyName = "id";
            dataGridView1.Columns["name"].DataPropertyName = "name";
            dataGridView1.Columns["mssv"].DataPropertyName = "mssv";
            dataGridView1.Columns["email"].DataPropertyName = "email";
            dataGridView1.Columns["classOf"].DataPropertyName = "classOf";

            //render table
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

            var classes = db.Classes.Select(c => new {
                id = c.id,
                name = c.name
            }).ToList();
            comboBox1.DataSource = classes;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndex = -1;

            qlsv.ForeColor = System.Drawing.Color.Red;
            qlsv.Enabled = false;

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button qlclass;
        private System.Windows.Forms.Button qlsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn classOf;
    }
}