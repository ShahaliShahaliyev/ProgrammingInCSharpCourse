using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCreator
{
    public partial class Form1 : Form
    {
        private const string FilePath = @"C:\Users\Shahali\Documents\Students";

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(FilePath + $"\\{int.Parse(textBox1.Text)}.txt");
                MessageBox.Show("Student deleted");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] students = Directory.GetFiles(FilePath);
            for (int i = 0; i < students.Length; i++)
            {
                listBox1.Items.Add(File.ReadAllText(students[i]));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] students = Directory.GetFiles(FilePath);
            for (int i = 0; i < students.Length; i++)
            {
                listBox1.Items.Add(File.ReadAllText(students[i]));
            }
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Adress { get; set; }
    }
}
