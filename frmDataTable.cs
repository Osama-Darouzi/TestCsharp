using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_C_
{
    public partial class frmDataTable : Form
    {
        public frmDataTable()
        {
            InitializeComponent();
        }

        clsDataTable dt;
        DataView dv = new DataView();

        private static DataTable PutRowsInTable(DataRow[] Rows, DataTable dt)
        {

            DataTable table = new DataTable();
            table = Rows.CopyToDataTable();

            return table;
        }

        private DataTable Aggregate(string Filter = "")
        {
            DataTable Agg = new DataTable();
            Agg.Columns.Add("Count", typeof(int));
            Agg.Columns.Add("Sum", typeof(double));
            Agg.Columns.Add("AVG", typeof(double));
            Agg.Columns.Add("Min", typeof(double));
            Agg.Columns.Add("Max", typeof(double));

            int Count = Convert.ToInt32(dt.EmployeesDT.Compute("Count(ID)", Filter));
            double Sum = Convert.ToDouble(dt.EmployeesDT.Compute("Sum(Salary)", Filter));
            double AVG = Convert.ToDouble(dt.EmployeesDT.Compute("AVG(Salary)", Filter));
            double Min = Convert.ToDouble(dt.EmployeesDT.Compute("Min(Salary)", Filter));
            double Max = Convert.ToDouble(dt.EmployeesDT.Compute("Max(Salary)", Filter));
            Agg.Rows.Add(Count, Sum, AVG, Min, Max);

            return Agg;
        }

        private DataView Filter(string Filter)
        {
            DataView FilterView = dt.EmployeesDT.AsDataView();
            FilterView.RowFilter = Filter;
            return FilterView;
        }

        private DataView Sort(string OrderBy)
        {
            DataView SortView = dt.EmployeesDT.DefaultView;
            SortView.Sort = OrderBy;
            return SortView;
        }

        private void frmDataTable_Load(object sender, EventArgs e)
        {
            dt = new clsDataTable();
            //dgv1.DataSource = Aggregate("Country = 'Jordan'");
            DataRow[] result = dt.EmployeesDT.Select("Id = 4");
            foreach (DataRow row in result)
            {
                row["Name"] = "Osama Darouzi";
                row["Salary"] = 150000;
            }
            dv = Filter("Country = 'USA'");
            dgv1.DataSource = dv;
            //dt.EmployeesDT.Clear();
            


            //dgv1.DataSource = PutRowsInTable(Filter("ID = 1"), dt.EmployeesDT);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            dv = Sort("ID Desc");

            dgv1.DataSource = dv;
        }
    }
}
