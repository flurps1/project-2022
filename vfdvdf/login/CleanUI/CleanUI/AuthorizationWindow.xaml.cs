using System.Data;
using System.Windows;
using System.Windows.Input;
using UIKitTutorials;
using MySql.Data.MySqlClient;
using Admin_project;

namespace CleanUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();

        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (loginuser.Text == "login")
            {
                loginuser.Text = "";
            }
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (loginuser.Text == "")
            {
                loginuser.Text = "login";
            }
        }

        private void txtPass_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtPass.Password == "Password")
            {
                txtPass.Password = "";
            }
        }

        private void txtPass_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtPass.Password == "")
            {
                txtPass.Password = "Password";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            string loginField = loginuser.Text;
            string passField = txtPass.Password;
            string AdminAccess = "no";

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `Login` = @LoginUser AND `Password` = @PassUser AND `Admin_Access`= @Ac", db.GetConnection());
            command.Parameters.Add("@LoginUser", MySqlDbType.VarChar).Value = loginField;
            command.Parameters.Add("@PassUser", MySqlDbType.VarChar).Value = passField;
            command.Parameters.Add("@Ac", MySqlDbType.VarChar).Value = AdminAccess;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы Успешно вошли");

                MainWindow newWindow = new MainWindow();
                newWindow.Show();
                Close();
            }
            else
                MessageBox.Show("Что то пошло не так! проверьте логин или пароль.");
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string loginField = loginuser.Text;
            string passField = txtPass.Password;
            string AdminAccess = "yes";

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `Login` = @LoginUser AND `Password` = @PassUser AND `Admin_Access`= @Ac", db.GetConnection());
            command.Parameters.Add("@LoginUser", MySqlDbType.VarChar).Value = loginField;
            command.Parameters.Add("@PassUser", MySqlDbType.VarChar).Value = passField;
            command.Parameters.Add("@Ac", MySqlDbType.VarChar).Value = AdminAccess;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Вы Успешно вошли");

                Menu2 newWindow2 = new Menu2();
                newWindow2.Show();
                Close();
            }
            else
                MessageBox.Show("Что то пошло не так! проверьте логин или пароль.");
        }

        private void loginuser_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void loginuser_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtPass_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txtPass_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}

