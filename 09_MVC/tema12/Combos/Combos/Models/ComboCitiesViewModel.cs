using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Combos.Models
{
    public class ComboCitiesViewModel
    {
        public IEnumerable<Ciudad> Cities { get; set; }
        public int SelectedCity { get; set; }
    }
}