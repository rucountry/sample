using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace linq
{
    public class Programm
    {
        private static void Main(string[] args)
        {
            #region Where 1
            /*IEnumerable<int> list = new List<int> { 1, 2, 3 };
            var result = list.Where(t => t > 2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }*/
            #endregion

            #region Where 2
            /*
            IEnumerable<int> list1 = new List<int> { 1, 2, 3 };
            var result1 = list1.Where((t, i) => t > 2 || i == 0);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            #region Select 1
            /*
            IEnumerable<int> list = new List<int> { 1, 2, 3, 4 };
            var result = list.Select(t => t);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region Select 2
            /*
            IEnumerable<int> list = new List<int> { 1, 2, 3, 5 };
            var result = list.Select((t, i) => new { i, t });
            foreach (var item in result)
            {
                Console.WriteLine("{0}-{1}", item.i, item.t);
            }
            */
            #endregion


            #region SelectMany 1
            /*
            IEnumerable<int> list = new List<int> { 11, 22, 33, 44 };
            var result = list.Select(t => t.ToString()).SelectMany(t => t.ToArray());
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region SelectMany 2
            /*
            IEnumerable<int> list = new List<int> { 11, 22, 33, 44 };
            var result = list.Select(t => t.ToString()).SelectMany((t, i) =>
                new List<string> { i.ToString() + "-"+ t.ToArray().Sum(q => Int32.Parse(q.ToString())).ToString() }
            );
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            /*есть еще 2 перегрузки SelectMany через промежуточную коллекцию*/

            #region Take
            /*
            int[] list = { 1, 2, 3, 4, 5 };
            var collection = list.Take(2);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            #region TakeWhile 1
            /*           
            int[] list = { 1, 2, 3, 4, 5 };
            var collection = list.TakeWhile(t => t < 3);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region TakeWhile 2

            //int[] list = { 1, 2, 3, 4, 5 };
            //var collection = list.TakeWhile((t, i) => t < 3 || i == 2);
            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Skip 1
            /*
            int[] list = { 1, 2, 3, 4, 5 };
            var collection = list.Skip(2);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            #region SkipWhile 1
            /*
            int[] list = { 1, 2, 3, 4, 5 };
            var collection = list.SkipWhile(t => t < 3);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region SkipWhile 2
            /*
            int[] list = { 1, 2, 3, 4, 5 };
            var collection = list.SkipWhile((t, i) => t < 3 || i == 2);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            #region Concat
            /*
            int[] list =  { 1, 2, 3, 4, 5 };
            int[] list2 = { 1, 22, 33, 44, 55 };
            var collection = list.Concat(list2);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            #region OrderBy 1
            /*
            int[] list = { 2, 1, 3, 4, 5 };
            var collection = list.OrderBy(t => t);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region OrderBy 2
            /*
            int[] list = { 2, 555, 3, 4, 55 };
            var collection = list.OrderBy(t => t.ToString(), new ComparerOrderBy());
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            #region OrderByDescending 1
            /*
            int[] list = { 2, 1, 3, 4, 5 };
            var collection = list.OrderByDescending(t => t);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region OrderByDescending 2
            /*
            int[] list = { 2, 555, 3, 4, 55 };
            var collection = list.OrderByDescending(t => t.ToString(), new ComparerOrderBy());
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            #region ThenBy 1
            /*
            int[] list = { 2, 555, 3, 4, 55 };
            var collection = list.OrderBy(t => t.ToString(), new ComparerOrderBy()).ThenBy(t => t);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region ThenBy 2
            /*
            int[] list = { 2, 555, 3, 4, 55 };
            var collection = list.OrderBy(t => t.ToString(), new ComparerOrderBy()).ThenBy(t => t, new ComparerThenBy());
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


            #region Join 1
            /*
            int[] list = { 2, 555, 3, 4, 55 };
            int[] list2 = { 21, 555, 31, 41, 55 };
            var collection = list.Join(
                list2,
                o => o,
                i => i,
                (o, i) => new { o = o, i = i }
                );
            foreach (var item in collection)
            {
                Console.WriteLine("{0}-{1}", item.o, item.i);
            }
            */
            #endregion

            #region Join 2
            /*
            int[] list = { 22, 555, 33, 44, 55 };
            int[] list2 = { 21, 555, 31, 41, 55 };
            var collection = list.Join(
                list2,
                o => o,
                i => i,
                (o, i) => new { o = o, i = i },
                new EqualityComparer()
                );
            foreach (var item in collection)
            {
                Console.WriteLine("{0}-{1}", item.o, item.i);
            }
            */
            #endregion


            #region GroupJoin 1
            /*
            int[] list = { 2, 555, 3, 3, 55 };
            int[] list2 = { 21, 555, 55, 41, 55 };
            var collection = list.GroupJoin(
                list2,
                o => o,
                i => i,
                (o, i) => new { o, i });
            foreach (var group in collection)
            {
                Console.WriteLine(group.o);
                foreach (var item in group.i)
                {
                    Console.WriteLine("-----" + item);
                }
            }
            */
            #endregion

            #region GroupJoin 2
            /*
            int[] list = { 27, 555, 37, 3, 55 };
            int[] list2 = { 21, 555, 55, 5, 4 };
            var collection = list.GroupJoin(
                list2,
                o => o,
                i => i,
                (o, i) => new { o, i },
                new EqualityComparer());
            foreach (var group in collection)
            {
                Console.WriteLine(group.o);
                foreach (var item in group.i)
                {
                    Console.WriteLine("-----" + item);
                }
            }
            */
            #endregion


            #region GroupBy 1
            /*
            int[] list = { 2, 555, 3, 2, 555 };
            var collection = list.GroupBy(t => t);
            foreach (var group in collection)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("--------{0}", item);
                }
            }
            */
            #endregion

            #region GroupBy 2
            /*
            int[] list = { 2, 555, 3, 2, 555 };
            var collection = list.GroupBy(t => t, new EqualityComparer());
            foreach (var group in collection)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("--------{0}", item);
                }
            }
            */
            #endregion

            #region GroupBy 3
            /*
            int[] list = { 2, 555, 3, 2, 555 };
            var collection = list.GroupBy(t => t, (t, o) => new { t, o });
            foreach (var group in collection)
            {
                Console.WriteLine(group.t);
                foreach (var item in group.o)
                {
                    Console.WriteLine("--------{0}", item);
                }
            }
            */
            #endregion


            /*Есть другие реализации*/

            #region Distinct1
            /*
            int[] list = { 2, 555, 3, 4, 555 };
            var collection = list.Distinct();
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion

            #region Distinct2
            /*
            int[] list = { 2, 555, 3, 4, 555 };
            var collection = list.Distinct(new EqualityComparer());
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion


            #region Union1
            /*
            int[] list = { 1, 2, 3, 4, 5 };
            int[] list2 = { 1, 22, 33, 44, 55 };
            var collection = list.Union(list2);
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion

            #region Union2
            /*
            int[] list = { 1, 2, 3, 4, 5 };
            int[] list2 = { 1, 22, 33, 44, 55 };
            var collection = list.Union(list2, new EqualityComparer());
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion


            #region Except1
            /*
            int[] list = { 1, 2, 3, 4, 5 };
            int[] list2 = { 1, 22, 33, 44, 55 };
            var collection = list.Except(list2);
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion

            #region Except2
            /*
            int[] list = { 1, 2, 3, 4, 5555 };
            int[] list2 = { 1, 22, 33, 44, 55 };
            var collection = list.Except(list2, new EqualityComparer());
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion


            #region Intersect1
            /*
            int[] list = { 1, 2, 3, 4, 5 };
            int[] list2 = { 1, 22, 33, 44, 55 };
            var collection = list.Intersect(list2);
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion

            #region Intersect2
            /*
            int[] list = { 1, 2, 3, 4, 5668 };
            int[] list2 = { 1, 22, 33, 44, 5555 };
            var collection = list.Intersect(list2, new EqualityComparer());
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion


            #region Cast
            /*
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5668 };
            var collection = list.Cast<int>();
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion


            #region OfType
            /*
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5668 };
            var collection = list.OfType<int>();
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            */
            #endregion


            #region ToArray
            /*
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            
            var collection = list.ToArray();
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine(collection.GetType());
            */
            #endregion


            #region ToList
            /*
            int[] list = { 1, 2, 3, 4, 5 };

            var collection = list.ToList();
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine(collection.GetType());
            */
            #endregion


            #region ToDictionary1
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };

            Dictionary<int, int> collection = listKey.ToDictionary(t => t);
            
            
            
            foreach (var item in collection)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);
            }
            */
            #endregion

            #region ToDictionary2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };

            Dictionary<int, int> collection = listKey.ToDictionary(t => t, new EqualityComparer());

            Console.WriteLine(collection[444]);

            foreach (var item in collection)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);
            }
            */
            #endregion

            #region ToDictionary3
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            int[] listValues = { 1, 2, 3, 4, 5 };



            Dictionary<int, int> collection = listKey.ToDictionary(t => t, i => listValues[Array.IndexOf(listKey, i)]);

           
            foreach (var item in collection)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);
            }
            */
            #endregion

            #region ToDictionary4
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            int[] listValues = { 1, 2, 3, 4, 5 };



            Dictionary<int, int> collection = listKey.ToDictionary(t => t, i => listValues[Array.IndexOf(listKey, i)], new EqualityComparer());

            Console.WriteLine(collection[33]);

            foreach (var item in collection)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);
            }
            */
            #endregion


            #region ToLookup1
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555, 22 };

            ILookup<int, int> collection = listKey.ToLookup(t => t);
            
            
            
            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item.Key);
                foreach (var g in item)
                {
                    Console.WriteLine("-----{0}", g);
                }
            }
            */
            #endregion

            #region ToLookup2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555, 33, 444, 0 };

            ILookup<int, int> collection = listKey.ToLookup(t => t, new EqualityComparer());

            Console.WriteLine(collection[555].First());

            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item.Key);
                foreach (var g in item)
                {
                    Console.WriteLine("-----{0}", g);
                }
            }
            */
            #endregion

            #region ToLookup3
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            int[] listValues = { 1, 2, 3, 4, 5 };



            ILookup<int, int> collection = listKey.ToLookup(t => t, i => listValues[Array.IndexOf(listKey, i)]);


            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item.Key);
                foreach (var g in item)
                {
                    Console.WriteLine("-----{0}", g);
                }
            }
            */
            #endregion

            #region ToLookup4
            /*
            int[] listKey = { 1, 2, 3, 4, 5 };
            int[] listValues = { 0, 21, 331, 4411, 55511 };



            ILookup<int, int> collection = listKey.ToLookup(t => t, i => listValues[Array.IndexOf(listKey, i)], new EqualityComparer());

            Console.WriteLine(collection[6].First());

            foreach (var item in collection)
            {
                Console.WriteLine("{0}", item.Key);
                foreach (var g in item)
                {
                    Console.WriteLine("-----{0}", g);
                }
            }
            */
            #endregion


            #region SequenceEqual1
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            int[] listKey2 = { 55555, 4444, 333, 22, 1 };
            

            bool f = listKey.SequenceEqual(listKey2);

            Console.WriteLine(f);


            f = listKey.SequenceEqual(listKey2.OrderBy(t => t));

            Console.WriteLine(f);
            */
            #endregion

            #region SequenceEqual2
            /*
            int[] listKey = { 1, 22, 333, 4444, 66666 };
            int[] listKey2 = { 5, 44, 333, 5555, 77777 };
            

            bool f = listKey.SequenceEqual(listKey2, new EqualityComparer());

            Console.WriteLine(f);
            */

            #endregion


            #region First1
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.First();
            Console.WriteLine(i);
            */
            #endregion

            #region First2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.First(t => (t % 2 == 0));
            Console.WriteLine(i);
            */
            #endregion


            #region FirstOrDefault1
            /*
            int[] listKey = { };
            var i = listKey.FirstOrDefault();
            Console.WriteLine(i);
            */
            #endregion

            #region FirstOrDefault2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.FirstOrDefault(t => (t > 200000));
            Console.WriteLine(i);
            */
            #endregion


            #region Last1
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.Last();
            Console.WriteLine(i);
            */
            #endregion

            #region Last2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.Last(t => (t % 2 == 0));
            Console.WriteLine(i);
            */
            #endregion


            #region LastOrDefault1
            /*
            int[] listKey = { };
            var i = listKey.LastOrDefault();
            Console.WriteLine(i);
            */
            #endregion

            #region LastOrDefault2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.LastOrDefault(t => (t > 22));
            Console.WriteLine(i);
            */
            #endregion


            #region Single1
            /*
            int[] listKey = { 1 };
            var i = listKey.Single();
            Console.WriteLine(i);
            */
            #endregion

            #region Single2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.Single(t => t == 22);
            Console.WriteLine(i);
            */
            #endregion


            #region SingleOrDefault1
            /*
            int[] listKey = {  };
            var i = listKey.SingleOrDefault();
            Console.WriteLine(i);
            */
            #endregion

            #region SingleOrDefault2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.SingleOrDefault(t => (t > 200000));
            Console.WriteLine(i);
            */
            #endregion


            #region ElementAt
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            var i = listKey.ElementAt(2);
            Console.WriteLine(i);
            */
            #endregion


            #region ElementAtOrDefault1
            /*
            int[] listKey = { };
            var i = listKey.ElementAtOrDefault(1);
            Console.WriteLine(i);
            */
            #endregion


            #region Any
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            bool f = listKey.Any();
            Console.WriteLine(f);

            f = listKey.Any(t => t > 2);
            Console.WriteLine(f);
            */
            #endregion

            #region All
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            bool f = listKey.All(t => t > 0);
            Console.WriteLine(f);

            f = listKey.All(t => t < 55555);
            Console.WriteLine(f);
            */
            #endregion

            #region Contains1
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            bool f = listKey.Contains(22);
            Console.WriteLine(f);

            f = listKey.Contains(8);
            Console.WriteLine(f);
            */
            #endregion

            #region Contains2
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            bool f = listKey.Contains(33,new EqualityComparer());
            Console.WriteLine(f);

            f = listKey.Contains(1,new EqualityComparer());
            Console.WriteLine(f);
            */
            #endregion


            #region Count
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            Console.WriteLine(listKey.Count());
            Console.WriteLine(listKey.Count(t => t < 334));
            */
            #endregion

            #region LongCount
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            Console.WriteLine(listKey.LongCount());
            Console.WriteLine(listKey.LongCount(t => t < 334));
            */
            #endregion

            #region Sum
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            Console.WriteLine(listKey.Sum());
            Console.WriteLine(listKey.Sum(t => t));
            */
            #endregion

            #region Min - Max
            /*
            int[] listKey = { 1, 22, 333, 4444, 55555 };
            Console.WriteLine(listKey.Min());
            Console.WriteLine(listKey.Max());
            */
            #endregion

            #region Average
            /*
            int[] listKey = { 1, 2, 3, 4, 5 };
            Console.WriteLine(listKey.Average());
            */
            #endregion

            #region Aggregate
            /*
            int[] listKey = { 1, 2, 3, 4, 5 };
            Console.WriteLine(listKey.Aggregate((o1, o2) => o1 * o2));
            */
            #endregion



            SampleLinq2Sql.sample2_SetField2();













            System.Console.ReadKey();
        }
    }
    public class ComparerOrderBy : IComparer<string>
    {

        public int Compare(string x, string y)
        {
            if (x.Length > y.Length) return 1;
            else if (x.Length < y.Length) return -1;
            else return 0;
        }
    }
    public class ComparerThenBy : IComparer<int>
    {

        public int Compare(int x, int y)
        {
            if (x.GetHashCode() > y.GetHashCode())
                return 1;
            else if (x != y) return -1;
            else return 0;
        }
    }
    public class EqualityComparer : IEqualityComparer<int>
    {

        public bool Equals(int x, int y)
        {
            if (x.ToString().Length == y.ToString().Length) return true; else return false;
        }

        public int GetHashCode(int obj)
        {
            return obj.ToString().Length.GetHashCode();
        }
    }
    public class LinqToSQL<T>
    {
        public DataTable GetDataTable(IEnumerable<T> list)
        {
            DataTable dt = new DataTable();
            DataColumn column;

            /*Используя рефлексию получим тип - свойства типа и создадим колонки для DataTable*/
            Type typerow = list.First().GetType();

            System.Reflection.PropertyInfo[] properties = typerow.GetProperties();

            /*Создаем схему таблицы*/
            foreach (var pr in properties)
            {
                column = new DataColumn(pr.Name, pr.PropertyType);
                dt.Columns.Add(column);

            }

            int j = 0;
            /*Заполняем таблицу данными*/
            foreach (var item in list)
            {
                DataRow dr = dt.NewRow();

                for (int i = 0; i < properties.Length; i++)
                {
                    dr[i] = properties[i].GetValue(list.ElementAt(j));
                }
                dt.Rows.Add(dr);
                j++;
            }
            dt.AcceptChanges();
            return dt;

        }
        public void PrintDataTable(DataTable dt)
        {
            foreach (DataRow rows in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                    Console.WriteLine("{0}:{1}", column.ColumnName, rows[column]);
            }
        }
    }
    public static class SampleLinq2Sql
    {
        public static void sample1_SetField1()
        {
            Student[] students = {
                new Student { Id=1, Name="Александр Ерохин"},
                new Student { Id=5, Name="Елена Волкова"},
                new Student { Id=9, Name="Дмитрий Моисеенко"},
                new Student { Id=16, Name="Андрей Мухамедшин"}
                                 };

            LinqToSQL<Student> linq2student = new LinqToSQL<Student>();
            DataTable dt = linq2student.GetDataTable(students);
            linq2student.PrintDataTable(dt);
            IEnumerable<DataRow> list = dt.AsEnumerable();
            (from s in list where s.Field<string>("Name") == "Елена Волкова" select s).Single<DataRow>().SetField("Name", "Ольга Ивина");
            linq2student.PrintDataTable(list.CopyToDataTable());

        }
        public static void sample2_SetField2()
        {
            Student[] students = {
                new Student { Id=1, Name="Александр Ерохин"},
                new Student { Id=5, Name="Елена Волкова"},
                new Student { Id=9, Name="Дмитрий Моисеенко"},
                new Student { Id=16, Name="Андрей Мухамедшин"}
                                 };

            LinqToSQL<Student> linq2student = new LinqToSQL<Student>();
            DataTable dt = linq2student.GetDataTable(students);
            DataTable newTable = dt.AsEnumerable().CopyToDataTable();


            foreach (DataRow dr in newTable.AsEnumerable())
            {
                Console.WriteLine("Студент с Id = {0} : исходное {1} : текущее {2}", dr.Field<int>("Id"),
                    dr.Field<string>("Name", DataRowVersion.Original)
                    , dr.Field<string>("Name", DataRowVersion.Current));
            }


            (from s in dt.AsEnumerable()
             where s.Field<string>("Name") == "Елена Волкова"
             select s).Single<DataRow>().SetField("Name", "Alex Erohin");

            dt.AsEnumerable().CopyToDataTable(newTable, LoadOption.Upsert);

            foreach (DataRow dr in newTable.AsEnumerable())
            {
                Console.WriteLine("Студент с Id = {0} : исходное {1} : текущее {2}", dr.Field<int>("Id"),
                    dr.HasVersion(DataRowVersion.Original) ?
                    dr.Field<string>("Name", DataRowVersion.Original) : " не существует"
                    , dr.Field<string>("Name", DataRowVersion.Current));
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
