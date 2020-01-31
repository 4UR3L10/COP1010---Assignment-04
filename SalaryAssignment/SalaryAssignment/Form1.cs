using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryAssignment
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(999);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            /*
             * Clears values of textboxes when RESET button is clicked.
             */
            textBoxName.Text = " ";
            textBoxHourlyRate.Text = " ";
            textBoxHoursWorked.Text = " ";
            textBoxBonusSalary.Text = " ";
            textBoxOvertimeHours.Text = " ";
            textBoxOvertimePayment.Text = " ";
            textBoxSalaryNOBonus.Text = " ";
            textBoxTotalSalary.Text = " ";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                String name = " ";
                const double BONUS = 0.01;
                double hourlyRate;
                double hoursWorked;
                double bonusSalary;
                double overtimeHours;
                double overtimePayment = 0;

                hourlyRate = Double.Parse(textBoxHourlyRate.Text);
                hoursWorked = Double.Parse(textBoxHoursWorked.Text);

                overtimeHours = hoursWorked - 40;
                bonusSalary = (hourlyRate * hoursWorked) * BONUS;

                if (overtimeHours <= 0)
                {
                    textBoxOvertimeHours.Text = "NADA";
                    textBoxOvertimePayment.Text = "NADA";
                }
                else
                {
                    textBoxOvertimeHours.Text = overtimeHours.ToString();
                    overtimePayment = hourlyRate / 2;
                    overtimePayment = overtimePayment + hourlyRate;
                    overtimePayment = overtimeHours * overtimePayment;
                    textBoxOvertimePayment.Text = labelOvertimePayment.ToString();
                    
                }
                    // Bonus percentage
                    textBoxBonusSalary.Text = bonusSalary.ToString();
                    // Salary without bonus
                    double salaryNOBonus = hoursWorked * hourlyRate;
                    salaryNOBonus = salaryNOBonus + overtimePayment;
                    textBoxSalaryNOBonus.Text = salaryNOBonus.ToString();
                    // Total Salary
                    double totalSalary;
                    totalSalary = salaryNOBonus + bonusSalary;
                    totalSalary = totalSalary + salaryNOBonus;
                    textBoxTotalSalary.Text = totalSalary.ToString();
                
            } catch
            {
                MessageBox.Show("Solo numeros come fana borra esa pinga beo!");
            }
        }
    }
}
