namespace CreditCalculate
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
            this.tb_SumInRub = new System.Windows.Forms.TextBox();
            this.tb_ProcentInDay = new System.Windows.Forms.TextBox();
            this.tb_ZimInDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_SumInRub
            // 
            this.tb_SumInRub.Location = new System.Drawing.Point(135, 100);
            this.tb_SumInRub.Name = "tb_SumInRub";
            this.tb_SumInRub.Size = new System.Drawing.Size(100, 20);
            this.tb_SumInRub.TabIndex = 0;
            this.tb_SumInRub.TextChanged += new System.EventHandler(this.tb_SumInRub_TextChanged);
            // 
            // tb_ProcentInDay
            // 
            this.tb_ProcentInDay.Location = new System.Drawing.Point(135, 189);
            this.tb_ProcentInDay.Name = "tb_ProcentInDay";
            this.tb_ProcentInDay.Size = new System.Drawing.Size(100, 20);
            this.tb_ProcentInDay.TabIndex = 1;
            // 
            // tb_ZimInDay
            // 
            this.tb_ZimInDay.Location = new System.Drawing.Point(135, 144);
            this.tb_ZimInDay.Name = "tb_ZimInDay";
            this.tb_ZimInDay.Size = new System.Drawing.Size(100, 20);
            this.tb_ZimInDay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 524);
            this.Controls.Add(this.tb_ZimInDay);
            this.Controls.Add(this.tb_ProcentInDay);
            this.Controls.Add(this.tb_SumInRub);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SumInRub;
        private System.Windows.Forms.TextBox tb_ProcentInDay;
        private System.Windows.Forms.TextBox tb_ZimInDay;
    }
}

