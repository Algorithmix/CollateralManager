namespace CollateralManager
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
            this.ProcessedListBox = new System.Windows.Forms.ListBox();
            this.AnalyzedListBox = new System.Windows.Forms.ListBox();
            this.MergedListBox = new System.Windows.Forms.ListBox();
            this.PreprocessButton = new System.Windows.Forms.Button();
            this.ComparatorButton = new System.Windows.Forms.Button();
            this.MergeButton = new System.Windows.Forms.Button();
            this.InputListBox = new System.Windows.Forms.ListBox();
            this.ViewOutputButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getCollateral = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.viewInputFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcessedListBox
            // 
            this.ProcessedListBox.FormattingEnabled = true;
            this.ProcessedListBox.Location = new System.Drawing.Point(251, 80);
            this.ProcessedListBox.Name = "ProcessedListBox";
            this.ProcessedListBox.Size = new System.Drawing.Size(161, 160);
            this.ProcessedListBox.TabIndex = 0;
            // 
            // AnalyzedListBox
            // 
            this.AnalyzedListBox.FormattingEnabled = true;
            this.AnalyzedListBox.Location = new System.Drawing.Point(471, 80);
            this.AnalyzedListBox.Name = "AnalyzedListBox";
            this.AnalyzedListBox.Size = new System.Drawing.Size(161, 160);
            this.AnalyzedListBox.TabIndex = 1;
            // 
            // MergedListBox
            // 
            this.MergedListBox.FormattingEnabled = true;
            this.MergedListBox.Location = new System.Drawing.Point(686, 80);
            this.MergedListBox.Name = "MergedListBox";
            this.MergedListBox.Size = new System.Drawing.Size(161, 160);
            this.MergedListBox.TabIndex = 2;
            // 
            // PreprocessButton
            // 
            this.PreprocessButton.Location = new System.Drawing.Point(97, 246);
            this.PreprocessButton.Name = "PreprocessButton";
            this.PreprocessButton.Size = new System.Drawing.Size(98, 34);
            this.PreprocessButton.TabIndex = 3;
            this.PreprocessButton.Text = "Preprocess";
            this.PreprocessButton.UseVisualStyleBackColor = true;
            // 
            // ComparatorButton
            // 
            this.ComparatorButton.Location = new System.Drawing.Point(280, 270);
            this.ComparatorButton.Name = "ComparatorButton";
            this.ComparatorButton.Size = new System.Drawing.Size(98, 34);
            this.ComparatorButton.TabIndex = 4;
            this.ComparatorButton.Text = "Analyze";
            this.ComparatorButton.UseVisualStyleBackColor = true;
            // 
            // MergeButton
            // 
            this.MergeButton.Location = new System.Drawing.Point(503, 270);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(98, 34);
            this.MergeButton.TabIndex = 5;
            this.MergeButton.Text = "Merge";
            this.MergeButton.UseVisualStyleBackColor = true;
            // 
            // InputListBox
            // 
            this.InputListBox.FormattingEnabled = true;
            this.InputListBox.Location = new System.Drawing.Point(34, 80);
            this.InputListBox.Name = "InputListBox";
            this.InputListBox.Size = new System.Drawing.Size(161, 160);
            this.InputListBox.TabIndex = 6;
            this.InputListBox.SelectedIndexChanged += new System.EventHandler(this.InputListBox_SelectedIndexChanged);
            // 
            // ViewOutputButton
            // 
            this.ViewOutputButton.Location = new System.Drawing.Point(717, 270);
            this.ViewOutputButton.Name = "ViewOutputButton";
            this.ViewOutputButton.Size = new System.Drawing.Size(98, 34);
            this.ViewOutputButton.TabIndex = 7;
            this.ViewOutputButton.Text = "View Output";
            this.ViewOutputButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input Test Collateral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Processed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Analyzed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reconstructed";
            // 
            // getCollateral
            // 
            this.getCollateral.Location = new System.Drawing.Point(64, 12);
            this.getCollateral.Name = "getCollateral";
            this.getCollateral.Size = new System.Drawing.Size(98, 34);
            this.getCollateral.TabIndex = 12;
            this.getCollateral.Text = "Get Collateral";
            this.getCollateral.UseVisualStyleBackColor = true;
            this.getCollateral.Click += new System.EventHandler(this.getCollateral_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // viewInputFolderButton
            // 
            this.viewInputFolderButton.Location = new System.Drawing.Point(34, 246);
            this.viewInputFolderButton.Name = "viewInputFolderButton";
            this.viewInputFolderButton.Size = new System.Drawing.Size(57, 34);
            this.viewInputFolderButton.TabIndex = 13;
            this.viewInputFolderButton.Text = "View Folder";
            this.viewInputFolderButton.UseVisualStyleBackColor = true;
            this.viewInputFolderButton.Click += new System.EventHandler(this.viewInputFolderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 325);
            this.Controls.Add(this.viewInputFolderButton);
            this.Controls.Add(this.getCollateral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewOutputButton);
            this.Controls.Add(this.InputListBox);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.ComparatorButton);
            this.Controls.Add(this.PreprocessButton);
            this.Controls.Add(this.MergedListBox);
            this.Controls.Add(this.AnalyzedListBox);
            this.Controls.Add(this.ProcessedListBox);
            this.Name = "Form1";
            this.Text = "Algorithmix Collateral Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProcessedListBox;
        private System.Windows.Forms.ListBox AnalyzedListBox;
        private System.Windows.Forms.ListBox MergedListBox;
        private System.Windows.Forms.Button PreprocessButton;
        private System.Windows.Forms.Button ComparatorButton;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.ListBox InputListBox;
        private System.Windows.Forms.Button ViewOutputButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getCollateral;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button viewInputFolderButton;
    }
}

