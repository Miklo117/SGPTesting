using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsTesting
{
    public class TestClass : SGPControlLibrary.IDataAccessObject
    {
        public Guid Id { get; set; }
        public int Number{ get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Bar { get; set; }
        public int Foo { get; set; }
        private Database db { get; set; }


        public List<object> GetList()
        {
            List<object> list = db.TestClasses.Cast<object>().ToList();
            return list;
        }

        public int GetTotalCount(string keyword)
        {
            keyword = keyword.ToLower();
            int count;
            if (string.IsNullOrWhiteSpace(keyword))
                count = db.TestClasses.Count();
            else
                count = db.TestClasses.Where(x => x.Name.ToLower().Contains(keyword) || x.Value.ToString().ToLower().Contains(keyword) || x.Bar.ToString().ToLower().Contains(keyword) || x.Foo.ToString().ToLower().Contains(keyword)).Count();

            return count;
        }
        public List<object> Page(int startRowIndex, int limit, string keyword, Dictionary<string,string> filters, Dictionary<string, string> Sorting)
        {
            keyword = keyword.ToLower();
            List<object> list;
            List<TestClass> tcList;
            if (filters.Count == 0)
            {
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    tcList = db.TestClasses.ToList();
                }
                else
                {
                    tcList = db.TestClasses.Where(x =>
                    x.Name.ToLower().Contains(keyword) ||
                    x.Value.ToString().ToLower().Contains(keyword) ||
                    x.Bar.ToString().ToLower().Contains(keyword) ||
                    x.Foo.ToString().ToLower().Contains(keyword))
                        .ToList();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    tcList = db.TestClasses.ToList();
                }
                else
                {
                    tcList = db.TestClasses.Where(x =>
                    x.Name.ToLower().Contains(keyword) ||
                    x.Value.ToString().ToLower().Contains(keyword) ||
                    x.Bar.ToString().ToLower().Contains(keyword) ||
                    x.Foo.ToString().ToLower().Contains(keyword)).ToList();
                }
                TestClass filterObject = new TestClass();
                foreach (var key in filters.Keys)
                {
                    switch (key)
                    {
                        case "Number":
                            tcList = tcList.Where(x => x.Number.ToString().ToLower().Contains(filters[key])).ToList();
                            break;
                        case "Name":
                            tcList = tcList.Where(x => x.Name.ToString().ToLower().Contains(filters[key])).ToList();
                            break;
                        case "Value":
                            tcList = tcList.Where(x => x.Value.ToString().ToLower().Contains(filters[key])).ToList();
                            break;
                        case "Bar":
                            tcList = tcList.Where(x => x.Bar.ToString().ToLower().Contains(filters[key])).ToList();
                            break;
                        case "Foo":
                            tcList = tcList.Where(x => x.Foo.ToString().ToLower().Contains(filters[key])).ToList();
                            break;
                        default:
                            break;
                    }
                }

            }
            if (Sorting.Count > 0)
            {
                var key = Sorting.Keys.FirstOrDefault();
                switch (key)
                {
                    case "Number":
                        if (Sorting[key] == "ASC")
                        {
                            tcList = tcList.OrderBy(x => x.Number).ToList();
                        }
                        else if (Sorting[key] == "DESC")
                        {
                            tcList = tcList.OrderByDescending(x => x.Number).ToList();
                        }
                        break;
                    case "Name":
                        if (Sorting[key] == "ASC")
                        {
                            tcList = tcList.OrderBy(x => x.Name).ToList();
                        }
                        else if (Sorting[key] == "DESC")
                        {
                            tcList = tcList.OrderByDescending(x => x.Name).ToList();
                        }
                        break;
                    case "Value":
                        if (Sorting[key] == "ASC")
                        {
                            tcList = tcList.OrderBy(x => x.Value).ToList();
                        }
                        else if (Sorting[key] == "DESC")
                        {
                            tcList = tcList.OrderByDescending(x => x.Value).ToList();
                        }
                        break;
                    case "Bar":
                        if (Sorting[key] == "ASC")
                        {
                            tcList = tcList.OrderBy(x => x.Bar).ToList();
                        }
                        else if (Sorting[key] == "DESC")
                        {
                            tcList = tcList.OrderByDescending(x => x.Bar).ToList();
                        }
                        break;
                    case "Foo":
                        if (Sorting[key] == "ASC")
                        {
                            tcList = tcList.OrderBy(x => x.Foo).ToList();
                        }
                        else if (Sorting[key] == "DESC")
                        {
                            tcList = tcList.OrderByDescending(x => x.Foo).ToList();
                        }
                        break;
                    default:
                        break;
                }
            }
                list = tcList.Cast<object>().ToList();
            return list.Skip(startRowIndex).Take(limit).ToList();
        }
        public List<object> Search(string keyword)
        {
            keyword = keyword.ToLower();
            List<object> res = db.TestClasses.Where(x => x.Name.ToLower().Contains(keyword) || x.Value.ToString().ToLower().Contains(keyword) || x.Bar.ToString().ToLower().Contains(keyword) || x.Foo.ToString().ToLower().Contains(keyword)).Cast<object>().ToList();
            return res;
        }

        public List<object> Next()
        {
            throw new NotImplementedException();
        }
        public List<object> Previous()
        {
            throw new NotImplementedException();
        }


        public void InitDb() 
        {
            db = new Database();
        }
    }
}