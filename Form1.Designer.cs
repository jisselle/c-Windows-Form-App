namespace Exercise6JG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lstAccountBalances = new System.Windows.Forms.ListBox();
            this.rdoDeposit = new System.Windows.Forms.RadioButton();
            this.rdoWithdrawal = new System.Windows.Forms.RadioButton();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account History:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transaction Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Transaction Status:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(149, 45);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.ReadOnly = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(163, 22);
            this.txtAccountNumber.TabIndex = 5;
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(435, 45);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.ReadOnly = true;
            this.txtAccountBalance.Size = new System.Drawing.Size(171, 22);
            this.txtAccountBalance.TabIndex = 6;
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(172, 238);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(435, 22);
            this.txtTransactionAmount.TabIndex = 0;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(139, 348);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(468, 22);
            this.txtStatus.TabIndex = 8;
            // 
            // lstAccountBalances
            // 
            this.lstAccountBalances.FormattingEnabled = true;
            this.lstAccountBalances.ItemHeight = 16;
            this.lstAccountBalances.Location = new System.Drawing.Point(613, 89);
            this.lstAccountBalances.Name = "lstAccountBalances";
            this.lstAccountBalances.Size = new System.Drawing.Size(175, 324);
            this.lstAccountBalances.TabIndex = 9;
            // 
            // rdoDeposit
            // 
            this.rdoDeposit.AutoSize = true;
            this.rdoDeposit.Location = new System.Drawing.Point(40, 113);
            this.rdoDeposit.Name = "rdoDeposit";
            this.rdoDeposit.Size = new System.Drawing.Size(75, 20);
            this.rdoDeposit.TabIndex = 1;
            this.rdoDeposit.TabStop = true;
            this.rdoDeposit.Text = "Deposit";
            this.rdoDeposit.UseVisualStyleBackColor = true;
            // 
            // rdoWithdrawal
            // 
            this.rdoWithdrawal.AutoSize = true;
            this.rdoWithdrawal.Location = new System.Drawing.Point(40, 164);
            this.rdoWithdrawal.Name = "rdoWithdrawal";
            this.rdoWithdrawal.Size = new System.Drawing.Size(94, 20);
            this.rdoWithdrawal.TabIndex = 2;
            this.rdoWithdrawal.TabStop = true;
            this.rdoWithdrawal.Text = "Withdrawal";
            this.rdoWithdrawal.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(40, 292);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(75, 46);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "Submit";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(40, 415);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(121, 58);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "Get History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(240, 415);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(113, 58);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "Get Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(449, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 58);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.rdoWithdrawal);
            this.Controls.Add(this.rdoDeposit);
            this.Controls.Add(this.lstAccountBalances);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtTransactionAmount);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bank Account Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ListBox lstAccountBalances;
        private System.Windows.Forms.RadioButton rdoDeposit;
        private System.Windows.Forms.RadioButton rdoWithdrawal;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnClose;
    }
}

