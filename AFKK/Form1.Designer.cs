namespace AFKK
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtXX = new System.Windows.Forms.TextBox();
            this.txtYY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtXX
            // 
            this.txtXX.Location = new System.Drawing.Point(26, 1);
            this.txtXX.Name = "txtXX";
            this.txtXX.Size = new System.Drawing.Size(100, 20);
            this.txtXX.TabIndex = 0;
            // 
            // txtYY
            // 
            this.txtYY.Location = new System.Drawing.Point(182, 1);
            this.txtYY.Name = "txtYY";
            this.txtYY.Size = new System.Drawing.Size(100, 20);
            this.txtYY.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 33);
            this.Controls.Add(this.txtYY);
            this.Controls.Add(this.txtXX);
            this.Name = "Form1";
            this.Text = "Я спросил у Ясеня...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtXX;
        private System.Windows.Forms.TextBox txtYY;
    }
}

