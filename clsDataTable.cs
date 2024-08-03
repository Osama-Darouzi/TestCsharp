using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_C_
{
        internal class clsDataTable
    {
        public DataTable EmployeesDT;

        private void Preparation1()
        {
            EmployeesDT = new DataTable("Employees");

            DataColumn ID = new DataColumn("ID",typeof(int));
            ID.Caption = "EmployeeID";
            ID.AutoIncrement = true;
            ID.AutoIncrementSeed = 1;
            ID.AutoIncrementStep = 1;
            ID.ReadOnly = true;
            EmployeesDT.Columns.Add(ID);

            DataColumn[] PKColumns = new DataColumn[1];
            PKColumns[0] = EmployeesDT.Columns["ID"];
            EmployeesDT.PrimaryKey = PKColumns;

            EmployeesDT.Columns.Add("Name", typeof(string));
            EmployeesDT.Columns.Add("Country", typeof(string));
            EmployeesDT.Columns.Add("Salary", typeof(double));
            EmployeesDT.Columns.Add("BirthDate", typeof(DateTime));
            
            EmployeesDT.Rows.Add(null, "Mohammed Abu-Hadhoud", "Jordan", 5000, DateTime.Now);
            EmployeesDT.Rows.Add(null, "OsaDar", "Jordan", 2550.5, DateTime.Now);
            EmployeesDT.Rows.Add(null, "Eyad ElBedh", "Jordan", 539.6, DateTime.Now);
            EmployeesDT.Rows.Add(null, "Lucas air", "UK", 852.1, DateTime.Now);
            EmployeesDT.Rows.Add(null, "Margret", "USA", 5000, DateTime.Now);
        }

        public clsDataTable()
        {
            Preparation1();
        }
    }
}
