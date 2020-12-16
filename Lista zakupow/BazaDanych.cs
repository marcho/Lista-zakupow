using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace Lista_zakupow
{
    class BazaDanych
    {
        public void WyczyszczenieStarej()
        {
            if (File.Exists(@"baza.db"))
            {
                File.Delete(@"baza.db");
            }
        }
        public void OtwarciePolaczenia()
        {
            string connectionString = @"URI=file:baza.db";
            SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
            sQLiteConnection.Open();

            string sql = "create table produkty (nazwa varchar(200), waga int, wagaLacznie string)";
            SQLiteCommand command = new SQLiteCommand(sql, sQLiteConnection);
            command.ExecuteNonQuery();
            sQLiteConnection.Close();
        }

        public void DodajProdukt(string nazwa, int waga)
        {
            string connectionString = @"URI=file:baza.db";
            SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
            sQLiteConnection.Open();

            string sprawdzCzyJest = "select count(nazwa) from produkty where nazwa='" + nazwa + "';";
            SQLiteCommand sprawdzCzyJestCommand = new SQLiteCommand(sprawdzCzyJest, sQLiteConnection);
            string wBazie = sprawdzCzyJestCommand.ExecuteScalar().ToString();
            if (int.Parse(wBazie) > 0)
            {
                string zapytanieWagaObecnegoProduktu = "select waga from produkty where nazwa='" + nazwa + "';";
                SQLiteCommand wagaCommand = new SQLiteCommand(zapytanieWagaObecnegoProduktu, sQLiteConnection);
                string wagaObecnegoProduktu = wagaCommand.ExecuteScalar().ToString();
                int wagaSumaryczna = int.Parse(wagaObecnegoProduktu) + waga;
                string aktualizacjaWagi = "update produkty set waga=" + wagaSumaryczna + " where nazwa='" + nazwa + "';";
                SQLiteCommand aktualizacjawagiCommand = new SQLiteCommand(aktualizacjaWagi, sQLiteConnection);
                aktualizacjawagiCommand.ExecuteNonQuery();

                var wagaNasza = wagaSumaryczna * 1.75;
                string wagaLacznie = "update produkty set wagaLacznie='" + wagaNasza + "' where nazwa='" + nazwa + "';";
                SQLiteCommand dodanieWagaLacznieCommand = new SQLiteCommand(wagaLacznie, sQLiteConnection);
                dodanieWagaLacznieCommand.ExecuteNonQuery();
            }
            else
            {
                string sql = "insert into produkty (nazwa, waga) values ('" + nazwa + "', " + waga + ")";
                SQLiteCommand command = new SQLiteCommand(sql, sQLiteConnection);
                command.ExecuteNonQuery();

                var wagaNasza = waga * 1.75;
                string wagaLacznie = "update produkty set wagaLacznie='" + wagaNasza + "' where nazwa='" + nazwa + "';";
                SQLiteCommand dodanieWagaLacznieCommand = new SQLiteCommand(wagaLacznie, sQLiteConnection);
                dodanieWagaLacznieCommand.ExecuteNonQuery();
            }
            sQLiteConnection.Close();
        }
    }
}
