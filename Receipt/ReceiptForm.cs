using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receipt
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(string name, int hoursWorked, float salaryPerHour, int extraHours, float subtotal, string tax, float taxValue, float total)
        {
            InitializeComponent();
            labelName.Text = name;
            labelHoursWorked.Text = hoursWorked.ToString();
            labelSalaryPerHour.Text = salaryPerHour.ToString();
            labelExtraHours.Text = extraHours.ToString();
            labelSubtotal.Text = subtotal.ToString();
            labelTax.Text = tax;
            labelTaxValue.Text = taxValue.ToString();
            labelTotal.Text = total.ToString();
        }
    }
}
