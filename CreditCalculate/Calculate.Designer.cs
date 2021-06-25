namespace CreditCalculate
{
    partial class Calculate
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
            this.tb_ZimInDay = new System.Windows.Forms.TextBox();
            this.lbl_SumInRub = new System.Windows.Forms.Label();
            this.zaim_day = new System.Windows.Forms.Label();
            this.Procent_day = new System.Windows.Forms.Label();
            this.tb_PrProcent = new System.Windows.Forms.TextBox();
            this.btn_rassch = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tb_SumInRub
            // 
            this.tb_SumInRub.Location = new System.Drawing.Point(221, 76);
            this.tb_SumInRub.Multiline = true;
            this.tb_SumInRub.Name = "tb_SumInRub";
            this.tb_SumInRub.Size = new System.Drawing.Size(100, 35);
            this.tb_SumInRub.TabIndex = 0;
            this.tb_SumInRub.TextChanged += new System.EventHandler(this.tb_SumInRub_TextChanged);
            // 
            // tb_ZimInDay
            // 
            this.tb_ZimInDay.Location = new System.Drawing.Point(221, 137);
            this.tb_ZimInDay.Multiline = true;
            this.tb_ZimInDay.Name = "tb_ZimInDay";
            this.tb_ZimInDay.Size = new System.Drawing.Size(100, 35);
            this.tb_ZimInDay.TabIndex = 2;
            this.tb_ZimInDay.TextChanged += new System.EventHandler(this.tb_ZimInDay_TextChanged);
            // 
            // lbl_SumInRub
            // 
            this.lbl_SumInRub.AutoSize = true;
            this.lbl_SumInRub.Location = new System.Drawing.Point(44, 98);
            this.lbl_SumInRub.Name = "lbl_SumInRub";
            this.lbl_SumInRub.Size = new System.Drawing.Size(122, 13);
            this.lbl_SumInRub.TabIndex = 3;
            this.lbl_SumInRub.Text = "Сумма займа в рублях";
            // 
            // zaim_day
            // 
            this.zaim_day.AutoSize = true;
            this.zaim_day.Location = new System.Drawing.Point(55, 140);
            this.zaim_day.Name = "zaim_day";
            this.zaim_day.Size = new System.Drawing.Size(102, 13);
            this.zaim_day.TabIndex = 4;
            this.zaim_day.Text = "Срок займа в днях";
            this.zaim_day.Click += new System.EventHandler(this.label2_Click);
            // 
            // Procent_day
            // 
            this.Procent_day.AutoSize = true;
            this.Procent_day.Location = new System.Drawing.Point(12, 212);
            this.Procent_day.Name = "Procent_day";
            this.Procent_day.Size = new System.Drawing.Size(102, 13);
            this.Procent_day.TabIndex = 5;
            this.Procent_day.Text = "Проценты по дням";
            // 
            // tb_PrProcent
            // 
            this.tb_PrProcent.Location = new System.Drawing.Point(131, 199);
            this.tb_PrProcent.Multiline = true;
            this.tb_PrProcent.Name = "tb_PrProcent";
            this.tb_PrProcent.Size = new System.Drawing.Size(210, 35);
            this.tb_PrProcent.TabIndex = 6;
            this.tb_PrProcent.TextChanged += new System.EventHandler(this.tb_PrProcent_TextChanged);
            // 
            // btn_rassch
            // 
            this.btn_rassch.Location = new System.Drawing.Point(149, 260);
            this.btn_rassch.Name = "btn_rassch";
            this.btn_rassch.Size = new System.Drawing.Size(75, 23);
            this.btn_rassch.TabIndex = 9;
            this.btn_rassch.Text = "Рассчитать";
            this.btn_rassch.UseVisualStyleBackColor = true;
            this.btn_rassch.Click += new System.EventHandler(this.btn_rassch_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(286, 260);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 306);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_rassch);
            this.Controls.Add(this.tb_PrProcent);
            this.Controls.Add(this.Procent_day);
            this.Controls.Add(this.zaim_day);
            this.Controls.Add(this.lbl_SumInRub);
            this.Controls.Add(this.tb_ZimInDay);
            this.Controls.Add(this.tb_SumInRub);
            this.Name = "Calculate";
            this.Text = "CreditCalculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SumInRub;
        private System.Windows.Forms.TextBox tb_ZimInDay;
        private System.Windows.Forms.Label lbl_SumInRub;
        private System.Windows.Forms.Label zaim_day;
        private System.Windows.Forms.Label Procent_day;
        private System.Windows.Forms.TextBox tb_PrProcent;
        private System.Windows.Forms.Button btn_rassch;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

