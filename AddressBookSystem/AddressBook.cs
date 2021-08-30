using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        private List<Contact> pcontacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            pcontacts.Add(contact);
        }

        public void DisplayAllContact()
        {
            foreach (var contact in pcontacts)
            {
                Console.WriteLine("SAVED CONTACT IS :\n" + contact.FirstName + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip Code: " + contact.ZipCode + "\nPhone Number: " + contact.PhoneNumber + "\nEmail: " + contact.Email);

            }
        }
    }
}
