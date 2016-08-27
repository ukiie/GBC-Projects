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
using System.Data;
using System.Data.OleDb;

namespace Movies
{
    /// <summary>
    /// Author: Roman Garasymovych
    /// ID: 100940045
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Link;
        OleDbConnection con;
        List<string> list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            MovieList.SelectedIndex = 0;
            Movie_Title_Big.Content = "";
            Title_Label.Content = "";
            Genre_Title.Content = "";
            Release_Title.Content = "";
            Sold_Title.Content = "";
            Description_Content.Text = "";

            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";

            FillBox();

            MovieList.SelectedIndex = 0;
        }
        public void FillBox()
        {
            //Fill it with new info
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Movie;";
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            MovieList.ItemsSource = ds.AsDataView();
            MovieList.DisplayMemberPath = ds.Columns[1].ToString();
             
        }
        public void FillSearch(string inValue) 
        {
            //Fill it with new info
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            string sql ;
            sql = string.Format("SELECT * FROM Movie WHERE Title LIKE '%" + inValue + "%';");
            cmd.CommandText = sql;
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            MovieList.ItemsSource = ds.AsDataView();
            MovieList.DisplayMemberPath = ds.Columns[1].ToString();
        }
        private void Trailer_Link_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Link);
            }
            catch {
                MessageBox.Show("Couldn't Open");
            }
        }

        private void GetLink(string link) 
        {
            Link = link;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            PromptAdmin pa = new PromptAdmin();
            pa.Show();

        }

        private void MovieList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            int index = 0;
            index = MovieList.SelectedIndex + 1;
            string sql = String.Format("SELECT * FROM Movie WHERE ID={0};", index);
            cmd.CommandText = sql;
            OleDbDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                Title_Label.Content = DR["Title"];
                Movie_Title_Big.Content = DR["Title"];
                Rating.Content = DR["Rating"];
                Release_Title.Content = DR["ReleaseDate"];
                Genre_Title.Content = DR["Genre"];
                Sold_Title.Content = "$" + DR["Sold"];
                Description_Content.Text = DR["Description"].ToString();
                try
                {
                    GetLink(DR["Trailer"].ToString());
                }
                catch
                {
                    GetLink("http://niceme.me");
                }
                try
                {
                    Uri uri = new Uri(DR["PicturePath"].ToString(),
                UriKind.Absolute);
                    BitmapImage bmi = new BitmapImage(uri);

                    Image_Here.Source = bmi;
                }
                catch
                {
                    Uri uri = new Uri("C:/Users/roman/Documents/gbc/LabTest4/Movies/Movies/default.jpg", UriKind.Absolute);
                    BitmapImage def = new BitmapImage(uri);
                    Image_Here.Source = def;
                }
            }
            con.Close();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            MovieList.Items.Refresh();
            FillBox();
            MovieList.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text.Trim()) == false)
            {
                FillSearch(txtSearch.Text.Trim());
            }
            else if (txtSearch.Text.Trim() == "")
            {
                FillBox();
            }
        }
    }
}
