using System;
using System.Collections.Generic;
using System.Text;
using BP.Api.Data.Models;
using BP.Api.Models;

namespace BP.Api.Service
{
    public class ContactService : IContactService
    {

        public ContactDVO GetContactById(int Id)
        {
            // veritabanından kayıdın getirilmesi   

            Contact dbContact = getDummyContact();

            return new ContactDVO()
            {
                Id = dbContact.Id,
                FullName = $"{dbContact.FirstName} {dbContact.LastName}"
            };
        }

        private Contact getDummyContact()
        {
            return new Contact()
            {
            Id = 1,
            FirstName = "Nurullah",
            LastName = "Namal"
        };
    }
}
}
