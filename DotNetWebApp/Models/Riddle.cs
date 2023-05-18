using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetWebApp.Models
{
    public class Riddle
    {

        public int Id { get; set; }
        public String RiddleQuestion { get; set; }
        public string RiddleAnswer { get; set; }
    }
}
