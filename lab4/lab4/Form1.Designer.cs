namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.lblLoadTime = new System.Windows.Forms.Label();
            this.lblSearchTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(30, 24);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(186, 48);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Open file";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(30, 94);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Enter the word";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(30, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(186, 48);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 16;
            this.listBoxResults.Location = new System.Drawing.Point(281, 26);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(330, 164);
            this.listBoxResults.TabIndex = 3;
            // 
            // lblLoadTime
            // 
            this.lblLoadTime.Location = new System.Drawing.Point(30, 229);
            this.lblLoadTime.Name = "lblLoadTime";
            this.lblLoadTime.Size = new System.Drawing.Size(126, 19);
            this.lblLoadTime.TabIndex = 4;
            this.lblLoadTime.Text = "Load Time";
            // 
            // lblSearchTime
            // 
            this.lblSearchTime.Location = new System.Drawing.Point(162, 229);
            this.lblSearchTime.Name = "lblSearchTime";
            this.lblSearchTime.Size = new System.Drawing.Size(178, 19);
            this.lblSearchTime.TabIndex = 5;
            this.lblSearchTime.Text = "Search Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 295);
            this.Controls.Add(this.lblSearchTime);
            this.Controls.Add(this.lblLoadTime);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblLoadTime;
        private System.Windows.Forms.Label lblSearchTime;

        private System.Windows.Forms.ListBox listBoxResults;

        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnReadFile;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        #endregion
    }
}