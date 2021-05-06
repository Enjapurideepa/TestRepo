

namespace lab5

    {
        class Program
        {
            static void Main(string[] args)
            {
                BankAccountTypeEnum savings = BankAccountTypeEnum.Saving;
                BankAccountTypeEnum current = BankAccountTypeEnum.Current;
                ICICI icicisav = new ICICI();
                icicisav.AccountType = savings;
                icicisav.Deposit(50000);
                ICICI icicicur = new ICICI();
                icicicur.AccountType = current;
                icicicur.Deposit(20000);
                Console.WriteLine("The Balance Of 1st Account" + icicisav.GetBalance());
                Console.WriteLine("The Balance Of 2st Account" + icicicur.GetBalance());
                icicisav.Transfer(icicicur, 5000);
                Console.WriteLine("The Balance Of 1st Account After Transfer" + icicisav.GetBalance());
                Console.WriteLine("The Balance Of 2st Account After Transfer" + icicicur.GetBalance());
                Console.ReadKey();
            }
        }
    }

