using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Frame : Form
    {
        public Frame() => InitializeComponent();

        int i = 0;
        // Student[] students = new Student[short.MaxValue];
        List<Student> students = new List<Student>();

        private void addBtn_Click(object sender, System.EventArgs e)
        {
            if (Invaild()) return;
            Student s = GenerateStudent();
            if (IsExistsStudent(s)) return;
            AddRowToListView(s);
            CleanInputs();
        }

        private void updateBtn_Click(object sender, System.EventArgs e)
        {
            // TODO: Update student
            if (sListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
            if (Invaild()) return;
            Student s = GenerateStudent();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == s.Id)
                {
                    students[i] = s;
                    break;
                }
            }
            // Update row in ListView
            foreach (ListViewItem item in sListView.Items)
            {
                if (item.SubItems[1].Text == s.Id)
                {
                    item.SubItems[2].Text = s.Name;
                    item.SubItems[3].Text = s.Birthday;
                    item.SubItems[4].Text = s.FScore.ToString();
                    item.SubItems[5].Text = s.SScore.ToString();
                    item.SubItems[6].Text = s.AScore.ToString();
                    break;
                }
            }
            CleanInputs();
        }

        private void deleteBtn_Click(object sender, System.EventArgs e)
        {
            // delete selected student in listview
            if (sListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            ListViewItem item = sListView.SelectedItems[0];
            List<Student> _students = new List<Student>();
            string id = item.SubItems[1].Text;
            for (int n = 0; n < students.Count; n++)
            {
                if (students[n].Id == id)
                {
                    students.RemoveAt(n);
                    break;
                }
                if (students[n] != null) _students.Add(students[n]);
            }
            students = _students;
            sListView.Items.Remove(item);
            ReViewStudentList();
            CleanInputs();
        }

        private void searchBtn_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Tính năng hiện đang được phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
        }

        private void selectedIndexChanged_Click(object sender, System.EventArgs e)
        {
            // TODO: Show student info
            if (sListView.SelectedItems.Count == 0) return;
            ListViewItem item = sListView.SelectedItems[0];
            IId.Text = item.SubItems[1].Text;
            IName.Text = item.SubItems[2].Text;
            IDate.Value = System.DateTime.ParseExact(item.SubItems[3].Text, "dd/MM/yyyy", null);
            IFScore.Text = item.SubItems[4].Text;
            ISScore.Text = item.SubItems[5].Text;
        }

        private Student GenerateStudent()
        {
            decimal fS = decimal.Parse(IFScore.Text);
            decimal sS = decimal.Parse(ISScore.Text);
            return new Student(IId.Text, IName.Text, IDate.Value.ToString("dd/MM/yyyy"), fS, sS);
        }

        private bool Invaild()
        {
            if (
                IId.Text == string.Empty ||
                IName.Text == string.Empty ||
                IFScore.Text == string.Empty ||
                ISScore.Text == string.Empty
                )
            {
                MessageBox.Show("Thông tin sinh viên bị thiếu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (!decimal.TryParse(IFScore.Text, out decimal _) && !decimal.TryParse(ISScore.Text, out decimal _))
            {
                MessageBox.Show("Điểm phải là 1 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                decimal f = decimal.Parse(IFScore.Text);
                decimal s = decimal.Parse(ISScore.Text);

                if (f < 0 || f > 10 || s < 0 || s > 10)
                {
                    MessageBox.Show("Điểm phải lớn hơn 0 và nhỏ hơn 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private bool IsExistsStudent(Student s)
        {
            foreach (Student student in students)
            {
                if (student.Id == s.Id)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private void CleanInputs() => IId.Text = IName.Text = IFScore.Text = ISScore.Text = string.Empty;

        private void AddRowToListView(Student s)
        {
            ListViewItem item = new ListViewItem(((i++) + 1).ToString());
            item.SubItems.Add(s.Id);
            item.SubItems.Add(s.Name);
            item.SubItems.Add(s.Birthday);
            item.SubItems.Add(s.FScore.ToString());
            item.SubItems.Add(s.SScore.ToString());
            item.SubItems.Add(s.AScore.ToString());
            sListView.Items.Add(item);
            students.Add(s);
        }

        private void ReViewStudentList()
        {
            i = 0;
            sListView.Items.Clear();
            foreach (Student student in students)
            {
                AddRowToListView(student);
            }
        }
    }
}
