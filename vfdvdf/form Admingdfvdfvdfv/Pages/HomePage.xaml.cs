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
using System.Drawing;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data;

namespace UIKitTutorials.Pages
{

    public partial class HomePage : Page
    {

        public HomePage()
        {
            InitializeComponent();

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void richbox1_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void richbox1_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void richbox1_GotFocus(object sender, RoutedEventArgs e)
        {
           

        }

        private void richbox1_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
               
            
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
      

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                db.openConnection();
                MessageBox.Show("Connect");
                db.closeConnection();
            }
            catch
            {
                MessageBox.Show("Connect lost");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void deleteRow()
        {
           

        }


        private void DtnDel_Click_1(object sender, RoutedEventArgs e)
        {
            string status = "Принято";
            int id = (int)((DataRowView)dataGrid1.SelectedItem)["id_req"];

            if (id != 0)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `requests` SET `status`= @status WHERE Id_req =@id", db.GetConnection());
                command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись обновлена!");
                else
                    MessageBox.Show("что то пошло не так!");
                db.closeConnection();
            }
            else MessageBox.Show("В таблице нет этой записи!");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                string script = "SELECT * FROM requests";
                db.openConnection();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, db.GetConnection());
                DataTable Table = new DataTable();
                ms_data.Fill(Table);
                dataGrid1.ItemsSource = Table.DefaultView;
                db.closeConnection();
            }
            catch
            {
                MessageBox.Show("Connect lost");
            }
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            string status = "Не принято";
            int id = (int)((DataRowView)dataGrid1.SelectedItem)["id_req"];

            if (id != 0)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `requests` SET `status`= @status WHERE Id_req =@id", db.GetConnection());
                command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись обновлена!");
                else
                    MessageBox.Show("что то пошло не так!");
                db.closeConnection();
            }
            else MessageBox.Show("В таблице нет этой записи!");
        }

        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                string script = "SELECT * FROM requests";
                db.openConnection();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, db.GetConnection());
                DataTable Table = new DataTable();
                ms_data.Fill(Table);
                dataGrid1.ItemsSource = Table.DefaultView;
                db.closeConnection();
            }
            catch
            {
                MessageBox.Show("Connect lost");
            }
        }
    }


       
        
    
}
