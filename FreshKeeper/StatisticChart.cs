using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace FreshKeeper
{
    public partial class StatisticChart : Form
    {
        public StatisticChart()
        {
            InitializeComponent();
            LoadBarChart();
        }

        private void LoadBarChart()
        {
            // Clear old data
            consumptionChart.Series.Clear();
            consumptionChart.ChartAreas.Clear();
            consumptionChart.ChartAreas.Add(new ChartArea("MainArea"));

            // Create a bar chart data series to display the consumption quantity
            Series quantitySeries = new Series("Quantity")
            {
                ChartType = SeriesChartType.Bar,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
                IsXValueIndexed = true,
                ChartArea = "MainArea"
            };

            // Create a bar chart data series to display the consumption amount
            Series amountSeries = new Series("Amount Spent")
            {
                ChartType = SeriesChartType.Bar,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                IsXValueIndexed = true,
                ChartArea = "MainArea"
            };

            // Query the database for all consumption data belonging to the user
            string query = "SELECT item_name, con_quantity, amount_spent FROM consumption WHERE user_id = @userId";
            var results = DatabaseManager.Instance.ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
            });

            if (results == null || results.Count == 0)
            {
                MessageBox.Show("No consumption data found for the specified user.");
                return;
            }

            // Fill the query results into the Bar Chart
            foreach (var row in results)
            {
                string itemName = row["item_name"].ToString();
                int quantity = Convert.ToInt32(row["con_quantity"]);
                decimal amountSpent = Convert.ToDecimal(row["amount_spent"]);

                Console.WriteLine($"Adding Item: {itemName}, Quantity: {quantity}, Amount Spent: {amountSpent}");

                // Add quantity and amount to two data series respectively
                quantitySeries.Points.AddXY(itemName, quantity);
                amountSeries.Points.AddXY(itemName, (double)amountSpent);
            }

            // Add the data series to the chart
            consumptionChart.Series.Add(quantitySeries);
            consumptionChart.Series.Add(amountSeries);

            // Set the bar chart appearance
            consumptionChart.ChartAreas["MainArea"].AxisX.Title = "Item Name";
            consumptionChart.ChartAreas["MainArea"].AxisY.Title = "Value";
            consumptionChart.ChartAreas["MainArea"].AxisX.Interval = 1;
            consumptionChart.ChartAreas["MainArea"].AxisX.LabelStyle.Angle = -45;
        }

        private void StatisticChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool personalPageFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is PersonalPage personalPageForm)
                {
                    
                    personalPageForm.Show();
                    personalPageForm.BringToFront(); 
                    personalPageFormFound = true;
                    break;
                }
            }

            if (!personalPageFormFound)
            {
                
                PersonalPage personalPageForm = new PersonalPage();
                personalPageForm.Show();
            }
        }

    }
}
