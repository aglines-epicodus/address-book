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

    public Contact(string name, string phone, string email)
    {
      _name = name;
      _phone = phone;
      _email = email;
      _contacts.Add(this);

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

}


    // public string GetName()
    // {
    //   name = _name;
    // }
    // public string GetPhone()
    // {
    //   _phone = phone;
    // }
    // public string GetEmail()
    // {
    //   _email = email;
    // }
    //
    // public void SetName(string newName)
    // {
    //   _name = newName;
    // }
    // public void SetPhone(string newPhone)
    // {
    //   _phone = newPhone;
    // }
    // public void SetEmail(string newEmail)
    // {
    //   _email = newEmail;
    // }



  }
