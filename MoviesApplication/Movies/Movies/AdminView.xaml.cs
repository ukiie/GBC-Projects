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
using System.Windows.Shapes;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text.RegularExpressions;

namespace Movies
{
    /// <summary>
    /// Admin control window for adding, editing and deleting data
    /// </summary>
    public partial class AdminView : Window
    {
        OleDbConnection con;
        public string ReleaseDate = null;

        public AdminView()
        {
            InitializeComponent();
            con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=movie_database.accdb";
            Admin_FillBox();
            Admin_ID.IsEnabled = true;
            
        }
        private void Admin_FillBox()
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
            Admin_MovieList.ItemsSource = ds.AsDataView();
            Admin_MovieList.DisplayMemberPath = ds.Columns[1].ToString();
        }
        
        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            
            if (Button_Add.Content.ToString() == "Add")
            {
                try
                {
                    OleDbCommand dbCmd = new OleDbCommand();
                    dbCmd.Connection = con;

                    string sql = string.Format("INSERT INTO Movie(ID,Title,Genre,ReleaseDate,Description,Sold,PicturePath,Rating,Trailer) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}');"
                       , Admin_ID.Text, Admin_Title.Text, Admin_Genre.Text, ReleaseDate, Admin_Description.Text, Admin_Sold.Text, Admin_Picture.Text, Admin_Rating.Text, Admin_Trailer.Text);
                    dbCmd.CommandText = sql;
                    dbCmd.ExecuteNonQuery();

                    con.Close();
                    Admin_FillBox();
                    ClearAll();
                    MessageBox.Show("Movie Added");
                }
                catch 
                {
                    MessageBox.Show("ID or Date may be invalid");
                }
            }
            else
            {
                try
                {
                    OleDbCommand dbCmd = new OleDbCommand();
                    dbCmd.Connection = con;
                    string sql = string.Format("UPDATE Movie SET Title='{0}',Genre='{1}',ReleaseDate='{2}',Description='{3}',Sold='{4}',PicturePath='{5}',Rating='{6}',Trailer='{7}',ID={8} WHERE ID={9};",
                        Admin_Title.Text, Admin_Genre.Text, ReleaseDate, Admin_Description.Text, Admin_Sold.Text, Admin_Picture.Text, Admin_Rating.Text, Admin_Trailer.Text, Admin_ID.Text, Admin_ID.Text);
                    dbCmd.CommandText = sql;
                    dbCmd.ExecuteNonQuery();
                    Admin_FillBox();
                    ClearAll();
                    MessageBox.Show("Entree Updated");
                }
                catch
                {
                    MessageBox.Show("Check the ID");
                }
            }
            
        }

        private void Buton_Delete_Click(object sender, RoutedEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;

            DataRowView row = (DataRowView)Admin_MovieList.SelectedItems[0];

            cmd.CommandText = "delete from Movie where ID=" + row["ID"].ToString();
            cmd.ExecuteNonQuery();
            Admin_FillBox();
            ClearAll();
            MessageBox.Show("Entree Deleted");
                
        }

        private void Button_Refresh_Click(object sender, RoutedEventArgs e)
        {
            Admin_MovieList.Items.Refresh();
            ClearAll();

        }
        private void ClearAll()
        {
            Admin_Title.Text = "";
            Admin_Genre.Text = "";
            Admin_Sold.Text = "";
            Admin_ReleaseDate.Text = "";
            Admin_Description.Text = "";
            Admin_Rating.Text = "";
            Admin_ID.Text = "";
            Admin_Picture.Text = "";
            Admin_Trailer.Text = "";
            Button_Add.Content = "Add";
            Admin_MovieList.SelectedIndex = -1;
        }
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            
            if (Admin_MovieList.SelectedItems.Count > 0)
            {
                DataRowView row = (DataRowView)Admin_MovieList.SelectedItems[0];
                Admin_Title.Text = row["Title"].ToString();
                Admin_Genre.Text = row["Genre"].ToString();
                Admin_Sold.Text = row["Sold"].ToString();
                Admin_ReleaseDate.Text = row["ReleaseDate"].ToString();
                Admin_Description.Text = row["Description"].ToString();
                Admin_Rating.Text = row["Rating"].ToString();
                Admin_ID.Text = row["ID"].ToString();
                Admin_Picture.Text = row["PicturePath"].ToString();
                Admin_Trailer.Text = row["Trailer"].ToString();
                Button_Add.Content = "Update";
            }
            else
            {
                MessageBox.Show("Please Select Any Movie From List...");
            }
        }

        private void Admin_ID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Admin_ID.Text.All(Char.IsNumber) == true)
            {
                Button_Add.IsEnabled = true;
                Admin_ID.BorderBrush = Brushes.LightBlue;
                Admin_ID.BorderThickness = new Thickness(1);
            }
            else if (Admin_ID.Text == "")
            {
                Button_Add.IsEnabled = false;
                Admin_ID.BorderBrush = Brushes.Red;
                Admin_ID.BorderThickness = new Thickness(2);
            }
            else {
                if (Button_Add != null)
                {
                    Button_Add.IsEnabled = false;
                    Admin_ID.BorderBrush = Brushes.Red;
                    Admin_ID.BorderThickness = new Thickness(2);
                }
           }
        }

        private void Admin_Sold_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Rating_Val(Admin_Sold.Text.Trim()) == true)
            {
                if (Button_Add != null)
                {
                    Button_Add.IsEnabled = true;
                    Admin_Sold.BorderBrush = Brushes.LightBlue;
                    Admin_Sold.BorderThickness = new Thickness(1);
                }
            }
            else if (Admin_Sold.Text == "")
            {
                Button_Add.IsEnabled = false;
                Admin_Sold.BorderBrush = Brushes.Red;
                Admin_Sold.BorderThickness = new Thickness(2);
            }
            else
            {
                if (Button_Add != null)
                {
                    Button_Add.IsEnabled = false;
                    Admin_Sold.BorderBrush = Brushes.Red;
                    Admin_Sold.BorderThickness = new Thickness(2);
                }
            }
        }

        private void Admin_Rating_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Rating_Val(Admin_Rating.Text.Trim()) == true)
            {
                if (Button_Add != null)
                {
                    Button_Add.IsEnabled = true;
                    Admin_Rating.BorderBrush = Brushes.LightBlue;
                    Admin_Rating.BorderThickness = new Thickness(1);
                }
            }
            else if (Admin_Rating.Text == "")
            {
                Button_Add.IsEnabled = false;
                Admin_Rating.BorderBrush = Brushes.Red;
                Admin_Rating.BorderThickness = new Thickness(2);
            }
            else
            {
                if (Button_Add != null)
                {
                    Button_Add.IsEnabled = false;
                    Admin_Rating.BorderBrush = Brushes.Red;
                    Admin_Rating.BorderThickness = new Thickness(2);
                }
            }
        }
        private bool Rating_Val(string inValue)
        {
            if (Regex.IsMatch(inValue, @"^[0-9]") == true)
            {
                return true;
            }
            else if (Regex.IsMatch(inValue, @"^[a-zA-Z]+$"))
            
                return false;
            return false;
            
        }
        private void Admin_Title_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Admin_Title.Text.All(Char.IsLetter) == true)
            {
                Button_Add.IsEnabled = true;
                Admin_Title.BorderBrush = Brushes.LightBlue;
                Admin_Title.BorderThickness = new Thickness(1);
            }
            else if (Admin_Title.Text == null)
            {
                Button_Add.IsEnabled = false;
                Admin_Title.BorderBrush = Brushes.Red;
                Admin_Title.BorderThickness = new Thickness(2);
            }
            else
            {
                if (Button_Add != null)
                {
                    Button_Add.IsEnabled = false;
                    Admin_Title.BorderBrush = Brushes.Red;
                    Admin_Title.BorderThickness = new Thickness(2);
                }
            }
        }

        private void Admin_Genre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Admin_Genre.Text.All(Char.IsLetter) == true)
            {
                Button_Add.IsEnabled = true;
                Admin_Genre.BorderBrush = Brushes.LightBlue;
                Admin_Genre.BorderThickness = new Thickness(1);
            }
            else if (String.IsNullOrEmpty(Admin_Genre.Text) == true)
            {
                Button_Add.IsEnabled = false;
                Admin_Genre.BorderBrush = Brushes.Red;
                Admin_Genre.BorderThickness = new Thickness(2);
            }
            else
            {
                if (Button_Add != null)
                {
                    Button_Add.IsEnabled = false;
                    Admin_Genre.BorderBrush = Brushes.Red;
                    Admin_Genre.BorderThickness = new Thickness(2);
                }
            }
        }

        private void Button_Browse_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF Files: (*.GIF)|*.GIF|TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|PNG Files: (*.PNG)|*.PNG";
            dialog.InitialDirectory = @"Pictues";
            dialog.Title = "Please select an image file.";
            
            if (dialog.ShowDialog() == true)
            {
                Admin_Picture.Text = string.Format("{0}", dialog.FileName);
            }
            else
            {
                Admin_Picture.Text = null;
            }
        }

        private void Admin_Trailer_TextChanged(object sender, TextChangedEventArgs e)
        {
            /*
            Uri uriResult;
            bool result = Uri.TryCreate(Admin_Trailer.Text, UriKind.Absolute, out uriResult)
                && uriResult.Scheme == Uri.UriSchemeHttp;
             */
        }

        private void Admin_ReleaseDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get DatePicker reference.
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            
            if (date == null)
            {
                // ... A null object.
                this.ReleaseDate = "1999-01-01";
            }
            else
            {
                // ... No need to display the time.
                this.ReleaseDate = date.Value.ToShortDateString();
            }
        }

        
    }
}
