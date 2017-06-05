using System;
using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _email;
    private static List<Contact> _contacts = new List<Contact> {};
    private int _id;

    public Contact(string name, string phone, string email)
    {
      _name = name;
      _phone = phone;
      _email = email;
      _contacts.Add(this);
      _id = _contacts.Count;
    }

    public string GetName()
    {
      return _name;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public string GetEmail()
    {
      return _email;
    }
    public static List<Contact> GetAll()
    {
      return _contacts;
    }
    public int GetId()
    {
      return _id;
    }

    public static void Clear()
    {
      _contacts.Clear();
    }


    public static Contact Find(int searchId)
    {
      return _contacts[searchId - 1];
    }




  }
}
