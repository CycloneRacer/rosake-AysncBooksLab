namespace AysncBooksLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFile = new Label();
            btnBrowse = new Button();
            lstReport = new ListBox();
            btnExit = new Button();
            btnSubmit = new Button();
            txtFile = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            txtFile2 = new TextBox();
            lstReport2 = new ListBox();
            btnBrowse2 = new Button();
            lblFile3 = new Label();
            SuspendLayout();
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(22, 53);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(32, 20);
            lblFile.TabIndex = 0;
            lblFile.Text = "File";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(302, 50);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.Location = new Point(22, 90);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(365, 284);
            lstReport.TabIndex = 2;
            lstReport.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(220, 409);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(461, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(60, 50);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(236, 27);
            txtFile.TabIndex = 5;
            txtFile.TextChanged += textBox1_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // txtFile2
            // 
            txtFile2.Location = new Point(451, 50);
            txtFile2.Name = "txtFile2";
            txtFile2.Size = new Size(236, 27);
            txtFile2.TabIndex = 9;
            // 
            // lstReport2
            // 
            lstReport2.FormattingEnabled = true;
            lstReport2.Location = new Point(413, 90);
            lstReport2.Name = "lstReport2";
            lstReport2.Size = new Size(365, 284);
            lstReport2.TabIndex = 8;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(693, 50);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(94, 29);
            btnBrowse2.TabIndex = 7;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // lblFile3
            // 
            lblFile3.AutoSize = true;
            lblFile3.Location = new Point(413, 53);
            lblFile3.Name = "lblFile3";
            lblFile3.Size = new Size(32, 20);
            lblFile3.TabIndex = 6;
            lblFile3.Text = "File";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 459);
            Controls.Add(txtFile2);
            Controls.Add(lstReport2);
            Controls.Add(btnBrowse2);
            Controls.Add(lblFile3);
            Controls.Add(txtFile);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(lstReport);
            Controls.Add(btnBrowse);
            Controls.Add(lblFile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFile;
        private Button btnBrowse;
        private ListBox lstReport;
        private Button btnExit;
        private Button btnSubmit;
        private TextBox txtFile;
        private OpenFileDialog openFileDialog1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button1;
        private Label lblFile2;
        private OpenFileDialog openFileDialog2;
        private TextBox txtFile2;
        private ListBox lstReport2;
        private Button btnBrowse2;
        private Label lblFile3;
    }
}
