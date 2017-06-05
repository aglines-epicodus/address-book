using Nancy;
using System;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ =>
      {
        List<Contact> Contacts = Contact.GetAll();
        return View["viewall.cshtml", Contacts];
      };

      Get["/contacts/addnew"] = _ =>
      {
        return View["contacts/addnew.cshtml"];
      };

      Post["/contacts/addnew"] = _ =>
      {
        int count = 1;
        Contact newContact = new Contact(Request.Form["contactName"], Request.Form["contactEmail"], Request.Form["contactPhone"]);
        return View["contacts/newadded.cshtml", newContact];
      };

      Get["/contacts/{id}"] = parameters => {
        Contact newContact = Contact.Find(parameters.id);
        return View["newadded.cshtml", newcontact];
      };







    }
  }
}
