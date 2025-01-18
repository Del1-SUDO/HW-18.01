BankAccount info = new BankAccount();
info.DepositAndWithdraw();

class BankAccount{
    private int accountID = 12345;
    private decimal balance = 100;
    private string OwnerName = "Siyovush";
    private bool isFrozen = true;

    public void DepositAndWithdraw(){
        while (true){
            if (isFrozen==false){
                System.Console.WriteLine("Press 'D' to deposit money, or press 'W' to withdraw money: ");
                char ch = char.Parse(Console.ReadLine());
                if (ch=='D'){
                    System.Console.Write("Enter amount you want to deposit: ");
                    int amount = int.Parse(Console.ReadLine());
                    if (amount<1){
                        System.Console.WriteLine("Deposit must be more than 0 somoni.");
                        return;
                    }
                    else{
                        balance+=amount;
                        System.Console.WriteLine("Deposit has been done successefully.");
                        System.Console.WriteLine($"You have {balance} somoni left on balace.");
                        break;
                    }
                }
                else if (ch=='W'){
                    System.Console.Write("Enter amount you want to withdraw: ");
                    int amount = int.Parse(Console.ReadLine());
                    if (amount>balance || amount<1){
                        System.Console.WriteLine("Not enough money on balance or wrong amount.");
                        return;
                    }
                    else{
                        balance-=amount;
                        System.Console.WriteLine("Withdraw has been done successefully.");
                        System.Console.WriteLine($"You have {balance} somoni left on balace.");
                        break;
                    }
                }
                else{
                    System.Console.WriteLine("Error. Invalid option.");
                    break;
                }
            }

            else if (isFrozen == true) {
                System.Console.WriteLine("Sorry, your account is frozen at the moment.");
                System.Console.WriteLine("Would you like to unfreeze your account? Press 'Y' to unfreeze or 'N' to exit.");
                char userChoice = char.Parse(Console.ReadLine());
                if (userChoice == 'Y') {
                    isFrozen = false;
                    System.Console.WriteLine("Your account has been unfrozen.");
                    continue;
                }
                else if (userChoice == 'N') {
                    System.Console.WriteLine("Exiting. Have a great day!");
                    break;
                }
                else {
                    System.Console.WriteLine("Invalid choice. Try again.");
                }
            }

        }   
    }

}