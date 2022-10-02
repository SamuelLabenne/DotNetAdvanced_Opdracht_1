namespace Oefening7
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_invoer = new System.Windows.Forms.TextBox();
            this.btn_sum = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lb_errors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // tb_invoer
            // 
            this.tb_invoer.Location = new System.Drawing.Point(189, 99);
            this.tb_invoer.Name = "tb_invoer";
            this.tb_invoer.Size = new System.Drawing.Size(100, 23);
            this.tb_invoer.TabIndex = 1;
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(167, 131);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(75, 23);
            this.btn_sum.TabIndex = 2;
            this.btn_sum.Text = "Calculate";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(129, 184);
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(160, 23);
            this.tb_result.TabIndex = 3;
            // 
            // lb_errors
            // 
            this.lb_errors.AutoSize = true;
            this.lb_errors.Location = new System.Drawing.Point(129, 166);
            this.lb_errors.Name = "lb_errors";
            this.lb_errors.Size = new System.Drawing.Size(0, 15);
            this.lb_errors.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_errors);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.tb_invoer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_invoer;
        private Button btn_sum;
        private TextBox tb_result;
        private Label lb_errors;
    }
}