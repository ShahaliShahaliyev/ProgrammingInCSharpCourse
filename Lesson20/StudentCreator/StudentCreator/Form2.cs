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
    public partial class Form2 : Form
    {
        private const string FilePath = @"C:\Users\Shahali\Documents\Students";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(FilePath);
            var lastFile = directory.GetFiles().OrderByDescending(n => n.Name).Select(f => f.Name).FirstOrDefault();

            int Id;
            if (lastFile == null)
            {
                Id = 1;
            }
            else
            {
                Id = int.Parse(Path.GetFileNameWithoutExtension(lastFile));
                Id++;
            }

            Student student = new Student();

            if (radioButton1.Checked == true)
            {
                student.Gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                student.Gender = "Fermale";
            }

            var text = $"{int.Parse(textBox1.Text)} {textBox2.Text} {textBox3.Text}" +
                $" {dateTimePicker1.Value} {textBox4.Text} {textBox5.Text}  {student.Gender}";
            var filePath = Path.Combine(FilePath, $"{Id}.txt");
            File.WriteAllText(filePath, text);

            MessageBox.Show("Student Added!");
        }
    }
}
