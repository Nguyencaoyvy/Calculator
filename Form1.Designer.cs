namespace Calculator
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
            this.soA = new System.Windows.Forms.Label();
            this.soB = new System.Windows.Forms.Label();
            this.kq = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soA
            // 
            this.soA.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soA.Location = new System.Drawing.Point(125, 106);
            this.soA.Name = "soA";
            this.soA.Size = new System.Drawing.Size(82, 37);
            this.soA.TabIndex = 0;
            this.soA.Text = "Số a";
            // 
            // soB
            // 
            this.soB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soB.Location = new System.Drawing.Point(125, 163);
            this.soB.Name = "soB";
            this.soB.Size = new System.Drawing.Size(82, 37);
            this.soB.TabIndex = 0;
            this.soB.Text = "Số b";
            // 
            // kq
            // 
            this.kq.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kq.Location = new System.Drawing.Point(125, 213);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(115, 37);
            this.kq.TabIndex = 0;
            this.kq.Text = "Kết quả";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(267, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(246, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 27);
            this.textBox3.TabIndex = 1;
            // 
            // btCong
            // 
            this.btCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btCong.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCong.Location = new System.Drawing.Point(314, 292);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(111, 46);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.soB);
            this.Controls.Add(this.soA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label soA;
        private Label soB;
        private Label kq;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btCong;
    }
}