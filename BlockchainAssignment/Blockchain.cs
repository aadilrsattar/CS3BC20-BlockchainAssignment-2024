using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        // List of block objects forming the blockchain
        public List<Block> blocks;

        // Maximum number of transactions per block
        private int transactionsPerBlock = 5;

        // List of pending transactions to be mined

        public List<Transaction> transactionPool = new List<Transaction>();


        // Mining preference property
        public MiningPreference CurrentMiningPreference { get; set; }

        public enum MiningPreference
        {
            Greedy,      // Highest fee first
            Altruistic,  // Longest wait first
            Random,      // Random selection
            AddressPreference  // Transactions involving miner's address first
        }
        //TODO sort transactions

        // Default Constructor - initialises the list of blocks and generates the genesis block
        public Blockchain()
        {
            blocks = new List<Block>()
            {
                new Block() // Create and append the Genesis Block
            };
        }

        // Prints the block at the specified index to the UI
        public String GetBlockAsString(int index)
        {
            // Check if referenced block exists
            if (index >= 0 && index < blocks.Count)
                return blocks[index].ToString(); // Return block as a string
            else
                return "No such block exists";
        }

        // Retrieves the most recently appended block in the blockchain
        public Block GetLastBlock()
        {
            return blocks[blocks.Count - 1];
        }

        // Sort the transactions based on the mining preference
        private List<Transaction> SortTransactions(List<Transaction> transactions)
        {
            switch (CurrentMiningPreference)
            {
                case MiningPreference.Greedy:
                    return transactions.OrderByDescending(t => t.fee).ToList();
                case MiningPreference.Altruistic:
                    return transactions.OrderBy(t => t.timestamp).ToList();
                case MiningPreference.Random:
                    Random random = new Random();
                    return transactions.OrderBy(t => random.Next()).ToList();
                case MiningPreference.AddressPreference:
                    // Example: Sort transactions based on recipient address
                    return transactions.OrderBy(t => t.recipientAddress).ToList();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        // Add a transaction to the transaction pool, sorting based on the mining preference
        public void AddTransaction(Transaction transaction)
        {
            transactionPool.Add(transaction);
            transactionPool = SortTransactions(transactionPool);
        }

        // Retrieve pending transactions and remove from pool, sorting based on the mining preference
        public List<Transaction> GetPendingTransactions()
        {
            // Determine the number of transactions to retrieve dependent on the number of pending transactions and the limit specified
            int n = Math.Min(transactionsPerBlock, transactionPool.Count);

            // "Pull" transactions from the transaction list (modifying the original list)
            List<Transaction> transactions = transactionPool.GetRange(0, n);
            transactionPool.RemoveRange(0, n);

            // Sort the extracted transactions based on the mining preference
            transactions = SortTransactions(transactions);

            // Return the extracted and sorted transactions
            return transactions;
        }

        // Check validity of a blocks hash by recomputing the hash and comparing with the mined value
        public static bool ValidateHash(Block b)
        {
            String rehash = b.CreateHash(b.nonce);
            return rehash.Equals(b.hash);
        }

        // Check validity of the merkle root by recalculating the root and comparing with the mined value
        public static bool ValidateMerkleRoot(Block b)
        {
            String reMerkle = Block.MerkleRoot(b.transactionList);
            return reMerkle.Equals(b.merkleRoot);
        }

        // Check the balance associated with a wallet based on the public key
        public double GetBalance(String address)
        {
            // Accumulator value
            double balance = 0;

            // Loop through all approved transactions in order to assess account balance
            foreach(Block b in blocks)
            {
                foreach(Transaction t in b.transactionList)
                {
                    if (t.recipientAddress.Equals(address))
                    {
                        balance += t.amount; // Credit funds recieved
                    }
                    if (t.senderAddress.Equals(address))
                    {
                        balance -= (t.amount + t.fee); // Debit payments placed
                    }
                }
            }
            return balance;
        }

        // Output all blocks of the blockchain as a string
        public override string ToString()
        {
            return String.Join("\n", blocks);
        }



    }
}
