using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
{   
    InitializeComponent();

    try
    {
        dataSet_main.ReadXml("DataSet.xml");
        Console.WriteLine("Loaded");

        // Создаем вычисляемый столбец в DataTable
        if (!dataSet_main.Job.Columns.Contains("EmployeeFullName"))
        {
            DataColumn fullNameColumn = new DataColumn("EmployeeFullName", typeof(string));
            fullNameColumn.Expression = "Parent(FK_Employees_Job).FullName";
            dataSet_main.Job.Columns.Add(fullNameColumn);
        }

        employeesBindingSource.ResetBindings(false);
        jobBindingSource.ResetBindings(false);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

private void JobBindingSource_ListChanged(object sender, ListChangedEventArgs e)
{
    if (e.ListChangedType == ListChangedType.ItemChanged || 
        e.ListChangedType == ListChangedType.Reset)
    {
        // При изменении данных обновляем отображение
        UpdateEmployeeFullNames();
    }
}

private void UpdateEmployeeFullNames()
{
    DataRelation relation = dataSet_main.Relations["FK_Employees_Job"];
    
    foreach (DataRowView rowView in jobBindingSource)
    {
        DataSet_main.JobRow jobRow = rowView.Row as DataSet_main.JobRow;
        if (jobRow != null && !jobRow.IsNull("EmployeeID"))
        {
            DataRow[] parentRows = jobRow.GetParentRows(relation);
            if (parentRows.Length > 0)
            {
                DataSet_main.EmployeesRow employeeRow = parentRows[0] as DataSet_main.EmployeesRow;
                // Обновляем значение через BindingSource
                rowView["EmployeeFullName"] = employeeRow.FullName;
            }
        }
    }
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet_main.EmployeesRow selectedEmployee = null;

            // Если есть выбранный работник в таблице работников, используем его
            if (dataGridView_Employee.CurrentRow != null)
            {
                selectedEmployee = ((DataRowView)dataGridView_Employee.CurrentRow.DataBoundItem).Row as DataSet_main.EmployeesRow;
            }

            using (AddJobForm addForm = new AddJobForm(dataSet_main, selectedEmployee))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    jobBindingSource.ResetBindings(false);
                }
            }
        }

        private void button_EmployeeAdd_Click(object sender, EventArgs e)
        {
            using (AddEmployeeForm addForm = new AddEmployeeForm(dataSet_main))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    employeesBindingSource.ResetBindings(false);
                }
            }
        }

        private void button_EmployeeDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employee.CurrentRow == null)
            {
                MessageBox.Show("Выберите работника для удаления!", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Получаем выбранную строку
            var selectedRow = dataGridView_Employee.CurrentRow;
            var employee = ((DataRowView)selectedRow.DataBoundItem).Row as DataSet_main.EmployeesRow;

            if (employee != null)
            {
                using (DeleteEmployeeForm deleteForm = new DeleteEmployeeForm(dataSet_main, employee))
                {
                    if (deleteForm.ShowDialog() == DialogResult.OK)
                    {
                        employeesBindingSource.ResetBindings(false);
                    }
                }
            }
        }

        private void button_EmployeeEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employee.CurrentRow == null)
            {
                MessageBox.Show("Выберите работника для редактирования!", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Получаем выбранную строку
            var selectedRow = dataGridView_Employee.CurrentRow;
            var employee = ((DataRowView)selectedRow.DataBoundItem).Row as DataSet_main.EmployeesRow;

            if (employee != null)
            {
                using (EditEmployeeForm editForm = new EditEmployeeForm(dataSet_main, employee))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        employeesBindingSource.ResetBindings(false);
                    }
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button_JobDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Job.CurrentRow == null)
            {
                MessageBox.Show("Выберите работу для удаления!", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Получаем выбранную строку
            var selectedRow = dataGridView_Job.CurrentRow;
            var job = ((DataRowView)selectedRow.DataBoundItem).Row as DataSet_main.JobRow;

            if (job != null)
            {
                using (DeleteJobForm deleteForm = new DeleteJobForm(dataSet_main, job))
                {
                    if (deleteForm.ShowDialog() == DialogResult.OK)
                    {
                        jobBindingSource.ResetBindings(false);
                    }
                }
            }
        }

        private void button_JobEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Job.CurrentRow == null)
            {
                MessageBox.Show("Выберите работу для редактирования!", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Получаем выбранную строку
            var selectedRow = dataGridView_Job.CurrentRow;
            var job = ((DataRowView)selectedRow.DataBoundItem).Row as DataSet_main.JobRow;

            if (job != null)
            {
                using (EditJobForm editForm = new EditJobForm(dataSet_main, job))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        jobBindingSource.ResetBindings(false);
                    }
                }
            }
        }
    }
}
