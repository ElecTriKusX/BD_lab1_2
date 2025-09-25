using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class SelectEmployeeForm : Form
    {
        private DataSet_main dataSet;
        public DataSet_main.EmployeesRow SelectedEmployee { get; private set; }

        public SelectEmployeeForm(DataSet_main dataSet)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            dataGridView_Employees.DataSource = dataSet.Employees;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employees.CurrentRow == null)
            {
                MessageBox.Show("Выберите работника!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView_Employees.CurrentRow;
            SelectedEmployee = ((DataRowView)selectedRow.DataBoundItem).Row as DataSet_main.EmployeesRow;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SelectEmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridView_Employees.ClearSelection();
        }
    }
}