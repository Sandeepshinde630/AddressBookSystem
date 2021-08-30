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
        public void EditContact(string Name)
        {
            foreach (var contact in pcontacts)
            {
                if (contact.FirstName == Name)
                {
                    Console.WriteLine("Enter new First Name");
                    string newFirstName = Console.ReadLine();
                    contact.FirstName = newFirstName;
                    Console.WriteLine("Enter new Last Name:");
                    string newLastName = Console.ReadLine();
                    contact.LastName = newLastName;
                    Console.WriteLine("Enter new Address:");
                    string newAddress = Console.ReadLine();
                    contact.Address = newAddress;
                    Console.WriteLine("Enter new City:");
                    string newCity = Console.ReadLine();
                    contact.City = newCity;
                    Console.WriteLine("Enter new State:");
                    string newState = Console.ReadLine();
                    contact.State = newState;
                    Console.WriteLine("Enter new Zip Code:");
                    string newZipcode = Console.ReadLine();
                    contact.ZipCode = newZipcode;
                    Console.WriteLine("Enter new Phone Number:");
                    string newPhonenumber = Console.ReadLine();
                    contact.PhoneNumber = newPhonenumber;
                    Console.WriteLine("Enter new Email:");
                    string newEmail = Console.ReadLine();
                    contact.Email = newEmail;
                    Console.WriteLine("--------------------------------------------");
                }
            }
        }
        public void DeleteContact(string name)
        {
            foreach (var contact in pcontacts)
            {
                if (contact.FirstName == name)
                {
                    pcontacts.Remove(contact);
                    Console.WriteLine("---------------------------------\n!!Contact Removed!!");
                    break;
                }
            }
        }
    }
}
