using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;

namespace Movies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Movie_Title_Big.Content = "";
            Title_Label.Content = "";
            Genre_Title.Content = "";
            Release_Title.Content = "";
            Sold_Title.Content = "";
            Description_Content.Text = "";

            
        }

        private void FightClub_Selected(object sender, RoutedEventArgs e)
        {
            
                string sConnection;
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=C:\Users\Daniel\Documents\Visual Studio 2015\Projects\Movies Database\Movies\bin\Debug\movie_database.accdb";
                OleDbConnection dbConn;
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                string sql;
                sql = "SELECT * FROM Movie WHERE ID=1;";
                OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
                OleDbDataReader DR = dbCmd.ExecuteReader();
                
                while (DR.Read())
                {
                    Title_Label.Content = DR["Title"];
                    Movie_Title_Big.Content = DR["Title"];
                    Rating.Content = DR["Rating"];
                    Release_Title.Content = DR["ReleaseDate"];
                    Genre_Title.Content = DR["Genre"];
                    Sold_Title.Content = "$" + DR["Sold"];
                    Description_Content.Text = DR["Description"].ToString();

                    Uri uri = new Uri(DR["PicturePath"].ToString(),
                    UriKind.Absolute);
                    BitmapImage bmi = new BitmapImage(uri);
                    
                    Image_Here.Source = bmi;
                }
                dbConn.Close();
            

            
        }

        private void ForrestGump_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=2;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }

        private void PulpFiction_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=3;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }

        private void Inception_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=4;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }

        private void Prestige_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=5;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }

        private void Island_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=6;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }

        private void Basterds_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=7;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }

        private void Departed_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=8;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }

        private void Suspects_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=9;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }

        private void Redemption_Selected(object sender, RoutedEventArgs e)
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            OleDbConnection dbConn;
            dbConn = new OleDbConnection(sConnection);
            dbConn.Open();

            string sql;
            sql = "SELECT * FROM Movie WHERE ID=10;";
            OleDbCommand dbCmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader DR = dbCmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();

                Uri uri = new Uri(DR["PicturePath"].ToString(),
            UriKind.Absolute);
                BitmapImage bmi = new BitmapImage(uri);

                Image_Here.Source = bmi;
            }
            dbConn.Close();
        }
    }
}
