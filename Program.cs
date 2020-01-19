using System;
using System.Data;

namespace datatab
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating DataTable
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("StudentID", typeof(int));
            dt.Columns.Add("StudentName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Semester", typeof(string));
            dt.Columns.Add("DateofBirth", typeof(DateTime));
            dt.Columns.Add("GPA", typeof(double));
            object[] obj = { "0001", "Sonam", "White", "Third", "12/12/2001", "3.0" };
            object[] obj1 = { "0002", "Kay", "Robinson", "Fourth", "11/12/2002", "4.0" };
            object[] obj2 = { "0003", "Ray", "Smith", "Fifth", "12/12/2001", "3.4" };
            dt.Rows.Add(obj);
            dt.Rows.Add(obj1);
            dt.Rows.Add(obj2);

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    Console.WriteLine(column.ColumnName + "\t" + row[column]);

                }
            }
            Console.ReadLine();
        }
    }
}
          
