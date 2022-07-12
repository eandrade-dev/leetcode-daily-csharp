
namespace LeetcodeDaily
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
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.btnTwoSum = new System.Windows.Forms.Button();
            this.btnValidParenthesis = new System.Windows.Forms.Button();
            this.btnMergeSortedLists = new System.Windows.Forms.Button();
            this.btnBestTimeBuyStock = new System.Windows.Forms.Button();
            this.btnValidPalindrome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxResults
            // 
            this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 15;
            this.listBoxResults.Location = new System.Drawing.Point(0, 0);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(232, 450);
            this.listBoxResults.TabIndex = 0;
            // 
            // btnTwoSum
            // 
            this.btnTwoSum.Location = new System.Drawing.Point(238, 12);
            this.btnTwoSum.Name = "btnTwoSum";
            this.btnTwoSum.Size = new System.Drawing.Size(160, 23);
            this.btnTwoSum.TabIndex = 1;
            this.btnTwoSum.Text = "TwoSum";
            this.btnTwoSum.UseVisualStyleBackColor = true;
            this.btnTwoSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValidParenthesis
            // 
            this.btnValidParenthesis.Location = new System.Drawing.Point(238, 41);
            this.btnValidParenthesis.Name = "btnValidParenthesis";
            this.btnValidParenthesis.Size = new System.Drawing.Size(160, 23);
            this.btnValidParenthesis.TabIndex = 2;
            this.btnValidParenthesis.Text = "Valid Parenthesis";
            this.btnValidParenthesis.UseVisualStyleBackColor = true;
            this.btnValidParenthesis.Click += new System.EventHandler(this.btnValidParenthesis_Click);
            // 
            // btnMergeSortedLists
            // 
            this.btnMergeSortedLists.Location = new System.Drawing.Point(238, 70);
            this.btnMergeSortedLists.Name = "btnMergeSortedLists";
            this.btnMergeSortedLists.Size = new System.Drawing.Size(160, 23);
            this.btnMergeSortedLists.TabIndex = 3;
            this.btnMergeSortedLists.Text = "Merge Sorted Lists";
            this.btnMergeSortedLists.UseVisualStyleBackColor = true;
            this.btnMergeSortedLists.Click += new System.EventHandler(this.btnMergeSortedLists_Click);
            // 
            // btnBestTimeBuyStock
            // 
            this.btnBestTimeBuyStock.Location = new System.Drawing.Point(238, 99);
            this.btnBestTimeBuyStock.Name = "btnBestTimeBuyStock";
            this.btnBestTimeBuyStock.Size = new System.Drawing.Size(160, 23);
            this.btnBestTimeBuyStock.TabIndex = 4;
            this.btnBestTimeBuyStock.Text = "Best Time to Buy Stock";
            this.btnBestTimeBuyStock.UseVisualStyleBackColor = true;
            this.btnBestTimeBuyStock.Click += new System.EventHandler(this.btnBestTimeBuyStock_Click);
            // 
            // btnValidPalindrome
            // 
            this.btnValidPalindrome.Location = new System.Drawing.Point(238, 128);
            this.btnValidPalindrome.Name = "btnValidPalindrome";
            this.btnValidPalindrome.Size = new System.Drawing.Size(160, 23);
            this.btnValidPalindrome.TabIndex = 5;
            this.btnValidPalindrome.Text = "Valid Palindrome";
            this.btnValidPalindrome.UseVisualStyleBackColor = true;
            this.btnValidPalindrome.Click += new System.EventHandler(this.btnValidPalindrome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidPalindrome);
            this.Controls.Add(this.btnBestTimeBuyStock);
            this.Controls.Add(this.btnMergeSortedLists);
            this.Controls.Add(this.btnValidParenthesis);
            this.Controls.Add(this.btnTwoSum);
            this.Controls.Add(this.listBoxResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Button btnTwoSum;
        private System.Windows.Forms.Button btnValidParenthesis;
        private System.Windows.Forms.Button btnMergeSortedLists;
        private System.Windows.Forms.Button btnBestTimeBuyStock;
        private System.Windows.Forms.Button btnValidPalindrome;
    }
}

