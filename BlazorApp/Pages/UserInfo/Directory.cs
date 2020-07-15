using BlazorApp.Models;
using System.Collections.Generic;

namespace BlazorApp.Pages.UserInfo
{
    public partial class Directory
    {
        public List<PersonModel> People { get; set; }

        public Directory()
        {
            People = new List<PersonModel>
            {
                new PersonModel
                {
                    FirstName = "Iyad",
                    LastName ="Shobaki",
                    Addresses = new List<AddressModel>
                    {
                       new AddressModel
                       {
                           AddressType = "Home Address",
                           StreetAddress = "1 Oak Street",
                           City = "Lakewood",
                           State = "OH",
                           ZipCode = "12345"
                       },
                       new AddressModel
                       {
                           AddressType = "Vacation Home",
                           StreetAddress = "101 Beachfront Ave",
                           City = "Miami",
                           State = "Fl",
                           ZipCode = "66345"
                       }
                    }

                },
                new PersonModel
                {
                    FirstName = "Tim",
                    LastName ="Corey",
                    Addresses = new List<AddressModel>
                    {
                       new AddressModel
                       {
                           AddressType = "Home Address",
                           StreetAddress = "115 Justice Way",
                           City = "Scranton",
                           State = "PA",
                           ZipCode = "12345"
                       }
                    }

                },
                new PersonModel
                {
                    FirstName = "Bob",
                    LastName ="Smith",
                    Addresses = new List<AddressModel>()


                }

            };
        }
    }
}
