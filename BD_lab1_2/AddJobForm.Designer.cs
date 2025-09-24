using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    partial class AddJobForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label_Title;
        private Label label_Employee;
        private TextBox textBox_EmployeeName;
        private Button button_SelectEmployee;
        private Label label_StartDate;
        private Label label_EndDate;
        private Label label_Description;
        private TextBox textBox_Description;
        private Button button_Cancel;
        private Button button_Save;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Employee = new System.Windows.Forms.Label();
            this.textBox_EmployeeName = new System.Windows.Forms.TextBox();
            this.button_SelectEmployee = new System.Windows.Forms.Button();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.Location = new System.Drawing.Point(3, 10);
            this.label_Title.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(194, 20);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Добавление работы";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Employee
            // 
            this.label_Employee.AutoSize = true;
            this.label_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Employee.Location = new System.Drawing.Point(3, 40);
            this.label_Employee.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_Employee.Name = "label_Employee";
            this.label_Employee.Size = new System.Drawing.Size(194, 25);
            this.label_Employee.TabIndex = 1;
            this.label_Employee.Text = "Работник:";
            this.label_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_EmployeeName
            // 
            this.textBox_EmployeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_EmployeeName.Location = new System.Drawing.Point(203, 43);
            this.textBox_EmployeeName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_EmployeeName.Name = "textBox_EmployeeName";
            this.textBox_EmployeeName.ReadOnly = true;
            this.textBox_EmployeeName.Size = new System.Drawing.Size(194, 20);
            this.textBox_EmployeeName.TabIndex = 0;
            // 
            // button_SelectEmployee
            // 
            this.button_SelectEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SelectEmployee.Location = new System.Drawing.Point(403, 43);
            this.button_SelectEmployee.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.button_SelectEmployee.Name = "button_SelectEmployee";
            this.button_SelectEmployee.Size = new System.Drawing.Size(94, 22);
            this.button_SelectEmployee.TabIndex = 1;
            this.button_SelectEmployee.Text = "Выбрать...";
            this.button_SelectEmployee.UseVisualStyleBackColor = true;
            this.button_SelectEmployee.Click += new System.EventHandler(this.button_SelectEmployee_Click);
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_StartDate.Location = new System.Drawing.Point(3, 70);
            this.label_StartDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(194, 25);
            this.label_StartDate.TabIndex = 3;
            this.label_StartDate.Text = "Дата начала работы:";
            this.label_StartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EndDate.Location = new System.Drawing.Point(3, 100);
            this.label_EndDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(194, 25);
            this.label_EndDate.TabIndex = 5;
            this.label_EndDate.Text = "Дата окончания работы:";
            this.label_EndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Description.Location = new System.Drawing.Point(3, 130);
            this.label_Description.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(194, 75);
            this.label_Description.TabIndex = 7;
            this.label_Description.Text = "Описание работы:";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Description.Location = new System.Drawing.Point(203, 133);
            this.textBox_Description.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(194, 72);
            this.textBox_Description.TabIndex = 4;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.Location = new System.Drawing.Point(3, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(194, 34);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Отменить";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Save.Location = new System.Drawing.Point(203, 3);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(294, 34);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_EndDate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_StartDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Employee, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_EmployeeName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_SelectEmployee, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_StartDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_EndDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Description, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Description, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 205);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.button_Cancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Save, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 215);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 40);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Checked = false;
            this.dateTimePicker_StartDate.CustomFormat = "";
            this.dateTimePicker_StartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(203, 73);
            this.dateTimePicker_StartDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker_StartDate.TabIndex = 17;
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Checked = false;
            this.dateTimePicker_EndDate.CustomFormat = "";
            this.dateTimePicker_EndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(203, 103);
            this.dateTimePicker_EndDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker_EndDate.TabIndex = 19;
            // 
            // AddJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddJobForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление работы";
            this.Load += new System.EventHandler(this.AddJobForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DateTimePicker dateTimePicker_EndDate;
        private DateTimePicker dateTimePicker_StartDate;
    }
}