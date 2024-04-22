using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace schoolManagementSystem
{
    public partial class Form1 : Form
    {
        // connection string
        private const String connectionString = "server=kypc\\SQLEXPRESS;database=SCHOOLMANAGEMENT;integrated security=true;";

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            CreateAdminUser();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            UpdateTimeLabel();
        }

        // Method to create admin user
        private void CreateAdminUser()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Admin", connection);
                    cmd.Parameters.AddWithValue("@Admin", "admin");
                    int count = (int)cmd.ExecuteScalar();

                    // if admin  doesn't exist, create new admin
                    if (count == 0)
                    {
                        
                        string randomPassword = Guid.NewGuid().ToString().Substring(0, 8); 
                        cmd = new SqlCommand("INSERT INTO Users (id, Username, Password) VALUES (1, @Username, @Password)", connection);
                        cmd.Parameters.AddWithValue("@Username", "admin");
                        cmd.Parameters.AddWithValue("@Password", randomPassword);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Admin user created.");
                    }
                    Console.WriteLine();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the time label every second
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            // Update the label text with the current local time
            labelTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                
                        // Check if the entered credentials match the admin credentials
                        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password", connection);
                        cmd.Parameters.AddWithValue("@Username", usernameBox.Text); // Use parameter for username
                        cmd.Parameters.AddWithValue("@Password", passwordBox.Text);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // If credentials are correct, navigate to AdminDashboardForm
                            AdminDashboardForm adminDashboard = new AdminDashboardForm();
                            this.Hide(); // Hide the current form
                            adminDashboard.ShowDialog(); // Show the AdminDashboardForm
                            this.Close(); // Close the current form after the AdminDashboardForm is closed
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
