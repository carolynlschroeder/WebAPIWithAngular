using System;
using System.Collections.Generic;

namespace ContactsAPI.Entities
{
    public partial class Contact
    {
        public Guid ContactId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
