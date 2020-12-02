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

namespace Lista_3
{
    public partial class Window1 : Window
    {
        private string namefield;
        private string surnamefield;
        private string peselfield;
      
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            namefield = Name.Text;
            surnamefield = Surname.Text;
            peselfield = Pesel.Text;
          
            try
            {
                MainWindow.PersonList.Add(new MainWindow.Person() { Name = namefield, Surname = surnamefield, Pesel = peselfield});
            }
            catch (Exception blad)
            {
                MessageBox.Show(blad.Message);
            }
        }
    }
}
