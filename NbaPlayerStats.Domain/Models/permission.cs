using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NbaPlayerStats.Domain.Models
{
    public class permission
    {
        public string user { get; set; }
        public string LevelOfPermission { get; set; }

        public virtual ICollection<users> users { get; set; }
    }
}