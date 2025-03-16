using System;
using System.Linq;
using System.Windows.Forms;
using EmployeeManagementSystem.UI.Data;
using EmployeeManagementSystem.UI.Models;

namespace EmployeeManagementSystem.UI;

public partial class Form1 : Form
{
    private readonly EmployeeDbContext _context;
    
    public Form1()
    {
        InitializeComponent();
        _context = new EmployeeDbContext();
        _context.Database.EnsureCreated();
        LoadEmployees();
    }

    private void LoadEmployees()
    {
        dataGridView1.DataSource = _context.Employees.ToList();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            var employee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                HireDate = dtpHireDate.Value,
                Department = txtDepartment.Text,
                Salary = decimal.Parse(txtSalary.Text)
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
            LoadEmployees();
            ClearFields();
            MessageBox.Show("Employee added successfully!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].DataBoundItem is Employee employee)
        {
            try
            {
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.Email = txtEmail.Text;
                employee.PhoneNumber = txtPhone.Text;
                employee.DateOfBirth = dtpDateOfBirth.Value;
                employee.HireDate = dtpHireDate.Value;
                employee.Department = txtDepartment.Text;
                employee.Salary = decimal.Parse(txtSalary.Text);

                _context.SaveChanges();
                LoadEmployees();
                ClearFields();
                MessageBox.Show("Employee updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].DataBoundItem is Employee employee)
        {
            if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                LoadEmployees();
                ClearFields();
                MessageBox.Show("Employee deleted successfully!");
            }
        }
    }

    private void ClearFields()
    {
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtPhone.Text = string.Empty;
        dtpDateOfBirth.Value = DateTime.Now;
        dtpHireDate.Value = DateTime.Now;
        txtDepartment.Text = string.Empty;
        txtSalary.Text = string.Empty;
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].DataBoundItem is Employee employee)
        {
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtEmail.Text = employee.Email;
            txtPhone.Text = employee.PhoneNumber;
            dtpDateOfBirth.Value = employee.DateOfBirth;
            dtpHireDate.Value = employee.HireDate;
            txtDepartment.Text = employee.Department;
            txtSalary.Text = employee.Salary.ToString();
        }
    }
}
