using GestionProduits;
using GestionStock.Controller;
using GestionStock.Data;
using Microsoft.EntityFrameworkCore;
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

namespace GestionStock.Pages
{
    /// <summary>
    /// Logique d'interaction pour FormSelect.xaml
    /// </summary>
    public partial class FormSelectProduit : Window
    {
        public FormSelectProduit()
        {
            InitializeComponent();
            var _context = new MyDbContext();
            var _controllerArticles = new ArticlesController(_context);
            DgArticles.ItemsSource = _controllerArticles.GetAllArticles();
            ObjectHelper.Dump(_controllerArticles.GetAllArticles());
        }
    }
}
