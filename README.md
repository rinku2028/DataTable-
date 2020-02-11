# DataTable-
DataTable in C#



A DataTable object represents tabular data as an in-memory, tabular cache of rows, columns, and constraints. You typically use the DataTable class to perform any disconnected data access. The DataTable is a central object in the ADO.NET library. Other objects that use the DataTable include the DataSet and the DataView.

DataTable objects are conditionally case-sensitive. For example, if you are using one DataTable named "ObjDataTable" and another one named "objDataTable", a string used to search for one of the tables is regarded as case-sensitive. However, if "ObjDataTable" exists and "objDataTable" does not, the search string is regarded as case-insensitive.

For creating a DataTable you first create an instance of the DataTable class, and then add DataColumn objects that define the type of data to be held and insert DataRow objects that contain the data. The following code demonstrates the creation of a data table:

//Create the DataTable named "Order"
DataTable order = new DataTable ("Order");
