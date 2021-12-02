using GestionStock.Controller;
using GestionStock.Data;
using GestionStock.Data.Services;
using GestionStock.Pages;
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

namespace GestionStock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFormSelect(object sender, RoutedEventArgs e)
        {
            var _context = new MyDbContext();
            FormSelect select = new();
            string senderValue = (string)((Button)sender).Content;
            select.libellePage.Content = senderValue;
            switch (senderValue)
            {
                case "Gestion des Articles":
                    var _serviceArticles = new ArticlesServices(_context);
                    select.DgArticles.ItemsSource = _serviceArticles.GetAllArticles();
                    break;
                case "Gestion des Categories":
                    var _serviceCategory = new CategoryServices(_context);
                    select.DgArticles.ItemsSource = _serviceCategory.GetAllCategory();
                    break;
                case "Gestion des Types Produits":
                    var _serviceTypesProduit = new TypesProduitServices(_context);
                    select.DgArticles.ItemsSource = _serviceTypesProduit.GetAllTypesProduit();
                    break;
            }
            select.Show();
        }
    }
}