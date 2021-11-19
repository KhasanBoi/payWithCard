using System;
using System.Collections.Generic;

public class SignInUp
{
	public SignInUp()
	{
	}
	public void entryOptions(Data data, CheckUser checkUserData)
	{
		
		Console.WriteLine("1. Sign in");
    	Console.WriteLine("2. Sign up");
    	int opt = Convert.ToInt32(Console.ReadLine());

		// SIGN IN 
		if(opt == 1)
		{
			Console.WriteLine("Enter your name");
		  	var name = Console.ReadLine();
		  	Console.WriteLine("Enter your password");
		  	string password = Console.ReadLine();
			//check!!!
			User checkSignUser = checkUserData.checkSignedUser(name, password, data);
			if(checkSignUser.Name == "xxx" && checkSignUser.Balance == 0 && checkSignUser.CardNumber == 0 && checkSignUser.Password == "xxx")
			{
				Console.WriteLine("User does not exist, sign up");
				entryOptions(data, checkUserData);
			}
			else
			{
			// DIRECT TO PAYING SERVICES SECTION
				var menu = new Menu();
				menu.ShowMenu(data, checkSignUser, checkUserData);
			}
		}
		
		// SIGN UP
		if(opt == 2)
		{
			bool existsCardNum, existsPassword = false;
			Console.WriteLine("Enter your name");
		  	var name = Console.ReadLine();
		  	Console.WriteLine("Enter card number (must be 4-digit)");
		  	int cardNumber = Convert.ToInt32(Console.ReadLine());
			existsCardNum = checkUserData.checkCardNumber(data, cardNumber);
			if(existsCardNum)
			{
				while(existsCardNum)
				{
					Console.WriteLine("Card already exists, sign in");
					entryOptions(data, checkUserData);
				}
			}
			Console.WriteLine("Enter a new password");
		  	string password = Console.ReadLine();
			existsPassword = checkUserData.checkPassword(data, password);
			if(existsPassword)
			{
				while(existsPassword)
				{
					Console.WriteLine("Password is already taken");
		  			Console.WriteLine("Enter a new password");
		  			password = Console.ReadLine();
					existsPassword = checkUserData.checkPassword(data, password);
				}
			}			
		  	Random r = new Random();
		  	int balance = r.Next(50,1000);
		  	var user1 = new User(name, balance, password, cardNumber);
		  	data.addUser(user1);
			var menu = new Menu();
			menu.ShowMenu(data, user1, checkUserData);
			// DIRECT TO PAYING SERVICES SECTION
			// YOUR CODE GOES HERE //
		  }
	}
}