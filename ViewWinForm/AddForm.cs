using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ViewWinForm
{
    public partial class AddForm : Form, IAdd
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public event EventHandler<List<string>> AddStudentEvent;

        private void addButton_Click(object sender, EventArgs e)
        {
            List<string> newStudent = new List<string>();
            string name = surnameTextBox.Text + nameTextBox.Text + fatherNameTextBox.Text;
            newStudent.Add(name);
            string speciality = specialityTextBox.Text;
            newStudent.Add(speciality);
            string group = groupTextBox.Text;
            newStudent.Add(group);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(speciality) || string.IsNullOrEmpty(group))
                MessageBox.Show("Студент не добавлен. Было введено пустое значение. Попробуйте снова.", "Добавление", MessageBoxButtons.OK);
            else
            {
                AddStudentEvent(this, newStudent);
                MessageBox.Show("Студент успешно добавлен!", "Добавление", MessageBoxButtons.OK);
            }
            this.Close();
        }
    }
}
