using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Lista_zakupow
{
    public partial class MainForm : Form
    {
        BazaDanych bazaDanych = new BazaDanych();
        public MainForm()
        {
            InitializeComponent();

            bazaDanych.WyczyszczenieStarej();
            bazaDanych.OtwarciePolaczenia();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(produktBox.Text) && !(string.IsNullOrWhiteSpace(wagaBox.Text)))
            {
                string nazwa = produktBox.Text;
                int waga = int.Parse(wagaBox.Text);

                bazaDanych.DodajProdukt(nazwa, waga);
                AktualizujTabele();
            }
        }

        public void AktualizujTabele()
        {
            listView1.Items.Clear();
            produktBox.Text = null;
            wagaBox.Text = null;
            string connectionString = @"URI=file:baza.db";
            SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
            sQLiteConnection.Open();

            string commandString = "select * from produkty order by nazwa asc";
            SQLiteCommand sQLiteCommand = new SQLiteCommand(commandString, sQLiteConnection);

            SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                string[] row = { sQLiteDataReader.GetString(0), sQLiteDataReader.GetInt32(1).ToString(), sQLiteDataReader.GetValue(2).ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
