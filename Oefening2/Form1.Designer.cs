namespace Oefening2
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
            this.lb_inv_1 = new System.Windows.Forms.Label();
            this.lb_inv_2 = new System.Windows.Forms.Label();
            this.lb_res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_inv_1
            // 
            this.lb_inv_1.AutoSize = true;
            this.lb_inv_1.Location = new System.Drawing.Point(72, 94);
            this.lb_inv_1.Name = "lb_inv_1";
            this.lb_inv_1.Size = new System.Drawing.Size(38, 15);
            this.lb_inv_1.TabIndex = 0;
            this.lb_inv_1.Text = "label1";
            this.lb_inv_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_inv_2
            // 
            this.lb_inv_2.AutoSize = true;
            this.lb_inv_2.Location = new System.Drawing.Point(72, 133);
            this.lb_inv_2.Name = "lb_inv_2";
            this.lb_inv_2.Size = new System.Drawing.Size(38, 15);
            this.lb_inv_2.TabIndex = 1;
            this.lb_inv_2.Text = "label2";
            // 
            // lb_res
            // 
            this.lb_res.AutoSize = true;
            this.lb_res.Location = new System.Drawing.Point(72, 170);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(38, 15);
            this.lb_res.TabIndex = 2;
            this.lb_res.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.lb_inv_2);
            this.Controls.Add(this.lb_inv_1);
            this.Name = "Form1";
            this.Text = "IsItBigger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_inv_1;
        private Label lb_inv_2;
        private Label lb_res;
    }
}