using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Context
{
    static class DbContext
    {
        static DbContext()
        {
            Students = new List<Student>();
            Groups = new List<Group>();
        }
        public static List<Student> Students { get; set; }

        public static List<Group> Groups { get; set; }

        public static object Group { get; internal set; }
    }
}
