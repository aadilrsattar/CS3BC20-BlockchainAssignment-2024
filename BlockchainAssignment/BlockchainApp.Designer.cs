﻿using System;

namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.output = new System.Windows.Forms.RichTextBox();
            this.printBlock = new System.Windows.Forms.Button();
            this.blockNo = new System.Windows.Forms.TextBox();
            this.generateWallet = new System.Windows.Forms.Button();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.validateKeys = new System.Windows.Forms.Button();
            this.createTransaction = new System.Windows.Forms.Button();
            this.fee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.reciever = new System.Windows.Forms.TextBox();
            this.recieverKeyLabel = new System.Windows.Forms.Label();
            this.newBlock = new System.Windows.Forms.Button();
            this.printBlockchain = new System.Windows.Forms.Button();
            this.readPendingTransactions = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.currentWalletLabel = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.blocksLabel = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InfoText;
            this.output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Location = new System.Drawing.Point(16, 14);
            this.output.Margin = new System.Windows.Forms.Padding(4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(612, 329);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // printBlock
            // 
            this.printBlock.Location = new System.Drawing.Point(636, 79);
            this.printBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBlock.Name = "printBlock";
            this.printBlock.Size = new System.Drawing.Size(88, 31);
            this.printBlock.TabIndex = 1;
            this.printBlock.Text = "Block #";
            this.printBlock.UseVisualStyleBackColor = true;
            this.printBlock.Click += new System.EventHandler(this.PrintBlock_Click);
            // 
            // blockNo
            // 
            this.blockNo.Location = new System.Drawing.Point(730, 84);
            this.blockNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blockNo.Name = "blockNo";
            this.blockNo.Size = new System.Drawing.Size(31, 22);
            this.blockNo.TabIndex = 2;
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(20, 369);
            this.generateWallet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(106, 67);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate New Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.GenerateWallet_Click);
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(156, 385);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(70, 16);
            this.publicKeyLabel.TabIndex = 4;
            this.publicKeyLabel.Text = "Public Key";
            this.publicKeyLabel.Click += new System.EventHandler(this.publicKeyLabel_Click);
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(151, 413);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(75, 16);
            this.privateKeyLabel.TabIndex = 5;
            this.privateKeyLabel.Text = "Private Key";
            this.privateKeyLabel.Click += new System.EventHandler(this.privateKeyLabel_Click);
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(232, 382);
            this.publicKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(251, 22);
            this.publicKey.TabIndex = 6;
            this.publicKey.TextChanged += new System.EventHandler(this.publicKey_TextChanged);
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(232, 410);
            this.privateKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(251, 22);
            this.privateKey.TabIndex = 7;
            this.privateKey.TextChanged += new System.EventHandler(this.privateKey_TextChanged);
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(489, 377);
            this.validateKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(116, 27);
            this.validateKeys.TabIndex = 8;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.ValidateKeys_Click);
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(639, 236);
            this.createTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(260, 32);
            this.createTransaction.TabIndex = 9;
            this.createTransaction.Text = "Create Transaction";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(850, 185);
            this.fee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(47, 22);
            this.fee.TabIndex = 13;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(739, 185);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(47, 22);
            this.amount.TabIndex = 12;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(812, 187);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(31, 16);
            this.feeLabel.TabIndex = 11;
            this.feeLabel.Text = "Fee";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(676, 187);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(52, 16);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount";
            // 
            // reciever
            // 
            this.reciever.Location = new System.Drawing.Point(739, 210);
            this.reciever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(158, 22);
            this.reciever.TabIndex = 15;
            // 
            // recieverKeyLabel
            // 
            this.recieverKeyLabel.AutoSize = true;
            this.recieverKeyLabel.Location = new System.Drawing.Point(644, 212);
            this.recieverKeyLabel.Name = "recieverKeyLabel";
            this.recieverKeyLabel.Size = new System.Drawing.Size(88, 16);
            this.recieverKeyLabel.TabIndex = 14;
            this.recieverKeyLabel.Text = "Reciever Key";
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(637, 41);
            this.newBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(261, 32);
            this.newBlock.TabIndex = 16;
            this.newBlock.Text = "Generate New Block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.NewBlock_Click);
            // 
            // printBlockchain
            // 
            this.printBlockchain.Location = new System.Drawing.Point(766, 79);
            this.printBlockchain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBlockchain.Name = "printBlockchain";
            this.printBlockchain.Size = new System.Drawing.Size(132, 31);
            this.printBlockchain.TabIndex = 17;
            this.printBlockchain.Text = "Entire Chain";
            this.printBlockchain.UseVisualStyleBackColor = true;
            this.printBlockchain.Click += new System.EventHandler(this.ReadAll_Click);
            // 
            // readPendingTransactions
            // 
            this.readPendingTransactions.Location = new System.Drawing.Point(639, 307);
            this.readPendingTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readPendingTransactions.Name = "readPendingTransactions";
            this.readPendingTransactions.Size = new System.Drawing.Size(261, 31);
            this.readPendingTransactions.TabIndex = 18;
            this.readPendingTransactions.Text = "Read Pending Transactions";
            this.readPendingTransactions.UseVisualStyleBackColor = true;
            this.readPendingTransactions.Click += new System.EventHandler(this.PrintPendingTransactions_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(637, 379);
            this.validate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(261, 57);
            this.validate.TabIndex = 19;
            this.validate.Text = "Full Blockchain Validation";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(489, 406);
            this.checkBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(116, 30);
            this.checkBalance.TabIndex = 20;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // currentWalletLabel
            // 
            this.currentWalletLabel.AutoSize = true;
            this.currentWalletLabel.Location = new System.Drawing.Point(136, 360);
            this.currentWalletLabel.Name = "currentWalletLabel";
            this.currentWalletLabel.Size = new System.Drawing.Size(90, 16);
            this.currentWalletLabel.TabIndex = 22;
            this.currentWalletLabel.Text = "Current Wallet";
            this.currentWalletLabel.Click += new System.EventHandler(this.currentWalletLabel_Click);
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(634, 164);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(85, 16);
            this.transactionLabel.TabIndex = 23;
            this.transactionLabel.Text = "Transactions";
            // 
            // blocksLabel
            // 
            this.blocksLabel.AutoSize = true;
            this.blocksLabel.Location = new System.Drawing.Point(636, 15);
            this.blocksLabel.Name = "blocksLabel";
            this.blocksLabel.Size = new System.Drawing.Size(48, 16);
            this.blocksLabel.TabIndex = 24;
            this.blocksLabel.Text = "Blocks";
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Location = new System.Drawing.Point(638, 353);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(67, 16);
            this.validationLabel.TabIndex = 25;
            this.validationLabel.Text = "Validation";
            this.validationLabel.Click += new System.EventHandler(this.validationLabel_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 20);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Greedy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 20);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Altruist";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(96, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 20);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Random";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(96, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(148, 20);
            this.radioButton4.TabIndex = 29;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Address Preference";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(636, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 73);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 22);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 350);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 22);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Threads";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Difficulty";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 31);
            this.button1.TabIndex = 35;
            this.button1.Text = "Generate Random Transactions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.blocksLabel);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.currentWalletLabel);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.readPendingTransactions);
            this.Controls.Add(this.printBlockchain);
            this.Controls.Add(this.newBlock);
            this.Controls.Add(this.reciever);
            this.Controls.Add(this.recieverKeyLabel);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.createTransaction);
            this.Controls.Add(this.validateKeys);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.generateWallet);
            this.Controls.Add(this.blockNo);
            this.Controls.Add(this.printBlock);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button printBlock;
        private System.Windows.Forms.TextBox blockNo;
        private System.Windows.Forms.Button generateWallet;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Button validateKeys;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox reciever;
        private System.Windows.Forms.Label recieverKeyLabel;
        private System.Windows.Forms.Button newBlock;
        private System.Windows.Forms.Button printBlockchain;
        private System.Windows.Forms.Button readPendingTransactions;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button checkBalance;
        private System.Windows.Forms.Label currentWalletLabel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label blocksLabel;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

