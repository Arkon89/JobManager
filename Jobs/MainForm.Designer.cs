namespace Jobs
{
    partial class MainForm
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
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.fldNewJob = new System.Windows.Forms.TextBox();
            this.btAddJob = new System.Windows.Forms.Button();
            this.btDeleteJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMain
            // 
            this.listBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.HorizontalScrollbar = true;
            this.listBoxMain.ItemHeight = 16;
            this.listBoxMain.Location = new System.Drawing.Point(12, 120);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(441, 532);
            this.listBoxMain.TabIndex = 0;
            // 
            // fldNewJob
            // 
            this.fldNewJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldNewJob.Location = new System.Drawing.Point(12, 32);
            this.fldNewJob.Name = "fldNewJob";
            this.fldNewJob.Size = new System.Drawing.Size(441, 22);
            this.fldNewJob.TabIndex = 1;
            // 
            // btAddJob
            // 
            this.btAddJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddJob.Location = new System.Drawing.Point(475, 32);
            this.btAddJob.Name = "btAddJob";
            this.btAddJob.Size = new System.Drawing.Size(94, 23);
            this.btAddJob.TabIndex = 2;
            this.btAddJob.Text = "Добавить ";
            this.btAddJob.UseVisualStyleBackColor = true;
            // 
            // btDeleteJob
            // 
            this.btDeleteJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteJob.Location = new System.Drawing.Point(475, 120);
            this.btDeleteJob.Name = "btDeleteJob";
            this.btDeleteJob.Size = new System.Drawing.Size(94, 23);
            this.btDeleteJob.TabIndex = 3;
            this.btDeleteJob.Text = "Удалить";
            this.btDeleteJob.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 660);
            this.Controls.Add(this.btDeleteJob);
            this.Controls.Add(this.btAddJob);
            this.Controls.Add(this.fldNewJob);
            this.Controls.Add(this.listBoxMain);
            this.Name = "MainForm";
            this.Text = "Список дел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.TextBox fldNewJob;
        private System.Windows.Forms.Button btAddJob;
        private System.Windows.Forms.Button btDeleteJob;
    }
}

