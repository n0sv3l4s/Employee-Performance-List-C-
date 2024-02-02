using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private DataTable employeeTable;

        public Form1()
        {
            InitializeComponent();
            InitializeEmployeeTable();
            dataGridView1.DataSource = employeeTable;

            txtFirstName.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            txtLastName.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
            txtRating.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
        }

        private void InitializeEmployeeTable()
        {
            employeeTable = new DataTable();
            employeeTable.Columns.Add("First Name");
            employeeTable.Columns.Add("Last Name");
            employeeTable.Columns.Add("Rating", typeof(int));
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the "ding" sound
                AddEmployee();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void AddEmployee()
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string ratingText = txtRating.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(ratingText))
            {
                MessageBox.Show("Missing data. Please enter all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ratingText, out int rating) || rating < 0 || rating > 10)
            {
                MessageBox.Show("Invalid rating. Please enter a rating between 0 and 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employeeTable.Rows.Add(firstName, lastName, rating);
            ClearEmployeeFields();
        }

        private void ClearEmployeeFields()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtRating.Text = string.Empty;
        }

        private void btnBestRating_Click(object sender, EventArgs e)
        {
            if (employeeTable.Rows.Count < 2)
            {
                MessageBox.Show("Not enough employees on the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int maxRating = employeeTable.AsEnumerable().Max(row => row.Field<int>("Rating"));
            var bestEmployees = employeeTable.AsEnumerable().Where(row => row.Field<int>("Rating") == maxRating).Select(row => row.Field<string>("First Name") + " " + row.Field<string>("Last Name"));

            string result = string.Join(", ", bestEmployees);
            MessageBox.Show("Employee(s) with the best rating: " + result, "Best Rating", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWorstRating_Click(object sender, EventArgs e)
        {
            if (employeeTable.Rows.Count < 2)
            {
                MessageBox.Show("Not enough employees on the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int minRating = employeeTable.AsEnumerable().Min(row => row.Field<int>("Rating"));
            var worstEmployees = employeeTable.AsEnumerable().Where(row => row.Field<int>("Rating") == minRating).Select(row => row.Field<string>("First Name") + " " + row.Field<string>("Last Name"));

            string result = string.Join(", ", worstEmployees);
            MessageBox.Show("Employee(s) with the worst rating: " + result, "Worst Rating", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSortByRating_Click(object sender, EventArgs e)
        {
            if (employeeTable.Rows.Count < 2)
            {
                MessageBox.Show("Not enough employees on the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sortedEmployees = employeeTable.AsEnumerable().OrderBy(row => row.Field<int>("Rating")).Select(row => row.Field<string>("First Name") + " " + row.Field<string>("Last Name") + " - Rating: " + row.Field<int>("Rating"));

            string result = string.Join(Environment.NewLine, sortedEmployees);
            MessageBox.Show("Sorted Employees:" + Environment.NewLine + result, "Sorted Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAverageRating_Click(object sender, EventArgs e)
        {
            if (employeeTable.Rows.Count < 2)
            {
                MessageBox.Show("Not enough employees on the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double averageRating = employeeTable.AsEnumerable().Average(row => row.Field<int>("Rating"));
            MessageBox.Show("Average Rating: " + averageRating.ToString("0.00"), "Average Rating", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAboveAverage_Click(object sender, EventArgs e)
        {
            if (employeeTable.Rows.Count < 2)
            {
                MessageBox.Show("Not enough employees on the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double averageRating = employeeTable.AsEnumerable().Average(row => row.Field<int>("Rating"));
            var aboveAverageEmployees = employeeTable.AsEnumerable().Where(row => row.Field<int>("Rating") > averageRating).OrderBy(row => row.Field<int>("Rating")).Select(row => row.Field<string>("First Name") + " " + row.Field<string>("Last Name") + " - Rating: " + row.Field<int>("Rating"));

            string result = string.Join(Environment.NewLine, aboveAverageEmployees);
            MessageBox.Show("Employees with rating above average:" + Environment.NewLine + result, "Above Average Rating", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBelowAverage_Click(object sender, EventArgs e)
        {
            if (employeeTable.Rows.Count < 2)
            {
                MessageBox.Show("Not enough employees on the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double averageRating = employeeTable.AsEnumerable().Average(row => row.Field<int>("Rating"));
            var belowAverageEmployees = employeeTable.AsEnumerable().Where(row => row.Field<int>("Rating") < averageRating).OrderByDescending(row => row.Field<int>("Rating")).Select(row => row.Field<string>("First Name") + " " + row.Field<string>("Last Name") + " - Rating: " + row.Field<int>("Rating"));

            string result = string.Join(Environment.NewLine, belowAverageEmployees);
            MessageBox.Show("Employees with rating below average:" + Environment.NewLine + result, "Below Average Rating", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}