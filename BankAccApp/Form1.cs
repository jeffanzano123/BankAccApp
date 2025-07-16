namespace BankAccApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                MessageBox.Show("Please enter an owner name.");
                return;
            }

            if (InterestNum.Value > 0)
                BankAccounts.Add(new SavingsAccount(OwnerTxt.Text, InterestNum.Value));
            else
                BankAccounts.Add(new BankAccount(OwnerTxt.Text));

            RefreshGrid();
            InterestNum.Value = 0; // Reset interest rate after adding
            MessageBox.Show($"Account has been added!");
            OwnerTxt.Clear();
        }
        private void DeletAccBtn_Click(object sender, EventArgs e)
        {
            BankAccount selectedAccount = (BankAccount)BankAccGrid.SelectedRows[0].DataBoundItem as BankAccount;

            BankAccounts.Remove(selectedAccount);

            MessageBox.Show($"{selectedAccount.Owner} account has been deleted!");
            RefreshGrid();
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedAccount = (BankAccount)BankAccGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Please select only one account to deposit.");
            }

        }
        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedAccount = (BankAccount)BankAccGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Please select only one account to withdraw.");
            }
        }
        private void RefreshGrid()
        {
            BankAccGrid.DataSource = null;
            BankAccGrid.DataSource = BankAccounts;
        }

    }
}
