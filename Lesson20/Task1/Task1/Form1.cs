using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MessageBox.Show("Hello!");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Id = (int)numericUpDown1.Value,
                Name = textBox2.Text,
                Surname = textBox3.Text,
                DateOfBirth = dateTimePicker1.Value.Date,
                Nationality = textBox5.Text,
                Adress = textBox7.Text
            };

            if (radioButton1.Checked == true)
            {
                student.Gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                student.Gender = "Female";
            }

            string path = @"C:\Users\Shahali\Documents\Lesson20Students";

            var students = student.StudentProperties();

            int id = 0;
            id++;

            File.AppendAllText(path + $"\\{id}.txt", students);

            MessageBox.Show("Student added!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Shahali\Documents\Lesson20Students";

            File.Delete(path + $"\\{textBox8.Text}.txt");

            MessageBox.Show("Student deleted!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Shahali\Documents\Lesson20Students\1.txt";

            string[] readText = File.ReadAllLines(path);

            foreach (string text in readText)
            {
                MessageBox.Show(text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
