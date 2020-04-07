namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.calc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calc.Location = new System.Drawing.Point(74, 66);
            this.calc.Name = "calc";
            this.calc.ReadOnly = true;
            this.calc.Size = new System.Drawing.Size(379, 38);
            this.calc.TabIndex = 0;
            this.calc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calc.TextChanged += new System.EventHandler(this.calc_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(228, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(74, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(151, 244);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(228, 244);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 50);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // sign
            // 
            this.sign.Location = new System.Drawing.Point(74, 300);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(71, 50);
            this.sign.TabIndex = 10;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(151, 300);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 50);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(228, 300);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(71, 50);
            this.point.TabIndex = 12;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(305, 132);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(71, 50);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(305, 188);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(71, 50);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(305, 244);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(71, 50);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(305, 300);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(71, 50);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(382, 132);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(71, 50);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Form1_Load);
            // 
            // equally
            // 
            this.equally.Location = new System.Drawing.Point(382, 188);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(71, 50);
            this.equally.TabIndex = 18;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = true;
            this.equally.Click += new System.EventHandler(this.equally_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(88, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equally);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.point);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button equally;
        private System.Windows.Forms.Label label1;
    }
}

