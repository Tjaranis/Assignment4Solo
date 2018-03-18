using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment4
{
    public class DataService
    {
        
        /*
         * @int v id-number of categary
         * @return Category with the id number given.
         */
        public Category GetCategory(int categoryId)
        {
            using (var db = new NorthwindConnect())
            {
                foreach (var category in db.Categories)
                {
                    if(categoryId.Equals(category.Id))
                    {
                        return category;
                    }
                }
            }
            return null;
        }

        public List<Category> GetCategories()
        {
            var db = new NorthwindConnect();
            //List<Category> dbList = List(db.Categories);
            return db.Categories.ToList();
        }

        public Category CreateCategory(string v1, string v2)
        {
            using (var db = new NorthwindConnect())
            {
                var category = new Category(v1, v2);
                db.Categories.Add(category);
                db.SaveChanges();
                return db.Categories.Last();
            }

        }
        public void CreatedCategory(Category category)
        {
            using (var db = new NorthwindConnect())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }

        /*public void DeleteCategory(object id)
        {
            using (var db = new NorthwindConnect())
            {
                db.Categories.Remove(db.Categories.Find(id));
                db.SaveChanges();
            }
        }*/

        public bool DeleteCategory(int id)
        {
            using (var db = new NorthwindConnect())
            {
                var category = db.Categories.Find(id);
                if (category == null) return false;
                db.Categories.Remove(db.Categories.Find(id));
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateCategory(int id, string name, string description)
        {
            using (var db = new NorthwindConnect())
            {
                var category = db.Categories.Find(id);
                if (category == null) return false;
                category.Id = id;
                category.Name = name;
                category.Description = description;
                db.SaveChanges();
                return true;
            }
        }
    }
}
