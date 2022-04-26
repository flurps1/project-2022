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
            PcNum.Clear();
            cab.SelectedIndex = -1;
            type_prob.SelectedIndex = -1;
            richbox1.Document.Blocks.Clear();
        }

        private void richbox1_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void richbox1_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void richbox1_GotFocus(object sender, RoutedEventArgs e)
        {
            string RichBoxText = new TextRange(richbox1.Document.ContentStart, richbox1.Document.ContentEnd).Text;
            Match match = Regex.Match(RichBoxText, "^[Опишите проблему...]");

            if (match.Success)
                richbox1.Document.Blocks.Clear();

        }

        private void richbox1_LostFocus(object sender, RoutedEventArgs e)
        {
            string RichBoxText = new TextRange(richbox1.Document.ContentStart, richbox1.Document.ContentEnd).Text;
            if (string.IsNullOrWhiteSpace(RichBoxText))
            {
                FlowDocument document = new FlowDocument();
                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(new Run("Опишите проблему..."));
                document.Blocks.Add(paragraph);
                richbox1.Document = document;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string pc = PcNum.Text;
            string opisanie = new TextRange(richbox1.Document.ContentStart, richbox1.Document.ContentEnd).Text;
            string prob = type_prob.Text;
            string cabinet = cab.Text;
            string status = "Не принят";


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `requests` (`Pc_num`, `Opisanie`, `Problem`, `cabinet`, `status`) VALUES(@num, @opisanie, @prob, @cab, @status)", db.GetConnection());
            command.Parameters.Add("@num", MySqlDbType.VarChar ).Value= pc;
            command.Parameters.Add("@opisanie", MySqlDbType.VarChar ).Value= opisanie;
            command.Parameters.Add("@prob", MySqlDbType.VarChar ).Value= prob;
            command.Parameters.Add("@cab", MySqlDbType.VarChar ).Value= cabinet;
            command.Parameters.Add("@status", MySqlDbType.VarChar ).Value= status;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись успешно создана!");
            else
                MessageBox.Show("что то пошло не так!");
            db.closeConnection(); 

        }

        private void PcNum_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void PcNum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = "0123456789".IndexOf(e.Text) < 0;//только цифры
            ctrl.MaxLength = 2;//длина текста в текстбоксе
        }
    }
}
