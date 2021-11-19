using System;
using System.Collections.Generic;

public class Program 
{
  public static void Main (string[] args) 
  {
	  var data = new Data();
	  var signInAndUp = new SignInUp();
	  var checkUserData = new CheckUser();
	  signInAndUp.entryOptions(data, checkUserData);
  }
}