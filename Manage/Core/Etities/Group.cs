using Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Etities
{
    public class Group : IEntities
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int MaxSize { get; set; }
    }
}
