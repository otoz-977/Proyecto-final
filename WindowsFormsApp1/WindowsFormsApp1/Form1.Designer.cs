namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Diag = new System.Windows.Forms.TextBox();
            this.Cont = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Questions = new System.Windows.Forms.Panel();
            this.Ans = new System.Windows.Forms.TextBox();
            this.Q2 = new System.Windows.Forms.TextBox();
            this.Q1 = new System.Windows.Forms.TextBox();
            this.Questions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Diag
            // 
            this.Diag.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diag.Location = new System.Drawing.Point(50, 421);
            this.Diag.Multiline = true;
            this.Diag.Name = "Diag";
            this.Diag.Size = new System.Drawing.Size(750, 78);
            this.Diag.TabIndex = 0;
            this.Diag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cont
            // 
            this.Cont.BackColor = System.Drawing.Color.Olive;
            this.Cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cont.Location = new System.Drawing.Point(439, 532);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(75, 23);
            this.Cont.TabIndex = 1;
            this.Cont.Text = "Continuar";
            this.Cont.UseVisualStyleBackColor = false;
            this.Cont.Click += new System.EventHandler(this.Cont_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Questions
            // 
            this.Questions.BackColor = System.Drawing.Color.Silver;
            this.Questions.Controls.Add(this.Ans);
            this.Questions.Controls.Add(this.Q2);
            this.Questions.Controls.Add(this.Q1);
            this.Questions.Location = new System.Drawing.Point(387, 132);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(228, 140);
            this.Questions.TabIndex = 3;
            this.Questions.Visible = false;
            // 
            // Ans
            // 
            this.Ans.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.Location = new System.Drawing.Point(64, 94);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(54, 30);
            this.Ans.TabIndex = 2;
            // 
            // Q2
            // 
            this.Q2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2.Location = new System.Drawing.Point(14, 58);
            this.Q2.Name = "Q2";
            this.Q2.ReadOnly = true;
            this.Q2.Size = new System.Drawing.Size(166, 30);
            this.Q2.TabIndex = 1;
            // 
            // Q1
            // 
            this.Q1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1.Location = new System.Drawing.Point(14, 16);
            this.Q1.Name = "Q1";
            this.Q1.ReadOnly = true;
            this.Q1.Size = new System.Drawing.Size(166, 30);
            this.Q1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.backbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 594);
            this.Controls.Add(this.Questions);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cont);
            this.Controls.Add(this.Diag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Questions.ResumeLayout(false);
            this.Questions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Diag;
        private System.Windows.Forms.Button Cont;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Questions;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.TextBox Q2;
        private System.Windows.Forms.TextBox Q1;
    }
}

