namespace OP_LAB11
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
            this.txb_StartDirectory = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_FileToFInd = new System.Windows.Forms.TextBox();
            this.cb_Register = new System.Windows.Forms.CheckBox();
            this.dgv_output = new System.Windows.Forms.DataGridView();
            this.Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // cb_Register
            // 
            this.cb_Register.AutoSize = true;
            this.cb_Register.Location = new System.Drawing.Point(16, 87);
            this.cb_Register.Name = "cb_Register";
            this.cb_Register.Size = new System.Drawing.Size(65, 17);
            this.cb_Register.TabIndex = 8;
            this.cb_Register.Text = "Register";
            this.cb_Register.UseVisualStyleBackColor = true;
            // 
            // dgv_output
            // 
            this.dgv_output.AllowUserToAddRows = false;
            this.dgv_output.AllowUserToDeleteRows = false;
            this.dgv_output.AllowUserToResizeColumns = false;
            this.dgv_output.AllowUserToResizeRows = false;
            this.dgv_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Files});
            this.dgv_output.Location = new System.Drawing.Point(16, 148);
            this.dgv_output.Name = "dgv_output";
            this.dgv_output.RowHeadersVisible = false;
            this.dgv_output.Size = new System.Drawing.Size(350, 150);
            this.dgv_output.TabIndex = 11;
            this.dgv_output.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_output_CellContentDoubleClick);
            // 
            // Files
            // 
            this.Files.HeaderText = "Files";
            this.Files.Name = "Files";
            this.Files.Width = 1000;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 304);
            this.Controls.Add(this.dgv_output);
            this.Controls.Add(this.cb_Register);
            this.Controls.Add(this.txb_FileToFInd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txb_StartDirectory);
            this.Name = "Form1";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_FileToFInd;
        public System.Windows.Forms.TextBox txb_StartDirectory;
        private System.Windows.Forms.CheckBox cb_Register;
        private System.Windows.Forms.DataGridView dgv_output;
        private System.Windows.Forms.DataGridViewTextBoxColumn Files;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

