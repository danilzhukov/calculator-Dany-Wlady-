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
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(12, 112);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(58, 23);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(76, 112);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(58, 23);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(140, 112);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(66, 23);
            this.buttonMulti.TabIndex = 2;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.Clicking);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(212, 112);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(60, 23);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Clicking);
            // 
            // textBoxEntering1
            // 
            this.textBoxEntering1.Location = new System.Drawing.Point(21, 41);
            this.textBoxEntering1.Name = "textBoxEntering1";
            this.textBoxEntering1.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntering1.TabIndex = 4;
            // 
            // textBoxEntering2
            // 
            this.textBoxEntering2.Location = new System.Drawing.Point(154, 41);
            this.textBoxEntering2.Name = "textBoxEntering2";
            this.textBoxEntering2.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntering2.TabIndex = 5;
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(121, 98);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(0, 13);
            this.labelOut.TabIndex = 6;
            // 
            // buttonSinus
            // 
            this.buttonSinus.Location = new System.Drawing.Point(12, 224);
            this.buttonSinus.Name = "buttonSinus";
            this.buttonSinus.Size = new System.Drawing.Size(58, 23);
            this.buttonSinus.TabIndex = 7;
            this.buttonSinus.Text = "Sin";
            this.buttonSinus.UseVisualStyleBackColor = true;
            this.buttonSinus.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(76, 224);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(58, 23);
            this.buttonSquare.TabIndex = 8;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.ClicklingOne);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 259);
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
    }
}

