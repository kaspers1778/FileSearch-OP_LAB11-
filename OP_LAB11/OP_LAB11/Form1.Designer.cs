﻿namespace OP_LAB11
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
            this.txb_StartDirectory = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_FileToFInd = new System.Windows.Forms.TextBox();
            this.rb_Register = new System.Windows.Forms.RadioButton();
            this.txb_Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_StartDirectory
            // 
            this.txb_StartDirectory.Location = new System.Drawing.Point(97, 18);
            this.txb_StartDirectory.Name = "txb_StartDirectory";
            this.txb_StartDirectory.Size = new System.Drawing.Size(125, 20);
            this.txb_StartDirectory.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(16, 119);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start directory :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File to find :";
            // 
            // txb_FileToFInd
            // 
            this.txb_FileToFInd.Location = new System.Drawing.Point(106, 52);
            this.txb_FileToFInd.Name = "txb_FileToFInd";
            this.txb_FileToFInd.Size = new System.Drawing.Size(116, 20);
            this.txb_FileToFInd.TabIndex = 4;
            // 
            // rb_Register
            // 
            this.rb_Register.AutoSize = true;
            this.rb_Register.Location = new System.Drawing.Point(16, 85);
            this.rb_Register.Name = "rb_Register";
            this.rb_Register.Size = new System.Drawing.Size(64, 17);
            this.rb_Register.TabIndex = 6;
            this.rb_Register.TabStop = true;
            this.rb_Register.Text = "Register";
            this.rb_Register.UseVisualStyleBackColor = true;
            // 
            // txb_Output
            // 
            this.txb_Output.Location = new System.Drawing.Point(12, 148);
            this.txb_Output.Multiline = true;
            this.txb_Output.Name = "txb_Output";
            this.txb_Output.ReadOnly = true;
            this.txb_Output.Size = new System.Drawing.Size(353, 20);
            this.txb_Output.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Output);
            this.Controls.Add(this.rb_Register);
            this.Controls.Add(this.txb_FileToFInd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txb_StartDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_StartDirectory;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_FileToFInd;
        private System.Windows.Forms.RadioButton rb_Register;
        private System.Windows.Forms.TextBox txb_Output;
    }
}
