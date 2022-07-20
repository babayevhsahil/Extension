using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Etities;

using System.Threading.Tasks;
using DataAcces.Respositories.Base;
using DataAcces.Context;

namespace DataAcces.Implementations
{
    public class GroupRepository : IRepository<Group>
    {
        private static int id;
        public Group Create(Group entity)
        {
            id++;
                entity.id= id;
            DbContext.Groups.Add(entity);
            return entity;
        }

        public void Delete(Group entity) 
        {
            DbContext.Groups.Remove(entity);
        }

       public Group Get(Predicate <Group> filter = null)
        {
            if (filter == null)
            {
                return DbContext.Groups[0];
            }
            else
            {
                return DbContext.Groups.Find(filter);
            }
        }

       
        public List<Group> GetAll(Predicate<Group> filter = null)
        {
           if (filter == null)
            {
                return DbContext.Groups;
            }
           else
            {
                return DbContext.Groups.FindAll(filter);
            }
        }

        public void Update(Group entity)
        {
            var group = DbContext.Groups.Find(g => g.id == entity.id);
            if (group == null)
            {
                group.Name = entity.Name;
                group.MaxSize = entity.MaxSize;
            }
        }
    }
}
