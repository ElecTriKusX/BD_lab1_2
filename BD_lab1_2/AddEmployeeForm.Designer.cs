using System;
using System.Drawing;
using System.Windows.Forms;

namespace BD_lab1_2
{
    partial class AddEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label_Title;
        private Label label_FullName;
        private TextBox textBox_FullName;
        private Label label_BirthDate;
        private TextBox textBox_BirthDate;
        private Label label_INN;
        private TextBox textBox_INN;
        private Label label_PensionCertificate;
        private TextBox textBox_PensionCertificate;
        private Label label_PassportData;
        private TextBox textBox_PassportData;
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
            this.label_FullName = new System.Windows.Forms.Label();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
            this.label_BirthDate = new System.Windows.Forms.Label();
            this.textBox_BirthDate = new System.Windows.Forms.TextBox();
            this.label_INN = new System.Windows.Forms.Label();
            this.textBox_INN = new System.Windows.Forms.TextBox();
            this.label_PensionCertificate = new System.Windows.Forms.Label();
            this.textBox_PassportData = new System.Windows.Forms.TextBox();
            this.label_PassportData = new System.Windows.Forms.Label();
            this.textBox_PensionCertificate = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
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
            this.label_Title.Location = new System.Drawing.Point(3, 10);
            this.label_Title.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(194, 20);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Добавление работника";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_FullName.Location = new System.Drawing.Point(3, 40);
            this.label_FullName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(194, 25);
            this.label_FullName.TabIndex = 1;
            this.label_FullName.Text = "ФИО работника:";
            this.label_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_FullName.Location = new System.Drawing.Point(203, 43);
            this.textBox_FullName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(194, 20);
            this.textBox_FullName.TabIndex = 0;
            // 
            // label_BirthDate
            // 
            this.label_BirthDate.AutoSize = true;
            this.label_BirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_BirthDate.Location = new System.Drawing.Point(3, 70);
            this.label_BirthDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_BirthDate.Name = "label_BirthDate";
            this.label_BirthDate.Size = new System.Drawing.Size(194, 25);
            this.label_BirthDate.TabIndex = 3;
            this.label_BirthDate.Text = "Дата рождения:";
            this.label_BirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_BirthDate
            // 
            this.textBox_BirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_BirthDate.Location = new System.Drawing.Point(203, 73);
            this.textBox_BirthDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_BirthDate.Name = "textBox_BirthDate";
            this.textBox_BirthDate.Size = new System.Drawing.Size(194, 20);
            this.textBox_BirthDate.TabIndex = 1;
            // 
            // label_INN
            // 
            this.label_INN.AutoSize = true;
            this.label_INN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_INN.Location = new System.Drawing.Point(3, 100);
            this.label_INN.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_INN.Name = "label_INN";
            this.label_INN.Size = new System.Drawing.Size(194, 25);
            this.label_INN.TabIndex = 5;
            this.label_INN.Text = "ИНН:";
            this.label_INN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_INN
            // 
            this.textBox_INN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_INN.Location = new System.Drawing.Point(203, 103);
            this.textBox_INN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_INN.Name = "textBox_INN";
            this.textBox_INN.Size = new System.Drawing.Size(194, 20);
            this.textBox_INN.TabIndex = 2;
            // 
            // label_PensionCertificate
            // 
            this.label_PensionCertificate.AutoSize = true;
            this.label_PensionCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PensionCertificate.Location = new System.Drawing.Point(3, 130);
            this.label_PensionCertificate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_PensionCertificate.Name = "label_PensionCertificate";
            this.label_PensionCertificate.Size = new System.Drawing.Size(194, 25);
            this.label_PensionCertificate.TabIndex = 7;
            this.label_PensionCertificate.Text = "№ пенсионного свидетельства:";
            this.label_PensionCertificate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_PassportData
            // 
            this.textBox_PassportData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PassportData.Location = new System.Drawing.Point(203, 163);
            this.textBox_PassportData.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_PassportData.Name = "textBox_PassportData";
            this.textBox_PassportData.Size = new System.Drawing.Size(194, 20);
            this.textBox_PassportData.TabIndex = 4;
            // 
            // label_PassportData
            // 
            this.label_PassportData.AutoSize = true;
            this.label_PassportData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PassportData.Location = new System.Drawing.Point(3, 160);
            this.label_PassportData.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_PassportData.Name = "label_PassportData";
            this.label_PassportData.Size = new System.Drawing.Size(194, 40);
            this.label_PassportData.TabIndex = 9;
            this.label_PassportData.Text = "Паспортные данные:";
            this.label_PassportData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_PensionCertificate
            // 
            this.textBox_PensionCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PensionCertificate.Location = new System.Drawing.Point(203, 133);
            this.textBox_PensionCertificate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_PensionCertificate.Name = "textBox_PensionCertificate";
            this.textBox_PensionCertificate.Size = new System.Drawing.Size(194, 20);
            this.textBox_PensionCertificate.TabIndex = 3;
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
            this.button_Save.Size = new System.Drawing.Size(194, 34);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_FullName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FullName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_BirthDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_BirthDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_INN, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_INN, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_PensionCertificate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PensionCertificate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_PassportData, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_PassportData, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 205);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_Cancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_Save, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 215);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 40);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление работника";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}