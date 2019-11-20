using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainMenu
{
    public class ClassManagement
    {
        public Class[] Getclass()
        {
            var db = new ONTAPEntities();
            var classes = db.Classes.ToArray();

            return classes;
        }

        public void AddClass(string name, string description)
        {
            var newClass = new Class();
            newClass.NAME = name;
            newClass.DESCRIPTION = description;

            var db = new ONTAPEntities();
            db.Classes.Add(newClass);
            db.SaveChanges();
        }

        public void EditClass(int id, string name, string description)
        {
            var db = new ONTAPEntities();
            var oldClass = db.Classes.Find(id);

            oldClass.NAME = name;
            oldClass.DESCRIPTION = description;

            db.Entry(oldClass).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteClass(int id)
        {
            var db = new ONTAPEntities();
            var @class = db.Classes.Find(id);
            db.Classes.Remove(@class);
            db.SaveChanges();
        }

        public Class GetClass(int id)
        {
            var db = new ONTAPEntities();
            var @class = db.Classes.Find(id);
            return @class;
        }
    }
        
        
}
