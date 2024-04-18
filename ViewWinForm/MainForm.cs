using ais_5_0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinForm
{
    public partial class MainForm : Form, IMain
    {
        private AddForm AddForm;
        public MainForm(AddForm addForm)
        {
            InitializeComponent();
            AddForm = addForm;
        }

        public event EventHandler<EventArgs> showAddForm;
        public event EventHandler<int> deleteStudentEvent;
        public void loadStudents(List<string> students)
        {
            studentsListView.Items.Clear();
            for (int i = 3; i < students.Count; i += 4)
            {
                ListViewItem listView = new ListViewItem(students[i - 3]);
                listView.SubItems.Add(students[i - 2]);
                listView.SubItems.Add(students[i - 1]);
                listView.SubItems.Add(students[i]);
                studentsListView.Items.Add(listView);
            }
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            if (studentsListView.SelectedItems.Count > 0)
            {
                int id = int.Parse(studentsListView.SelectedItems[0].Text);
                deleteStudentEvent?.Invoke(this, id);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm.ShowDialog();
        }
    }
}
