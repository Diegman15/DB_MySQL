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
using DB_CRUD.Mercado;
using SQLite;

namespace DB_CRUD
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        List<Traspasos> jugador;
        public Principal()
        {
            InitializeComponent();
            jugador = new List<Traspasos>();
            LeerBaseDatos();
        }
        void LeerBaseDatos()
        {
            using (SQLite.SQLiteConnection conn =
               new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Traspasos>();
                jugador = (conn.Table<Traspasos>().ToList()).
                    OrderBy(c => c.Jugador).ToList();
            }
            if (jugador != null)
            {
                lvJugadores.ItemsSource = jugador;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DB_CRUD.MainWindow form = new DB_CRUD.MainWindow();
            form.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DB_CRUD.Eliminar form = new DB_CRUD.Eliminar();
            form.ShowDialog();
        }
    }
}
