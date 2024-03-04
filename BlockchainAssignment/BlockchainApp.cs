using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BlockchainAssignment.Block;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        // Global blockchain object
        private Blockchain blockchain;

        Block block = new Block();

        // Mining preference property

        // Default App Constructor
        public BlockchainApp()
        {
            // Initialise UI Components
            InitializeComponent();
            // Create a new blockchain 
            blockchain = new Blockchain();
            // Update UI with an initalisation message
            UpdateText("New blockchain initialised!");

        }

        /* PRINTING */
        // Helper method to update the UI with a provided message
        private void UpdateText(String text)
        {
            output.Text = text;
        }

        // Print entire blockchain to UI
        private void ReadAll_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.ToString());
        }

        // Print Block N (based on user input)
        private void PrintBlock_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(blockNo.Text, out int index))
                UpdateText(blockchain.GetBlockAsString(index));
            else
                UpdateText("Invalid Block No.");
        }

        // Print pending transactions from the transaction pool to the UI
        private void PrintPendingTransactions_Click(object sender, EventArgs e)
        {
            UpdateText(String.Join("\n", blockchain.transactionPool));
        }

        /* WALLETS */
        // Generate a new Wallet and fill the public and private key fields of the UI
        private void GenerateWallet_Click(object sender, EventArgs e)
        {
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out string privKey);

            publicKey.Text = myNewWallet.publicID;
            privateKey.Text = privKey;
        }

        // Validate the keys loaded in the UI by comparing their mathematical relationship
        private void ValidateKeys_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKey.Text, publicKey.Text))
                UpdateText("Keys are valid");
            else
                UpdateText("Keys are invalid");
        }

        // Check the balance of current user
        private void CheckBalance_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.GetBalance(publicKey.Text).ToString() + " Assignment Coin");
        }


        /* TRANSACTION MANAGEMENT */
        // Create a new pending transaction and add it to the transaction pool
        private void CreateTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(publicKey.Text, reciever.Text, Double.Parse(amount.Text), Double.Parse(fee.Text), privateKey.Text);
            /* TODO: Validate transaction */
            blockchain.transactionPool.Add(transaction);
            UpdateText(transaction.ToString());
        }

        /* BLOCK MANAGEMENT */
        // Conduct Proof-of-work in order to mine transactions from the pool and submit a new block to the Blockchain
        private void NewBlock_Click(object sender, EventArgs e)
        {
            // Retrieve pending transactions to be added to the newly generated Block
            List<Transaction> transactions = blockchain.GetPendingTransactions();

            // Create and append the new block - requires a reference to the previous block, a set of transactions, and the miner's public address (For the reward to be issued)
            Block newBlock = new Block(blockchain.GetLastBlock(), transactions, publicKey.Text);
            blockchain.blocks.Add(newBlock);

            // Retrieve the elapsed time, difficulty, and number of threads of the mining process
            TimeSpan elapsedTime = Block.StaticElapsedTime;
            int difficulty = newBlock.Difficulty;
            int threads = newBlock.Threads;

            string formattedTime = $"Mining Time: {elapsedTime.ToString(@"m\:ss\.fff")}, Difficulty: {difficulty}, Threads: {threads}";

            // Update the UI with blockchain information and mining time
            UpdateText($"{blockchain.ToString()}\n{formattedTime}");
        }



        /* BLOCKCHAIN VALIDATION */
        // Validate the integrity of the state of the Blockchain
        private void Validate_Click(object sender, EventArgs e)
        {
            // CASE: Genesis Block - Check only hash as no transactions are currently present
            if(blockchain.blocks.Count == 1)
            {
                if (!Blockchain.ValidateHash(blockchain.blocks[0])) // Recompute Hash to check validity
                    UpdateText("Blockchain is invalid");
                else
                    UpdateText("Blockchain is valid");
                return;
            }

            for (int i=1; i<blockchain.blocks.Count-1; i++)
            {
                if(
                    blockchain.blocks[i].prevHash != blockchain.blocks[i - 1].hash || // Check hash "chain"
                    !Blockchain.ValidateHash(blockchain.blocks[i]) ||  // Check each blocks hash
                    !Blockchain.ValidateMerkleRoot(blockchain.blocks[i]) // Check transaction integrity using Merkle Root
                )
                {
                    UpdateText("Blockchain is invalid");
                    return;
                }
            }
            UpdateText("Blockchain is valid");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                blockchain.CurrentMiningPreference = Blockchain.MiningPreference.Greedy;
                Debug.Print("RadioButton 1 Checked");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                blockchain.CurrentMiningPreference = Blockchain.MiningPreference.Altruistic;
                Debug.Print("RadioButton 2 Checked");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                blockchain.CurrentMiningPreference = Blockchain.MiningPreference.Random;
                Debug.Print("RadioButton 3 Checked");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                blockchain.CurrentMiningPreference = Blockchain.MiningPreference.AddressPreference;
                blockchain.SortTransactionsByAddressPreference(publicKey.Text);
                Debug.Print("RadioButton 4 Checked");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Assuming textBox2 contains the difficulty value entered by the user
            if (int.TryParse(textBox2.Text, out int newDifficulty))
            {
                // Set the difficulty using the setter
                block.Difficulty=newDifficulty;
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int newThreads))
            {
                // Set the difficulty using the setter
                block.Threads = newThreads;
            }
        }

        private void validationLabel_Click(object sender, EventArgs e)
        {

        }


        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            Random random = new Random();
            int numberOfTransactions = random.Next(5, 11);

            for (int i = 0; i < numberOfTransactions; i++)
            {
                UpdateText("Generating randoms " +i+"/"+numberOfTransactions);
                Wallet.Wallet senderWallet = new Wallet.Wallet(out string senderPrivKey);
                Wallet.Wallet receiverWallet = new Wallet.Wallet(out string receiverPrivKey);

                string senderAddress = senderWallet.publicID;
                string receiverAddress = receiverWallet.publicID;
                double amount = random.NextDouble() * 10;
                double fee = random.NextDouble() * 2;

                Transaction transaction = new Transaction(senderAddress, receiverAddress, amount, fee, senderPrivKey);
                blockchain.transactionPool.Add(transaction);

                // Generate a random delay between transactions (e.g., between 1 and 5 seconds)
                int delayMilliseconds = random.Next(1000, 5001);
                await Task.Delay(delayMilliseconds); // Introduce an asynchronous delay
            }

            UpdateText("Random transactions generated and added to the transaction pool.");
        }

        private void publicKeyLabel_Click(object sender, EventArgs e)
        {

        }

        private void privateKeyLabel_Click(object sender, EventArgs e)
        {

        }

        private void currentWalletLabel_Click(object sender, EventArgs e)
        {

        }

        private void publicKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void privateKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

