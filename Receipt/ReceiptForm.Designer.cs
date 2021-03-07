
namespace Receipt
{
    partial class ReceiptForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelExtraHours = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTaxValue = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSalaryPerHour = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recibo de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas trabajadas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario por hora: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horas extras trabajadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subtotal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Impuesto correspondiente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor del impuesto: $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total a pagar: $";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(150, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(13, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "0";
            // 
            // labelExtraHours
            // 
            this.labelExtraHours.AutoSize = true;
            this.labelExtraHours.Location = new System.Drawing.Point(160, 106);
            this.labelExtraHours.Name = "labelExtraHours";
            this.labelExtraHours.Size = new System.Drawing.Size(13, 13);
            this.labelExtraHours.TabIndex = 10;
            this.labelExtraHours.Text = "0";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(75, 141);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(13, 13);
            this.labelSubtotal.TabIndex = 11;
            this.labelSubtotal.Text = "0";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(171, 162);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(13, 13);
            this.labelTax.TabIndex = 12;
            this.labelTax.Text = "0";
            // 
            // labelTaxValue
            // 
            this.labelTaxValue.AutoSize = true;
            this.labelTaxValue.Location = new System.Drawing.Point(142, 182);
            this.labelTaxValue.Name = "labelTaxValue";
            this.labelTaxValue.Size = new System.Drawing.Size(13, 13);
            this.labelTaxValue.TabIndex = 13;
            this.labelTaxValue.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(113, 204);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "0";
            // 
            // labelSalaryPerHour
            // 
            this.labelSalaryPerHour.AutoSize = true;
            this.labelSalaryPerHour.Location = new System.Drawing.Point(127, 85);
            this.labelSalaryPerHour.Name = "labelSalaryPerHour";
            this.labelSalaryPerHour.Size = new System.Drawing.Size(13, 13);
            this.labelSalaryPerHour.TabIndex = 15;
            this.labelSalaryPerHour.Text = "0";
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Location = new System.Drawing.Point(122, 65);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(13, 13);
            this.labelHoursWorked.TabIndex = 16;
            this.labelHoursWorked.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 298);
            this.Controls.Add(this.labelHoursWorked);
            this.Controls.Add(this.labelSalaryPerHour);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTaxValue);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelExtraHours);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Recibo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelExtraHours;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTaxValue;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSalaryPerHour;
        private System.Windows.Forms.Label labelHoursWorked;
    }
}