using FormsTesting.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FormsTesting
{
    public class SGPContrtolObject : SGPControlLibrary.IDataAccessObject
    {
        DatabaseConnector DB = new DatabaseConnector();

        public int GetTotalCount(string keyword)
        {
            //keyword = keyword.ToLower();
            //int count;
            //if (string.IsNullOrWhiteSpace(keyword))
            //    count = db.TestClasses.Count();
            //else
            //    count = db.TestClasses.Where(x => x.Name.ToLower().Contains(keyword) || x.Value.ToString().ToLower().Contains(keyword) || x.Bar.ToString().ToLower().Contains(keyword) || x.Foo.ToString().ToLower().Contains(keyword)).Count();

            return 0;
        }

        public bool Delete(Guid Id)
        {
            //try
            //{
            //    TestClass ItemToRemove = db.TestClasses.FirstOrDefault(x => x.Id == Id);
            //    if (ItemToRemove == null)
            //    {
            //        return false;
            //    }
            //    return db.TestClasses.Remove(ItemToRemove); ;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
            return false;
        }

        public List<object> GetList(string query)
        {
            List<object> list = DB.ExcecuteQuery(query);
            return list.ToList();
        }

    }
}