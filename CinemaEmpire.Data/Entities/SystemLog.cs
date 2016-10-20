using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEmpire.Data.Entities
{
    public class SystemLog
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string Message { get; set; }
    }
}
