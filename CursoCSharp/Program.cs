class Program
{
	static void Main()

	{
		BankAccount account1 = new BankAccount("Guilherme ", 56789);

		BankAccount account2 = new BankAccount("Jordão", 123);

		account1.Deposit(-100);
		account2.Deposit(100);

	}

}

class BankAccount
{

	private string name;

	private decimal balance;


	public BankAccount(string name, decimal balance)
	{

		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("Nome Inválido", nameof(name));
		}

		if (balance <= 0)
		{
			throw new Exception("Saldo Inválido");
		}

		this.name = name;
		this.balance = balance;

	}

	public void Deposit(decimal amount)
	{

		if (amount <= 0)
		{
		
			return;
		}

		balance += amount;


	}

}




