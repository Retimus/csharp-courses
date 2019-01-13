using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Enums;
using System.Collections.Generic;
using System;

namespace WindowsFormsApp1
{
    public partial class EmployeeGrid : Form
    {
        List<Employee> _employeeList = new List<Employee>();

        public EmployeeGrid()
        {
            InitializeComponent();
        }

        internal EmployeeGrid(Employee employee)
        {
            InitializeComponent();
            _employeeList.Add(employee);
            SetDataIntoGrid(_employeeList);
        }

        private DataTable GenerateTable(List<Employee> employeeList)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Surname", typeof(string));
            dataTable.Columns.Add("Birthday", typeof(string));
            dataTable.Columns.Add("SSN", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Country", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("Street", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(string));
            dataTable.Columns.Add("Full Address", typeof(string));

            foreach (var employee in employeeList)
            {
                dataTable.Rows.Add(
                employee.CommonInfo.Name,
                employee.CommonInfo.Surname,
                employee.CommonInfo.Birthday,
                employee.CommonInfo.Ssn,
                employee.CommonInfo.Gender,
                employee.ContactInfo.Email,
                employee.ContactInfo.Phone
                );
            }

            return dataTable;
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            //TODO: Implement Save functionality      
        }

        private void btnGetFromDatabase_Click(object sender, EventArgs e)
        {
            var employee = DataBase.GetDataFromDatabase();
            SetDataIntoGrid(employee);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                MessageBox.Show("Please enter search criteria");
            }
            else
            {
                //TODO: Implement Search functionality    
            }
        }

        private void SetDataIntoGrid(List<Employee> employeeList)
        {
            dgwEmployee.DataSource = null;
            dgwEmployee.Refresh();
            dgwEmployee.DataSource = GenerateTable(employeeList);
        }       
    }
}
