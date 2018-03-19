
using System;
using System.Data;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Session_Normale
{
    static class Program
    {
        static MySqlConnection con;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Connexion();
            Application.Run(new Figure());
        }
        static void Connexion()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Database=geometrie;user=root;host=localhost;password=;";
            con.Open();
            MessageBox.Show("Connexion Réussie");
        }
        static void Afficher_Rectangle()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Figure", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {

            }
        }
        static void Enregistrer_Rectangle()
        {

        }
        static void Modifier_Rectangle()
        {

        }
        static void Supprimer_Rectangle()
        {

        }
    }
}
