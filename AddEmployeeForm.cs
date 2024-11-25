using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AISTex
{
    public partial class AddEmployeeForm : Form
    {
        private const string ConnectionString = "Data Source=db.db;Version=3;";

        public AddEmployeeForm()
        {
            InitializeComponent();
            InitializeTableSelector();
            LoadEmployees(); // Удаляем вызовы добавления кнопок
        }

        private void InitializeTableSelector()
        {
            comboBoxTableSelector.Items.Add("Players");
            comboBoxTableSelector.Items.Add("Tournaments");
            comboBoxTableSelector.Items.Add("Results");
            comboBoxTableSelector.SelectedIndex = 0;
            comboBoxTableSelector.SelectedIndexChanged += ComboBoxTableSelector_SelectedIndexChanged;
        }

        private void ComboBoxTableSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string selectedTable = comboBoxTableSelector.SelectedItem.ToString();
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = $"SELECT * FROM {selectedTable}";
                    using (var adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void LoadEmployees()
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //ЗАПРОСЫ
        private void zap1_Click(object sender, EventArgs e)
        {
            ShowHighestRatedTournament();
        }

        private void ShowHighestRatedTournament()
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT T.name, AVG(P.rating) AS average_rating 
                    FROM Tournaments T 
                    JOIN Results R ON T.id = R.tournament_id 
                    JOIN Players P ON R.player_id = P.id 
                    GROUP BY T.id 
                    ORDER BY average_rating DESC 
                    LIMIT 1;";

                    using (var adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable resultsTable = new DataTable();
                        adapter.Fill(resultsTable);
                        dataGridViewResults.DataSource = resultsTable; 
                    }
                }
            }
            finally { }
    }

        private void zap2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT T.name, T.country FROM Tournaments T 
                    JOIN Results R ON T.id = R.tournament_id 
                    JOIN Players P ON R.player_id = P.id 
                    WHERE P.country = T.country 
                    GROUP BY T.id 
                    HAVING COUNT(R.place) = (SELECT COUNT(*) FROM Results WHERE tournament_id = T.id);";

                    using (var adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable resultsTable = new DataTable();
                        adapter.Fill(resultsTable);
                        dataGridViewResults.DataSource = resultsTable;
                    }
                }
            }
            finally { }
        }

        private void zap3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT R.player_id, P.surname, R.place
                    FROM Players P
                    JOIN Results R ON P.id = R.player_id
                    WHERE strftime('%Y', R.date) = '2000'
                    GROUP BY R.player_id
                    ORDER BY R.place ASC
                    LIMIT 3; ";

                    using (var adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable resultsTable = new DataTable();
                        adapter.Fill(resultsTable);
                        dataGridViewResults.DataSource = resultsTable;
                    }
                }
            }
            finally { }
        }

        private void zap4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"SELECT T.name AS TournamentName, P.surname AS PlayerName, P.rank AS PlayerRank, P.rating AS PlayerRating 
                    FROM Tournaments T 
                    JOIN Results R ON T.id = R.tournament_id 
                    JOIN Players P ON R.player_id = P.id 
                    WHERE R.place = (SELECT MAX(place) FROM Results WHERE tournament_id = T.id) 
                    AND P.rating = (SELECT MAX(rating) FROM Players WHERE id IN (SELECT player_id FROM Results WHERE tournament_id = T.id));";

                    using (var adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable resultsTable = new DataTable();
                        adapter.Fill(resultsTable);
                        dataGridViewResults.DataSource = resultsTable;
                    }
                }
            }
            finally { }
        }
    }
}
