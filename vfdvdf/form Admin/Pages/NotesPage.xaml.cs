using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Admin_project.Pages
{
    /// <summary>
    /// Lógica de interacción para NotesPage.xaml
    /// </summary>
    public partial class NotesPage : Page
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB db = new DB();
                string script = "SELECT * FROM requests where `status` = null";
                db.openConnection();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, db.GetConnection());
                DataTable Table = new DataTable();
                ms_data.Fill(Table);
                dataGrid_history.ItemsSource = Table.DefaultView;
                db.closeConnection();
            }
            catch
            {
                MessageBox.Show("Connect lost");
            }
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            int id = (int)((DataRowView)dataGrid_history.SelectedItem)["id_req"];

            if (id != 0)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM `requests` WHERE Id_req =@id", db.GetConnection());
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
                dataGrid_history.ItemsSource = Table.DefaultView;
                db.closeConnection();
            }
            catch
            {
                MessageBox.Show("Connect lost");
            }
        }
    }
}
