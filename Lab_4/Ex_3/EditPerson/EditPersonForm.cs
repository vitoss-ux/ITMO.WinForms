using System;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class EditPersonForm : Form
    {
        Person p;

        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }

        public int Age
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public EditPersonForm (Person p)
        {
            InitializeComponent();
            this.p = p;
            FirstName = p.FirstName;
            LastName = p.LastName;
            Age = p.Age;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            p.FirstName = this.FirstName;
            p.LastName = this.LastName;
            p.Age = this.Age;
            MessageBox.Show("Сотрудник: " + p.ToString());
        }
    }
}