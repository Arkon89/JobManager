﻿namespace Jobs
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
            this.butMovToActual = new System.Windows.Forms.Button();
            this.butMovToAll = new System.Windows.Forms.Button();
            this.listBoxActual = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxWork = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxReady = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butMoveToWork = new System.Windows.Forms.Button();
            this.butReady = new System.Windows.Forms.Button();
            this.butBackToAct = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMain
            // 
            this.listBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.HorizontalScrollbar = true;
            this.listBoxMain.ItemHeight = 16;
            this.listBoxMain.Location = new System.Drawing.Point(32, 120);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(297, 532);
            this.listBoxMain.TabIndex = 0;
            // 
            // fldNewJob
            // 
            this.fldNewJob.Location = new System.Drawing.Point(32, 32);
            this.fldNewJob.Name = "fldNewJob";
            this.fldNewJob.Size = new System.Drawing.Size(297, 22);
            this.fldNewJob.TabIndex = 1;
            // 
            // btAddJob
            // 
            this.btAddJob.Location = new System.Drawing.Point(355, 31);
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
            this.btDeleteJob.Location = new System.Drawing.Point(32, 667);
            this.btDeleteJob.Name = "btDeleteJob";
            this.btDeleteJob.Size = new System.Drawing.Size(94, 23);
            this.btDeleteJob.TabIndex = 3;
            this.btDeleteJob.Text = "Удалить";
            this.btDeleteJob.UseVisualStyleBackColor = true;
            // 
            // butMovToActual
            // 
            this.butMovToActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butMovToActual.Location = new System.Drawing.Point(212, 74);
            this.butMovToActual.Name = "butMovToActual";
            this.butMovToActual.Size = new System.Drawing.Size(117, 40);
            this.butMovToActual.TabIndex = 3;
            this.butMovToActual.Text = "Выбрать =>";
            this.butMovToActual.UseVisualStyleBackColor = true;
            this.butMovToActual.Click += new System.EventHandler(this.butMovToActual_Click);
            // 
            // butMovToAll
            // 
            this.butMovToAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butMovToAll.Location = new System.Drawing.Point(355, 658);
            this.butMovToAll.Name = "butMovToAll";
            this.butMovToAll.Size = new System.Drawing.Size(94, 23);
            this.butMovToAll.TabIndex = 3;
            this.butMovToAll.Text = "<= Убрать ";
            this.butMovToAll.UseVisualStyleBackColor = true;
            this.butMovToAll.Click += new System.EventHandler(this.butMovToAll_Click);
            // 
            // listBoxActual
            // 
            this.listBoxActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxActual.FormattingEnabled = true;
            this.listBoxActual.HorizontalScrollbar = true;
            this.listBoxActual.ItemHeight = 16;
            this.listBoxActual.Location = new System.Drawing.Point(355, 120);
            this.listBoxActual.Name = "listBoxActual";
            this.listBoxActual.Size = new System.Drawing.Size(286, 532);
            this.listBoxActual.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Все дела";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Актуальные";
            // 
            // listBoxWork
            // 
            this.listBoxWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWork.FormattingEnabled = true;
            this.listBoxWork.HorizontalScrollbar = true;
            this.listBoxWork.ItemHeight = 16;
            this.listBoxWork.Location = new System.Drawing.Point(657, 120);
            this.listBoxWork.Name = "listBoxWork";
            this.listBoxWork.Size = new System.Drawing.Size(285, 532);
            this.listBoxWork.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "В работе";
            // 
            // listBoxReady
            // 
            this.listBoxReady.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxReady.FormattingEnabled = true;
            this.listBoxReady.HorizontalScrollbar = true;
            this.listBoxReady.ItemHeight = 16;
            this.listBoxReady.Location = new System.Drawing.Point(962, 120);
            this.listBoxReady.Name = "listBoxReady";
            this.listBoxReady.Size = new System.Drawing.Size(278, 532);
            this.listBoxReady.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(959, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Выполненные";
            // 
            // butMoveToWork
            // 
            this.butMoveToWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butMoveToWork.Location = new System.Drawing.Point(524, 74);
            this.butMoveToWork.Name = "butMoveToWork";
            this.butMoveToWork.Size = new System.Drawing.Size(117, 40);
            this.butMoveToWork.TabIndex = 3;
            this.butMoveToWork.Text = "Выбрать =>";
            this.butMoveToWork.UseVisualStyleBackColor = true;
            this.butMoveToWork.Click += new System.EventHandler(this.butMoveToWork_Click);
            // 
            // butReady
            // 
            this.butReady.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butReady.Location = new System.Drawing.Point(822, 74);
            this.butReady.Name = "butReady";
            this.butReady.Size = new System.Drawing.Size(120, 40);
            this.butReady.TabIndex = 3;
            this.butReady.Text = "ГОТОВО =>";
            this.butReady.UseVisualStyleBackColor = true;
            this.butReady.Click += new System.EventHandler(this.butReady_Click);
            // 
            // butBackToAct
            // 
            this.butBackToAct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butBackToAct.Location = new System.Drawing.Point(657, 667);
            this.butBackToAct.Name = "butBackToAct";
            this.butBackToAct.Size = new System.Drawing.Size(94, 23);
            this.butBackToAct.TabIndex = 3;
            this.butBackToAct.Text = "<= Убрать ";
            this.butBackToAct.UseVisualStyleBackColor = true;
            this.butBackToAct.Click += new System.EventHandler(this.butBackToAct_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(1115, 31);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(104, 23);
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 702);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butBackToAct);
            this.Controls.Add(this.butMovToAll);
            this.Controls.Add(this.butReady);
            this.Controls.Add(this.butMoveToWork);
            this.Controls.Add(this.butMovToActual);
            this.Controls.Add(this.btDeleteJob);
            this.Controls.Add(this.btAddJob);
            this.Controls.Add(this.fldNewJob);
            this.Controls.Add(this.listBoxReady);
            this.Controls.Add(this.listBoxWork);
            this.Controls.Add(this.listBoxActual);
            this.Controls.Add(this.listBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Список дел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.TextBox fldNewJob;
        private System.Windows.Forms.Button btAddJob;
        private System.Windows.Forms.Button btDeleteJob;
        private System.Windows.Forms.Button butMovToActual;
        private System.Windows.Forms.Button butMovToAll;
        private System.Windows.Forms.ListBox listBoxActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxReady;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butMoveToWork;
        private System.Windows.Forms.Button butReady;
        private System.Windows.Forms.Button butBackToAct;
        private System.Windows.Forms.Button butSave;
    }
}

