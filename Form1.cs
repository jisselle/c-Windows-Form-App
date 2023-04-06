//Jisselle Garcia
//Exercise 6 
//This program works as a bank account manager with deposit, withdrawl and status. 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Exercise6JG
{
    public partial class Form1 : Form
    {
     
        //Defining fields for bank account balance, and account number
        /// /for the purpose without a database

        BankAccount account = new BankAccount(1362.59m, "000302019");
        public Form1()
        {
            InitializeComponent();
            txtAccountNumber.Text = account.AccountNumber;
            txtAccountBalance.Text = account.GetAccountBalance().ToString("c");
        }

        //Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Method for submit button resulting in transaction of deposit or withdrawl

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            //text clear procedure 
            txtStatus.Text = "";

            //Checking if entry is valid, if not an error message will appear
            bool isValid = decimal.TryParse(txtTransactionAmount.Text, out decimal amount);
            if (!isValid)
            {
                txtStatus.Text = "Invalid amount entered. Please enter a dollar amount.";
                return;
            }
            //radio deposit button
            if (rdoDeposit.Checked)
            {
                accountStatus status = account.Deposit(amount);
                DisplayTransactionStatus(status);
            }
            //radio button for withdrawal
            else if (rdoWithdrawal.Checked)
            {
                accountStatus status = account.Withdrawal(amount);
                DisplayTransactionStatus(status);
            }
            else
            {
                txtStatus.Text = "Please select an option to continue";
                return;
            }

            txtAccountBalance.Text = account.GetAccountBalance().ToString("c");

            //Clearing transaction amount and both radion buttons
            txtTransactionAmount.Text = "";
            rdoDeposit.Checked = false;
            rdoWithdrawal.Checked = false;

        }
        //Method to display the text message result of the option selected above
        private void DisplayTransactionStatus(accountStatus status)
        {
            switch (status)
            {
                case accountStatus.Ok:
                    txtStatus.Text = "Transaction Successful.";
                    break;
                case accountStatus.Overdrawn:
                    txtStatus.Text = "Your account is now overdrawn. Please make a deposit before midnight to avoid a fee.";
                    break;
                case accountStatus.InsufficientFunds:
                    txtStatus.Text = "Your transaction has been canceled due to insufficient funds";
                    break;
                case accountStatus.DepositMax:
                    txtStatus.Text = "The transaction amount is over the maximum allowed";
                    break;
                default:
                    txtStatus.Text = "";
                    break;
            }

        }
        //This method returns the transaction history in reverse order to display in history box
        private void btnHistory_Click(object sender, EventArgs e)
        {
            for (int i = account.AccountBalances.Count - 1; i >= 0; i--)
            {
                lstAccountBalances.Items.Add(account.AccountBalances[i].ToString("c"));
            }

        }
        //Method to display the status of account when button is clicked
        private void btnStatus_Click(object sender, EventArgs e)
        {
            switch (account.GetAccountStatus())
            {
                case accountStatus.Ok:
                    MessageBox.Show("Your account is currently in good standing.", "Account Status");
                    break;
                case accountStatus.Overdrawn:
                    MessageBox.Show("Your account is currently overdrawn. Please make a deposit", "Account Status");
                    break;
            }

        }
    }
}
