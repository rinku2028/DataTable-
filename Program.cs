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





           /*
            Creating DataTable
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Custid");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("AcctNum", typeof(int));
            dt.Columns.Add("Balance", typeof(double));
            dt.Columns.Add("AcctOpenDate", typeof(DateTime));
            string[] str = { "001", "Ramku", "Maharjan", "323323", "323.22", DateTime.Now.ToString("MM/dd/yyyy") };
            string[] str1 = { "002", "Reena", "Sharma", "33243", "3243.33", DateTime.Now.ToString("MM/dd/yyyy") };
            dt.Rows.Add(str);
            dt.Rows.Add(str1);

            Console.WriteLine(dt.Columns[0] + "\t" + dt.Columns[1] + "\t" + dt.Columns[2] + "\t" + dt.Columns[3]+"\t"+dt.Columns[4]+"\t"+dt.Columns[5]);
            Console.WriteLine(dt.Rows[0].ItemArray[0].ToString() + "\t" + dt.Rows[0].ItemArray[1].ToString() + "\t" + dt.Rows[0].ItemArray[2].ToString()
                + "\t" + dt.Rows[0].ItemArray[3].ToString() + "\t" + dt.Rows[0].ItemArray[4].ToString() + "\t" + dt.Rows[0].ItemArray[5].ToString());
            Console.WriteLine(dt.Rows[1].ItemArray[0].ToString() + "\t" + dt.Rows[1].ItemArray[1].ToString() + "\t" + dt.Rows[1].ItemArray[2].ToString()
               + "\t" + dt.Rows[1].ItemArray[3].ToString() + "\t" + dt.Rows[1].ItemArray[4].ToString() + "\t" + dt.Rows[1].ItemArray[5].ToString());

            Console.ReadLine();

    */