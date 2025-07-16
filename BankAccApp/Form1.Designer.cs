namespace BankAccApp
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccButton = new Button();
            DeletAccBtn = new Button();
            InterestNum = new NumericUpDown();
            Label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 17);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 137);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(128, 12);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(268, 35);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(128, 135);
            AmountNum.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { -1530494977, 232830, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(176, 35);
            AmountNum.TabIndex = 3;
            // 
            // BankAccGrid
            // 
            BankAccGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccGrid.BackgroundColor = SystemColors.InactiveBorder;
            BankAccGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccGrid.Location = new Point(431, 12);
            BankAccGrid.Name = "BankAccGrid";
            BankAccGrid.Size = new Size(466, 211);
            BankAccGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            DepositBtn.BackColor = SystemColors.ControlLightLight;
            DepositBtn.Location = new Point(455, 229);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(183, 43);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = false;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(678, 229);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(183, 43);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // CreateAccButton
            // 
            CreateAccButton.BackColor = SystemColors.ButtonFace;
            CreateAccButton.Location = new Point(14, 235);
            CreateAccButton.Name = "CreateAccButton";
            CreateAccButton.Size = new Size(169, 37);
            CreateAccButton.TabIndex = 7;
            CreateAccButton.Text = "Create Account";
            CreateAccButton.UseVisualStyleBackColor = false;
            CreateAccButton.Click += CreateAccButton_Click;
            // 
            // DeletAccBtn
            // 
            DeletAccBtn.BackColor = SystemColors.ButtonFace;
            DeletAccBtn.Location = new Point(227, 235);
            DeletAccBtn.Name = "DeletAccBtn";
            DeletAccBtn.Size = new Size(169, 37);
            DeletAccBtn.TabIndex = 8;
            DeletAccBtn.Text = "Delete Account";
            DeletAccBtn.UseVisualStyleBackColor = false;
            DeletAccBtn.Click += DeletAccBtn_Click;
            // 
            // InterestNum
            // 
            InterestNum.Location = new Point(220, 53);
            InterestNum.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            InterestNum.Minimum = new decimal(new int[] { -1530494977, 232830, 0, int.MinValue });
            InterestNum.Name = "InterestNum";
            InterestNum.Size = new Size(176, 35);
            InterestNum.TabIndex = 9;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(14, 58);
            Label3.Margin = new Padding(5, 0, 5, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(171, 30);
            Label3.TabIndex = 10;
            Label3.Text = "Interest Rate (%):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 297);
            Controls.Add(Label3);
            Controls.Add(InterestNum);
            Controls.Add(DeletAccBtn);
            Controls.Add(CreateAccButton);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccButton;
        private Button DeletAccBtn;
        private NumericUpDown InterestNum;
        private Label Label3;
    }
}
