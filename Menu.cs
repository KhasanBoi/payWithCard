using System;
using System.Collections.Generic;

public class Menu
{
	public Menu()
	{
	}
	public void ShowMenu(Data data, User user, CheckUser checkUserData)
	{
		int payment = 0;
		Console.WriteLine("1. Utilities");
		Console.WriteLine("2. Mobile phone");
		Console.WriteLine("3. Money transfer");
		Console.WriteLine("4. Check Balance");
		Console.WriteLine("5. Check Cashback Wallet");
		Console.WriteLine("6. See history");
		int opt = Convert.ToInt32(Console.ReadLine());
		switch(opt)
		{
			case 1:
				Console.WriteLine("1. Electricity");
				Console.WriteLine("2. Gas");
				Console.WriteLine("3. Water");
				int opt1 = Convert.ToInt32(Console.ReadLine());
				if(opt1 == 1)
				{
					Console.WriteLine("Enter amount");
					payment = Convert.ToInt32(Console.ReadLine());
					user.Balance -= payment;
					string history1 = "Electricity: $"+payment.ToString();
					user.addToHistory(history1);
					user.Cashback += payment*0.005;
					ShowMenu(data, user, checkUserData);
				}
				if(opt1 == 2)
				{
					Console.WriteLine("Enter amount");
					payment = Convert.ToInt32(Console.ReadLine());
					user.Balance -= payment;
					string history2 = "Gas: $"+payment.ToString();
					user.addToHistory(history2);
					user.Cashback += payment*0.005;
					ShowMenu(data, user, checkUserData);
				}
				if(opt1 == 3)
				{
					Console.WriteLine("Enter amount");
					payment = Convert.ToInt32(Console.ReadLine());
					user.Balance -= payment;
					string history3 = "Water: $"+payment.ToString();
					user.addToHistory(history3);
					user.Cashback += payment*0.005;
					ShowMenu(data, user, checkUserData);
				}
				break;
			case 2:
				Console.WriteLine("Write number");
				string useless = Console.ReadLine();
				Console.WriteLine("Enter amount");
				payment = Convert.ToInt32(Console.ReadLine());
				user.Balance -= payment;
				string history4 = "Mobile number "+useless+": $"+payment.ToString();
				user.addToHistory(history4);	
				user.Cashback += payment*0.005;
				ShowMenu(data, user, checkUserData);
				break;
			case 3:
				Console.WriteLine("Write Receiver Card Number");
				int receiveCardNum = Convert.ToInt32(Console.ReadLine());
				User receiverUser = checkUserData.checkReceiverCardNumber(data, receiveCardNum);
				if(receiverUser.Name == "xxx" && receiverUser.Balance == 0 && receiverUser.CardNumber == 0 && receiverUser.Password == "xxx")
				{
					Console.WriteLine("Card does not exists");
					ShowMenu(data, user, checkUserData);
				}
				else
				{
					Console.WriteLine("Amount of money you want to transfer to user: "+receiverUser.Name);
					int trnsMoney = Convert.ToInt32(Console.ReadLine());
					user.Balance -= trnsMoney;
					string history5 = "Money Transfer to Card: UserName: "+receiverUser.Name+", Card Number: "+receiverUser.CardNumber+". $"+trnsMoney.ToString();
					user.addToHistory(history5);
					receiverUser.Balance += trnsMoney;
					user.Cashback += trnsMoney*0.005;
					double servicePay = trnsMoney*0.01;
					user.Balance -= servicePay;
					ShowMenu(data, user, checkUserData);
				}
				break;
			case 4:
				Console.WriteLine("Enter your password");
				string pswrd = Console.ReadLine();
				if(pswrd == user.Password)
				{
					Console.WriteLine("Your Balance: $"+user.Balance);
					ShowMenu(data, user, checkUserData);
				}
				else
				{
					Console.WriteLine("Wrong Password, you have");
					ShowMenu(data, user, checkUserData);
				}
				break;
			case 5:
				Console.WriteLine("Enter your password");
				string pswrd1 = Console.ReadLine();
				if(pswrd1 == user.Password)
				{
					Console.WriteLine("You have earned $"+user.Cashback);
					ShowMenu(data, user, checkUserData);
				}
				else
				{
					Console.WriteLine("Wrong Password");
					ShowMenu(data, user, checkUserData);
				}
				break;
			case 6:
				// YOUR CODE GOES HERE
				List<string> texts = user.getHistory();
				foreach(string text in texts)
				{
					Console.WriteLine(text);
				}
				ShowMenu(data, user, checkUserData);
				break;
		}
	}
}