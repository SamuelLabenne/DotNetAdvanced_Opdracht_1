namespace Oefening5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ctof = new System.Windows.Forms.Button();
            this.tb_celsius = new System.Windows.Forms.TextBox();
            this.tb_fahrenheit = new System.Windows.Forms.TextBox();
            this.btn_ftoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_errors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ctof
            // 
            this.btn_ctof.Location = new System.Drawing.Point(222, 202);
            this.btn_ctof.Name = "btn_ctof";
            this.btn_ctof.Size = new System.Drawing.Size(75, 23);
            this.btn_ctof.TabIndex = 0;
            this.btn_ctof.Text = "C to F";
            this.btn_ctof.UseVisualStyleBackColor = true;
            this.btn_ctof.Click += new System.EventHandler(this.btn_ctof_Click);
            // 
            // tb_celsius
            // 
            this.tb_celsius.Location = new System.Drawing.Point(197, 173);
            this.tb_celsius.Name = "tb_celsius";
            this.tb_celsius.Size = new System.Drawing.Size(100, 23);
            this.tb_celsius.TabIndex = 1;
            // 
            // tb_fahrenheit
            // 
            this.tb_fahrenheit.Location = new System.Drawing.Point(315, 173);
            this.tb_fahrenheit.Name = "tb_fahrenheit";
            this.tb_fahrenheit.Size = new System.Drawing.Size(100, 23);
            this.tb_fahrenheit.TabIndex = 2;
            // 
            // btn_ftoc
            // 
            this.btn_ftoc.Location = new System.Drawing.Point(315, 202);
            this.btn_ftoc.Name = "btn_ftoc";
            this.btn_ftoc.Size = new System.Drawing.Size(75, 23);
            this.btn_ftoc.TabIndex = 3;
            this.btn_ftoc.Text = "F to C";
            this.btn_ftoc.UseVisualStyleBackColor = true;
            this.btn_ftoc.Click += new System.EventHandler(this.btn_ftoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fahrenheit";
            // 
            // lb_errors
            // 
            this.lb_errors.AutoSize = true;
            this.lb_errors.Location = new System.Drawing.Point(259, 130);
            this.lb_errors.Name = "lb_errors";
            this.lb_errors.Size = new System.Drawing.Size(0, 15);
            this.lb_errors.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_errors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ftoc);
            this.Controls.Add(this.tb_fahrenheit);
            this.Controls.Add(this.tb_celsius);
            this.Controls.Add(this.btn_ctof);
            this.Name = "Form1";
            this.Text = "CelciusToFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ctof;
        private TextBox tb_celsius;
        private TextBox tb_fahrenheit;
        private Button btn_ftoc;
        private Label label1;
        private Label label2;
        private Label lb_errors;
    }
}