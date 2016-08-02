using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelperPractice.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Details { get; set; }
        public string Password { get; set; }
        public bool SendEmail { get; set; }
        public string Gender { get; set; }
        
        public static ContactInfo GetContactInfo()
        {
            ContactInfo contact = new Models.ContactInfo();
            contact.Name = "Jim Weiss";
            contact.Email = "jweiss@motor.com";
            contact.PhoneNumber = "586-354-8291";
            contact.Details = "This is a long string of meaningless details.";
            contact.Password = "BeAHumanFirewall";
            contact.SendEmail = false;
            contact.Gender = "Male";
            contact.Id = 11;

            return contact;
        }

        public static IEnumerable<ContactInfo> GetContactList()
        {
            List<ContactInfo> contacts = new List<ContactInfo>();
            for (int i = 0; i < 8; i++)
            {
                ContactInfo contact = new Models.ContactInfo();
                contact.Name = "Name " + i;
                contact.Email = "Email" + i + "@motor.com";
                contact.PhoneNumber = string.Format("{0}{0}{0}-{0}{0}{0}-{0}{0}{0}{0}", i);

                contacts.Add(contact);
            }

            return contacts;
        }
    }
}