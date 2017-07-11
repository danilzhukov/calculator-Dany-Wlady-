namespace CalculatorVladDanil
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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.textBoxEntering1 = new System.Windows.Forms.TextBox();
            this.textBoxEntering2 = new System.Windows.Forms.TextBox();
            this.labelOut = new System.Windows.Forms.Label();
            this.buttonSinus = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonExponentiation = new System.Windows.Forms.Button();
            this.buttonExp = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.button2x = new System.Windows.Forms.Button();
            this.buttonXY = new System.Windows.Forms.Button();
            this.buttonArcsin = new System.Windows.Forms.Button();
            this.buttonArctan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(12, 90);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(58, 23);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(76, 90);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(58, 23);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(140, 90);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(66, 23);
            this.buttonMulti.TabIndex = 2;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(212, 90);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(60, 23);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Clicking);
            // 
            // textBoxEntering1
            // 
            this.textBoxEntering1.Location = new System.Drawing.Point(21, 29);
            this.textBoxEntering1.Name = "textBoxEntering1";
            this.textBoxEntering1.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntering1.TabIndex = 4;
            // 
            // textBoxEntering2
            // 
            this.textBoxEntering2.Location = new System.Drawing.Point(154, 29);
            this.textBoxEntering2.Name = "textBoxEntering2";
            this.textBoxEntering2.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntering2.TabIndex = 5;
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(140, 62);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(0, 13);
            this.labelOut.TabIndex = 6;
            // 
            // buttonSinus
            // 
            this.buttonSinus.Location = new System.Drawing.Point(12, 117);
            this.buttonSinus.Name = "buttonSinus";
            this.buttonSinus.Size = new System.Drawing.Size(58, 23);
            this.buttonSinus.TabIndex = 7;
            this.buttonSinus.Text = "Sin";
            this.buttonSinus.UseVisualStyleBackColor = true;
            this.buttonSinus.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(12, 146);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(58, 23);
            this.buttonSquare.TabIndex = 8;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // buttonLn
            // 
            this.buttonLn.Location = new System.Drawing.Point(12, 175);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(58, 23);
            this.buttonLn.TabIndex = 9;
            this.buttonLn.Text = "Log";
            this.buttonLn.UseVisualStyleBackColor = true;
            this.buttonLn.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // buttonExponentiation
            // 
            this.buttonExponentiation.Location = new System.Drawing.Point(12, 204);
            this.buttonExponentiation.Name = "buttonExponentiation";
            this.buttonExponentiation.Size = new System.Drawing.Size(58, 23);
            this.buttonExponentiation.TabIndex = 11;
            this.buttonExponentiation.Text = "x^y";
            this.buttonExponentiation.UseVisualStyleBackColor = true;
            this.buttonExponentiation.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonExp
            // 
            this.buttonExp.Location = new System.Drawing.Point(12, 233);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(58, 23);
            this.buttonExp.TabIndex = 12;
            this.buttonExp.Text = "Exp";
            this.buttonExp.UseVisualStyleBackColor = true;
            this.buttonExp.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(76, 117);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(58, 23);
            this.buttonX.TabIndex = 13;
            this.buttonX.Text = "1/x";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // button2x
            // 
            this.button2x.Location = new System.Drawing.Point(76, 146);
            this.button2x.Name = "button2x";
            this.button2x.Size = new System.Drawing.Size(58, 23);
            this.button2x.TabIndex = 14;
            this.button2x.Text = "2^x";
            this.button2x.UseVisualStyleBackColor = true;
            this.button2x.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // buttonXY
            // 
            this.buttonXY.Location = new System.Drawing.Point(76, 175);
            this.buttonXY.Name = "buttonXY";
            this.buttonXY.Size = new System.Drawing.Size(58, 23);
            this.buttonXY.TabIndex = 15;
            this.buttonXY.Text = "x^(1/y)";
            this.buttonXY.UseVisualStyleBackColor = true;
            this.buttonXY.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonArcsin
            // 
            this.buttonArcsin.Location = new System.Drawing.Point(76, 204);
            this.buttonArcsin.Name = "buttonArcsin";
            this.buttonArcsin.Size = new System.Drawing.Size(58, 23);
            this.buttonArcsin.TabIndex = 16;
            this.buttonArcsin.Text = "arcsin";
            this.buttonArcsin.UseVisualStyleBackColor = true;
            this.buttonArcsin.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // buttonArctan
            // 
            this.buttonArctan.Location = new System.Drawing.Point(76, 233);
            this.buttonArctan.Name = "buttonArctan";
            this.buttonArctan.Size = new System.Drawing.Size(58, 23);
            this.buttonArctan.TabIndex = 17;
            this.buttonArctan.Text = "arctan";
            this.buttonArctan.UseVisualStyleBackColor = true;
            this.buttonArctan.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 259);
            this.Controls.Add(this.buttonArctan);
            this.Controls.Add(this.buttonArcsin);
            this.Controls.Add(this.buttonXY);
            this.Controls.Add(this.button2x);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.buttonExponentiation);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonSinus);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.textBoxEntering2);
            this.Controls.Add(this.textBoxEntering1);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.TextBox textBoxEntering1;
        private System.Windows.Forms.TextBox textBoxEntering2;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button buttonSinus;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonLn;
        private System.Windows.Forms.Button buttonExponentiation;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button button2x;
        private System.Windows.Forms.Button buttonXY;
        private System.Windows.Forms.Button buttonArcsin;
        private System.Windows.Forms.Button buttonArctan;
    }
}

