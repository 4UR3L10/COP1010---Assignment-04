namespace SalaryAssignment
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.labelBonus = new System.Windows.Forms.Label();
            this.textBoxBonusSalary = new System.Windows.Forms.TextBox();
            this.labelOverTimeHours = new System.Windows.Forms.Label();
            this.textBoxOvertimeHours = new System.Windows.Forms.TextBox();
            this.labelOvertimePayment = new System.Windows.Forms.Label();
            this.textBoxOvertimePayment = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelSalaryNOBonus = new System.Windows.Forms.Label();
            this.textBoxSalaryNOBonus = new System.Windows.Forms.TextBox();
            this.labelTotalSalary = new System.Windows.Forms.Label();
            this.textBoxTotalSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(36, 42);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(919, 78);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "SALARY CALCULATOR 2.0";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(18, 160);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(364, 43);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Employee Name: ";
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRate.Location = new System.Drawing.Point(64, 233);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(318, 43);
            this.labelHourlyRate.TabIndex = 2;
            this.labelHourlyRate.Text = "Hourly Rate: ";
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoursWorked.Location = new System.Drawing.Point(41, 301);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(341, 43);
            this.labelHoursWorked.TabIndex = 3;
            this.labelHoursWorked.Text = "Hours Worked: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(388, 162);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(269, 41);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHourlyRate.Location = new System.Drawing.Point(388, 233);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(269, 41);
            this.textBoxHourlyRate.TabIndex = 5;
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoursWorked.Location = new System.Drawing.Point(388, 303);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(269, 41);
            this.textBoxHoursWorked.TabIndex = 6;
            // 
            // labelBonus
            // 
            this.labelBonus.AutoSize = true;
            this.labelBonus.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBonus.Location = new System.Drawing.Point(18, 454);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(318, 43);
            this.labelBonus.TabIndex = 7;
            this.labelBonus.Text = "Bonus Salary:";
            // 
            // textBoxBonusSalary
            // 
            this.textBoxBonusSalary.Enabled = false;
            this.textBoxBonusSalary.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBonusSalary.Location = new System.Drawing.Point(530, 454);
            this.textBoxBonusSalary.Name = "textBoxBonusSalary";
            this.textBoxBonusSalary.Size = new System.Drawing.Size(157, 41);
            this.textBoxBonusSalary.TabIndex = 8;
            // 
            // labelOverTimeHours
            // 
            this.labelOverTimeHours.AutoSize = true;
            this.labelOverTimeHours.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverTimeHours.Location = new System.Drawing.Point(18, 520);
            this.labelOverTimeHours.Name = "labelOverTimeHours";
            this.labelOverTimeHours.Size = new System.Drawing.Size(364, 43);
            this.labelOverTimeHours.TabIndex = 9;
            this.labelOverTimeHours.Text = "Overtime Hours:";
            // 
            // textBoxOvertimeHours
            // 
            this.textBoxOvertimeHours.Enabled = false;
            this.textBoxOvertimeHours.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOvertimeHours.Location = new System.Drawing.Point(530, 522);
            this.textBoxOvertimeHours.Name = "textBoxOvertimeHours";
            this.textBoxOvertimeHours.Size = new System.Drawing.Size(157, 41);
            this.textBoxOvertimeHours.TabIndex = 10;
            // 
            // labelOvertimePayment
            // 
            this.labelOvertimePayment.AutoSize = true;
            this.labelOvertimePayment.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOvertimePayment.Location = new System.Drawing.Point(18, 584);
            this.labelOvertimePayment.Name = "labelOvertimePayment";
            this.labelOvertimePayment.Size = new System.Drawing.Size(410, 43);
            this.labelOvertimePayment.TabIndex = 11;
            this.labelOvertimePayment.Text = "Overtime Payment:";
            this.labelOvertimePayment.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxOvertimePayment
            // 
            this.textBoxOvertimePayment.Enabled = false;
            this.textBoxOvertimePayment.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOvertimePayment.Location = new System.Drawing.Point(530, 586);
            this.textBoxOvertimePayment.Name = "textBoxOvertimePayment";
            this.textBoxOvertimePayment.Size = new System.Drawing.Size(157, 41);
            this.textBoxOvertimePayment.TabIndex = 12;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(36, 848);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(242, 159);
            this.buttonCalculate.TabIndex = 13;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(428, 870);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(152, 115);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(586, 870);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(152, 115);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelSalaryNOBonus
            // 
            this.labelSalaryNOBonus.AutoSize = true;
            this.labelSalaryNOBonus.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalaryNOBonus.Location = new System.Drawing.Point(12, 651);
            this.labelSalaryNOBonus.Name = "labelSalaryNOBonus";
            this.labelSalaryNOBonus.Size = new System.Drawing.Size(502, 43);
            this.labelSalaryNOBonus.TabIndex = 16;
            this.labelSalaryNOBonus.Text = "Salary Without Bonus:";
            // 
            // textBoxSalaryNOBonus
            // 
            this.textBoxSalaryNOBonus.Enabled = false;
            this.textBoxSalaryNOBonus.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalaryNOBonus.Location = new System.Drawing.Point(530, 653);
            this.textBoxSalaryNOBonus.Name = "textBoxSalaryNOBonus";
            this.textBoxSalaryNOBonus.Size = new System.Drawing.Size(157, 41);
            this.textBoxSalaryNOBonus.TabIndex = 17;
            // 
            // labelTotalSalary
            // 
            this.labelTotalSalary.AutoSize = true;
            this.labelTotalSalary.Font = new System.Drawing.Font("MS Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSalary.Location = new System.Drawing.Point(12, 758);
            this.labelTotalSalary.Name = "labelTotalSalary";
            this.labelTotalSalary.Size = new System.Drawing.Size(341, 43);
            this.labelTotalSalary.TabIndex = 18;
            this.labelTotalSalary.Text = "Total Salary: ";
            // 
            // textBoxTotalSalary
            // 
            this.textBoxTotalSalary.Enabled = false;
            this.textBoxTotalSalary.Font = new System.Drawing.Font("Mongolian Baiti", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalSalary.Location = new System.Drawing.Point(359, 768);
            this.textBoxTotalSalary.Name = "textBoxTotalSalary";
            this.textBoxTotalSalary.Size = new System.Drawing.Size(157, 41);
            this.textBoxTotalSalary.TabIndex = 19;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(955, 1036);
            this.Controls.Add(this.textBoxTotalSalary);
            this.Controls.Add(this.labelTotalSalary);
            this.Controls.Add(this.textBoxSalaryNOBonus);
            this.Controls.Add(this.labelSalaryNOBonus);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxOvertimePayment);
            this.Controls.Add(this.labelOvertimePayment);
            this.Controls.Add(this.textBoxOvertimeHours);
            this.Controls.Add(this.labelOverTimeHours);
            this.Controls.Add(this.textBoxBonusSalary);
            this.Controls.Add(this.labelBonus);
            this.Controls.Add(this.textBoxHoursWorked);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelHoursWorked);
            this.Controls.Add(this.labelHourlyRate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "BETA Salary Calculator";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.Label labelBonus;
        private System.Windows.Forms.TextBox textBoxBonusSalary;
        private System.Windows.Forms.Label labelOverTimeHours;
        private System.Windows.Forms.TextBox textBoxOvertimeHours;
        private System.Windows.Forms.Label labelOvertimePayment;
        private System.Windows.Forms.TextBox textBoxOvertimePayment;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelSalaryNOBonus;
        private System.Windows.Forms.TextBox textBoxSalaryNOBonus;
        private System.Windows.Forms.Label labelTotalSalary;
        private System.Windows.Forms.TextBox textBoxTotalSalary;
    }
}

