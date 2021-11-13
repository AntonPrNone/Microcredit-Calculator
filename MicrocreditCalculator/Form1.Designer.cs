namespace MicrocreditCalculator
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
            System.Windows.Forms.Label Title;
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveReportButton = new System.Windows.Forms.Button();
            this.PutButton = new System.Windows.Forms.Button();
            this.LoanSum = new System.Windows.Forms.TextBox();
            this.LoanTerm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = System.Windows.Forms.DockStyle.Top;
            Title.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Title.ForeColor = System.Drawing.Color.Green;
            Title.Location = new System.Drawing.Point(0, 0);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(802, 48);
            Title.TabIndex = 3;
            Title.Text = "Microcredit Calculator";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveReportButton
            // 
            this.SaveReportButton.Location = new System.Drawing.Point(713, 12);
            this.SaveReportButton.Name = "SaveReportButton";
            this.SaveReportButton.Size = new System.Drawing.Size(75, 23);
            this.SaveReportButton.TabIndex = 1;
            this.SaveReportButton.Text = "Save Report";
            this.SaveReportButton.UseVisualStyleBackColor = true;
            // 
            // PutButton
            // 
            this.PutButton.Location = new System.Drawing.Point(353, 220);
            this.PutButton.Name = "PutButton";
            this.PutButton.Size = new System.Drawing.Size(75, 23);
            this.PutButton.TabIndex = 2;
            this.PutButton.Text = "Put";
            this.PutButton.UseVisualStyleBackColor = true;
            this.PutButton.Click += new System.EventHandler(this.PutButton_Click);
            // 
            // LoanSum
            // 
            this.LoanSum.Location = new System.Drawing.Point(96, 122);
            this.LoanSum.Name = "LoanSum";
            this.LoanSum.Size = new System.Drawing.Size(100, 20);
            this.LoanSum.TabIndex = 5;
            // 
            // LoanTerm
            // 
            this.LoanTerm.Location = new System.Drawing.Point(607, 122);
            this.LoanTerm.Name = "LoanTerm";
            this.LoanTerm.Size = new System.Drawing.Size(100, 20);
            this.LoanTerm.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(108, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loan Sum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(615, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loan Term";
            // 
            // Bet
            // 
            this.Bet.Location = new System.Drawing.Point(341, 186);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(100, 20);
            this.Bet.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(376, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bet";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.PutButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(802, 291);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoanTerm);
            this.Controls.Add(this.LoanSum);
            this.Controls.Add(this.PutButton);
            this.Controls.Add(this.SaveReportButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(Title);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveReportButton;
        private System.Windows.Forms.Button PutButton;
        private System.Windows.Forms.TextBox LoanSum;
        private System.Windows.Forms.TextBox LoanTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Bet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

