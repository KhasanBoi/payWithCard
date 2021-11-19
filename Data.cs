using System;
using System.Collections.Generic;


public class Data
{
  private List<User> users = new List<User>();
  public Data()
  {
  }
  public void addUser(User user)
  {
    users.Add(user);
  }
  public List<User> getUsers()
  {
    return users;
  }
}