using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    partial class DeleteJobForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label_Title;
        private Label label_ID;
        private TextBox textBox_ID;
        private Label label_EmployeeID;
        private TextBox textBox_EmployeeID;
        private Label label_EmployeeName;
        private TextBox textBox_EmployeeName;
        private Label label_StartDate;
        private TextBox textBox_StartDate;
        private Label label_EndDate;
        private TextBox textBox_EndDate;
        private Label label_Description;
        private TextBox textBox_Description;
        private Button button_Cancel;
        private Button button_Delete;
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
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_EmployeeID = new System.Windows.Forms.Label();
            this.textBox_EmployeeID = new System.Windows.Forms.TextBox();
            this.label_EmployeeName = new System.Windows.Forms.Label();
            this.textBox_EmployeeName = new System.Windows.Forms.TextBox();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.textBox_StartDate = new System.Windows.Forms.TextBox();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.textBox_EndDate = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.ForeColor = System.Drawing.Color.Red;
            this.label_Title.Location = new System.Drawing.Point(3, 10);
            this.label_Title.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(194, 20);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Удаление работы";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ID.Location = new System.Drawing.Point(3, 40);
            this.label_ID.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(194, 25);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "Код работы:";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ID.Location = new System.Drawing.Point(203, 43);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(294, 20);
            this.textBox_ID.TabIndex = 0;
            // 
            // label_EmployeeID
            // 
            this.label_EmployeeID.AutoSize = true;
            this.label_EmployeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EmployeeID.Location = new System.Drawing.Point(3, 70);
            this.label_EmployeeID.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_EmployeeID.Name = "label_EmployeeID";
            this.label_EmployeeID.Size = new System.Drawing.Size(194, 25);
            this.label_EmployeeID.TabIndex = 3;
            this.label_EmployeeID.Text = "Код работника:";
            this.label_EmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_EmployeeID
            // 
            this.textBox_EmployeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_EmployeeID.Location = new System.Drawing.Point(203, 73);
            this.textBox_EmployeeID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_EmployeeID.Name = "textBox_EmployeeID";
            this.textBox_EmployeeID.Size = new System.Drawing.Size(294, 20);
            this.textBox_EmployeeID.TabIndex = 1;
            // 
            // label_EmployeeName
            // 
            this.label_EmployeeName.AutoSize = true;
            this.label_EmployeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EmployeeName.Location = new System.Drawing.Point(3, 100);
            this.label_EmployeeName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_EmployeeName.Name = "label_EmployeeName";
            this.label_EmployeeName.Size = new System.Drawing.Size(194, 25);
            this.label_EmployeeName.TabIndex = 5;
            this.label_EmployeeName.Text = "ФИО работника:";
            this.label_EmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_EmployeeName
            // 
            this.textBox_EmployeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_EmployeeName.Location = new System.Drawing.Point(203, 103);
            this.textBox_EmployeeName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_EmployeeName.Name = "textBox_EmployeeName";
            this.textBox_EmployeeName.Size = new System.Drawing.Size(294, 20);
            this.textBox_EmployeeName.TabIndex = 2;
            // 
            // label_StartDate
            // 
            this.label_StartDate.AutoSize = true;
            this.label_StartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_StartDate.Location = new System.Drawing.Point(3, 130);
            this.label_StartDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(194, 25);
            this.label_StartDate.TabIndex = 7;
            this.label_StartDate.Text = "Дата начала работы:";
            this.label_StartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_StartDate
            // 
            this.textBox_StartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_StartDate.Location = new System.Drawing.Point(203, 133);
            this.textBox_StartDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_StartDate.Name = "textBox_StartDate";
            this.textBox_StartDate.Size = new System.Drawing.Size(294, 20);
            this.textBox_StartDate.TabIndex = 3;
            // 
            // label_EndDate
            // 
            this.label_EndDate.AutoSize = true;
            this.label_EndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_EndDate.Location = new System.Drawing.Point(3, 160);
            this.label_EndDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(194, 25);
            this.label_EndDate.TabIndex = 9;
            this.label_EndDate.Text = "Дата окончания работы:";
            this.label_EndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_EndDate
            // 
            this.textBox_EndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_EndDate.Location = new System.Drawing.Point(203, 163);
            this.textBox_EndDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_EndDate.Name = "textBox_EndDate";
            this.textBox_EndDate.Size = new System.Drawing.Size(294, 20);
            this.textBox_EndDate.TabIndex = 4;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Description.Location = new System.Drawing.Point(3, 190);
            this.label_Description.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(194, 80);
            this.label_Description.TabIndex = 11;
            this.label_Description.Text = "Описание работы:";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Description.Location = new System.Drawing.Point(203, 193);
            this.textBox_Description.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(294, 77);
            this.textBox_Description.TabIndex = 5;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.Location = new System.Drawing.Point(3, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(244, 34);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Отменить";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Delete.Location = new System.Drawing.Point(253, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(244, 34);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_ID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_EmployeeID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_EmployeeID, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_EmployeeName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_EmployeeName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_StartDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_StartDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_EndDate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_EndDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_Description, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Description, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 275);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_Cancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Delete, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 285);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 40);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // DeleteJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 335);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteJobForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление работы";
            this.Load += new System.EventHandler(this.DeleteJobForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}