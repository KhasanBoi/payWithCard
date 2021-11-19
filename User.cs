using System;
using System.Collections.Generic;

public class User
{
  	private string name;
  	private double balance;
  	private string password;
  	private int cardNumber;
	private double cashback;
	private List<string> history = new List<string>();
  // CASHBACK WALLET GOES HERE

  public User()
  {
  }
  public User(string name, double balance, string password, int cardNumber)
  {
	  this.name = name;
      this.balance = balance;
      this.password = password;
      this.cardNumber = cardNumber;
  }
	
  public void addToHistory(string text)
  {
	  history.Add(text);
  }
	public List<string> getHistory()
	{
		return this.history;
	}

  public string Name 
  {
    get { return name; }
    set { name = value; }
  }
  public double Balance
  {
    get { return balance; }
    set { balance = value; }
  }
  public string Password
  {
    get { return password; }
    set { password = value; }
  }
  public int  CardNumber
  {
    get { return cardNumber; }
    set { cardNumber = value;}
  }
	public double Cashback
	{
		get { return cardNumber; }
		set { cashback = value; }
	}
}
