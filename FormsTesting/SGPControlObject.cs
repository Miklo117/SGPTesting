using FormsTesting.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsTesting
{
    public class SGPControlObject : SGPControlLibrary.IDataAccessObject
    {
        DatabaseConnector DB = new DatabaseConnector();


        public List<string> DefineColumns(object Model)
        {
            List<string> properties = Model.GetType().GetProperties().Select(x => x.Name).ToList();
            return properties;
        }

        public bool Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetList(string query)
        {
            List<object> list = DB.ExcecuteQuery(query);
            
            return list.ToList();
        }

        public int GetTotalCount(string query)
        {
            int count = DB.ExcecuteCountQuery(query);
            return count;
        }
    }
}
