using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examples04.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public int CommunityId { get; set; }
    }
}