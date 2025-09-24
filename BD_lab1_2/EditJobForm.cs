using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BD_lab1_2
{
    public partial class EditJobForm : Form
    {
        private DataSet_main dataSet;
        private DataSet_main.JobRow jobToEdit;

        public EditJobForm(DataSet_main dataSet, DataSet_main.JobRow job)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.jobToEdit = job;

            // Заполняем поля данными выбранной работы
            if (job != null)
            {
                textBox_ID.Text = job.ID;
                textBox_StartDate.Text = job.StartDate;
                textBox_EndDate.Text = job.EndDate;
                textBox_Description.Text = job.Description;

                // Получаем ФИО работника
                var employee = dataSet.Employees.FirstOrDefault(emp => emp.ID == job.EmployeeID);
                if (employee != null)
                {
                    textBox_EmployeeName.Text = employee.FullName;
                    textBox_EmployeeID.Text = job.EmployeeID;
                }

                // Делаем поля ID и EmployeeID только для чтения
                SetIDControlsReadOnly();
            }
        }

        private void SetIDControlsReadOnly()
        {
            textBox_ID.ReadOnly = true;
            textBox_EmployeeID.ReadOnly = true;
            textBox_EmployeeName.ReadOnly = true;

            textBox_ID.BackColor = SystemColors.Control;
            textBox_EmployeeID.BackColor = SystemColors.Control;
            textBox_EmployeeName.BackColor = SystemColors.Control;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            // Проверка заполнения обязательных полей
            if (string.IsNullOrWhiteSpace(textBox_StartDate.Text))
            {
                MessageBox.Show("Поле 'Дата начала работы' обязательно для заполнения!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_StartDate.Focus();
                return;
            }
            // Дата начала не позже 2100 года
            if (dateTimePicker_StartDate.Value.Year > 2100)
            {
                MessageBox.Show("Дата начала не может быть позже 2100 года!");
                return;
            }

            // Дата окончания не позже 2100 и не раньше начала
            if (dateTimePicker_EndDate.Value.Year > 2100)
            {
                MessageBox.Show("Дата окончания не может быть позже 2100 года!");
                return;
            }
            if (dateTimePicker_EndDate.Value < dateTimePicker_StartDate.Value)
            {
                MessageBox.Show("Дата окончания не может быть раньше даты начала!");
                return;
            }
            if (textBox_Description.Text.Length > 3000)
            {
                MessageBox.Show("Описание не должно превышать 3000 символов!");
                return;
            }
            if (jobToEdit == null)
            {
                MessageBox.Show("Не выбрана работа для редактирования!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Обновляем данные работы
                jobToEdit.BeginEdit();
                jobToEdit.StartDate = textBox_StartDate.Text.Trim();
                jobToEdit.EndDate = textBox_EndDate.Text.Trim();
                jobToEdit.Description = textBox_Description.Text.Trim();
                jobToEdit.EndEdit();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditJobForm_Load(object sender, EventArgs e)
        {
            // Устанавливаем фокус на поле даты начала при загрузке формы
            textBox_StartDate.Focus();
        }

        private void button_SelectEmployee_Click(object sender, EventArgs e)
        {
            using (var selectForm = new SelectEmployeeForm(dataSet))
            {
                if (selectForm.ShowDialog() == DialogResult.OK && selectForm.SelectedEmployee != null)
                {
                    var selectedEmployee = selectForm.SelectedEmployee;
                    textBox_EmployeeName.Text = selectedEmployee.FullName;
                    textBox_EmployeeID.Text = selectedEmployee.ID;

                    // Обновляем EmployeeID в редактируемой записи
                    if (jobToEdit != null)
                    {
                        jobToEdit.BeginEdit();
                        jobToEdit.EmployeeID = selectedEmployee.ID;
                        jobToEdit.EndEdit();
                    }
                }
            }
        }
    }
}