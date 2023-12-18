# ATM System

Welcome to the ATM System repository! This C# console program simulates an ATM system with basic functionalities. 

## Classes

### CardHolder

The `CardHolder` class represents a cardholder with the following attributes:

- `CardNum`: Cardholder's card number
- `Pin`: Cardholder's PIN
- `FirstName`: Cardholder's first name
- `LastName`: Cardholder's last name
- `Balance`: Cardholder's account balance

### Deposit

The `Deposit` class provides a method to handle deposits:

- `ShowDeposit`: Displays a prompt for the user to deposit money, updates the account balance, and shows the new balance.

### ShowBalance

The `ShowBalance` class provides a method to display the account balance:

- `Show`: Displays the current account balance.

### Withdraw

The `Withdraw` class provides a method to handle withdrawals:

- `ShowWithdraw`: Displays a prompt for the user to withdraw money, checks for sufficient balance, updates the account balance, and shows the new balance.

## Main Program

The `ATMApp` class contains the `Main` method that orchestrates the ATM functionalities. It includes:

- Creating a list of `CardHolder` instances.
- Handling user input for debit card and PIN.
- Displaying a menu for deposit, withdrawal, balance check, and exit options.
- Utilizing the functionalities provided by the `Deposit`, `ShowBalance`, and `Withdraw` classes.

## How to Use

1. Clone the repository to your local machine.
2. Open the solution in a C# development environment.
3. Run the program (`ATMApp.cs`).
4. Follow the on-screen prompts to simulate ATM transactions.

Feel free to explore the program, make modifications, or adapt it for your specific needs. Happy coding!
