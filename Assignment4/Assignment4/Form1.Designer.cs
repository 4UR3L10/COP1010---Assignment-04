namespace Assignment4
{
    partial class salaryCalculatorForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.hourlyRate = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursWorked = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hoursOvertime = new System.Windows.Forms.Label();
            this.overtimePayment = new System.Windows.Forms.Label();
            this.grossSalary = new System.Windows.Forms.Label();
            this.bonusSalary = new System.Windows.Forms.Label();
            this.totalSalary = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 48);
            this.textBox1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 99);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(176, 47);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "First name:";
            // 
            // hourlyRate
            // 
            this.hourlyRate.AutoSize = true;
            this.hourlyRate.Location = new System.Drawing.Point(36, 155);
            this.hourlyRate.Name = "hourlyRate";
            this.hourlyRate.Size = new System.Drawing.Size(193, 47);
            this.hourlyRate.TabIndex = 2;
            this.hourlyRate.Text = "Hourly Rate:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 48);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "$";
            // 
            // hoursWorked
            // 
            this.hoursWorked.AutoSize = true;
            this.hoursWorked.Location = new System.Drawing.Point(36, 206);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(227, 47);
            this.hoursWorked.TabIndex = 5;
            this.hoursWorked.Text = "Hours Worked:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salary Bonus:";
            // 
            // hoursOvertime
            // 
            this.hoursOvertime.AutoSize = true;
            this.hoursOvertime.Location = new System.Drawing.Point(36, 298);
            this.hoursOvertime.Name = "hoursOvertime";
            this.hoursOvertime.Size = new System.Drawing.Size(247, 47);
            this.hoursOvertime.TabIndex = 7;
            this.hoursOvertime.Text = "Overtime Hours:";
            // 
            // overtimePayment
            // 
            this.overtimePayment.AutoSize = true;
            this.overtimePayment.Location = new System.Drawing.Point(36, 345);
            this.overtimePayment.Name = "overtimePayment";
            this.overtimePayment.Size = new System.Drawing.Size(279, 47);
            this.overtimePayment.TabIndex = 8;
            this.overtimePayment.Text = "Overtime Payment:";
            // 
            // grossSalary
            // 
            this.grossSalary.AutoSize = true;
            this.grossSalary.Location = new System.Drawing.Point(36, 392);
            this.grossSalary.Name = "grossSalary";
            this.grossSalary.Size = new System.Drawing.Size(370, 47);
            this.grossSalary.TabIndex = 9;
            this.grossSalary.Text = "Gross Salary (No Bonus): ";
            // 
            // bonusSalary
            // 
            this.bonusSalary.AutoSize = true;
            this.bonusSalary.Location = new System.Drawing.Point(36, 439);
            this.bonusSalary.Name = "bonusSalary";
            this.bonusSalary.Size = new System.Drawing.Size(305, 47);
            this.bonusSalary.TabIndex = 10;
            this.bonusSalary.Text = "Salary (With Bonus):";
            // 
            // totalSalary
            // 
            this.totalSalary.AutoSize = true;
            this.totalSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalary.Location = new System.Drawing.Point(44, 519);
            this.totalSalary.Name = "totalSalary";
            this.totalSalary.Size = new System.Drawing.Size(192, 49);
            this.totalSalary.TabIndex = 11;
            this.totalSalary.Text = "Total Salary:";
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(631, 664);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(224, 74);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(23, 596);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(282, 142);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(399, 664);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(224, 74);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(61, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(852, 73);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "SALARY CALCULATOR 2.0";
            // 
            // salaryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(869, 764);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.totalSalary);
            this.Controls.Add(this.bonusSalary);
            this.Controls.Add(this.grossSalary);
            this.Controls.Add(this.overtimePayment);
            this.Controls.Add(this.hoursOvertime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.hourlyRate);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "salaryCalculatorForm";
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label hourlyRate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hoursWorked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hoursOvertime;
        private System.Windows.Forms.Label overtimePayment;
        private System.Windows.Forms.Label grossSalary;
        private System.Windows.Forms.Label bonusSalary;
        private System.Windows.Forms.Label totalSalary;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
    }
}

