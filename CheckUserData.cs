using System;
using System.Collections.Generic;

public class CheckUser
{
	public CheckUser()
	{
	}
	public bool checkPassword(Data data, string password)
	{
		List<User> users = data.getUsers();
		foreach(User eachUser in users)
		{
			if(eachUser.Password == password)
			{
				return true;
			}
		}
		return false;
	}
	public bool checkCardNumber(Data data, int cardNum)
	{
		List<User> users = data.getUsers();
		foreach(User user in users)
		{
			if(user.CardNumber == cardNum)
			{
				return true;
			}
		}
		return false;
	}
	public bool checkName(Data data, string name)
	{
		List<User> users = data.getUsers();
		foreach(User user in users)
		{
			if(user.Name == name)
			{
				return true;
			}
		}
		return false;
	}
	public User checkReceiverCardNumber(Data data, int cardReceiverNum)
	{
		List<User> users = data.getUsers();
		foreach(User user in users)
		{
			if(user.CardNumber == cardReceiverNum)
			{
				return user;
			}
		}
		User emptyUser = new User("xxx",0,"xxx",0);
		return emptyUser;
	}
	public User checkSignedUser(string name, string password, Data data)
	{
		List<User> users = data.getUsers();
		foreach(User user in users)
		{
			if(user.Name == name && user.Password == password)
			{
				return user;
			}
		}
		User emptyUser = new User("xxx",0,"xxx",0);
		return emptyUser;
	}
}
