using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USOS_Rektora.userControls
{
    public partial class Wydziały : UserControl
    {
        string connectionString = "server=localhost;user id=root;database=rektordb;sslmode=none";
        public Wydziały()
        {
            InitializeComponent();
        }
        public void wyswDanych(string oWydz, List<string> kierunki, string wydz)
        {
            listBoxKierunki.Items.Clear();
            listBoxKierunki.DataSource = kierunki;
            labelOWydziale.Text = oWydz;
            listBoxStud.Items.Clear();
            string query = "SELECT name,surname,specialization FROM students WHERE department=@department";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@department", wydz);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBoxStud.Items.Add(reader["name"] + " " + reader["surname"] + " " + reader["specialization"]);
            }
        }
        private void Wydziały_Load(object sender, EventArgs e)
        {
            List<string> kierunki = new List<string>();
            string oWydz = "";
            string wydzial = Form2.ktoryWydzial;
            switch (wydzial)
            {
                case "Nawigacyjny":
                    oWydz = " Jest najstarszym Wydziałem Uczelni, powstał w 1920 r. razem ze Szkołą Morską w " +
                    "Tczewie. Rozkazem Ministra Spraw Wojskowych gen. porucznika Józefa Leśniewskiego 17 czerwca 1920" +
                    " roku powołano Szkołę Morską w Tczewie z dwoma wydziałami: nawigacyjnym i mechanicznym." +
                    " Dyrektorem Szkoły został Antoni Garnuszewski, a stanowisko inspektora i kierownika wydziału " +
                    "nawigacyjnego powierzono Gustawowi Kańskiemu.\r\r\nPoczątkowo nauka na Wydziale Nawigacyjnym " +
                    "trwała trzy lata. Nawigatorzy w tym czasie odbyć musieli dwudziestodwumie­sięczną praktykę morską" +
                    " na statkach szkolnych – „Lwowie”, a od 1930 roku na „Darze Pomorza”. Po praktyce dyplomowej " +
                    "na ostatnim roku absolwenci otrzymywali dyplom porucznika żeglugi morskiej.\r\r\n" +
                    "Po zakończeniu II wojny światowej reaktywowano Wydział, który w 1947 przeniesiono z Gdyni do " +
                    "Szczecina. Po kilku latach, w sierpniu 1953 roku, Wydział wrócił w struktury gdyńskiej " +
                    "Państwowej Szkoły Morskiej.\r\r";
                    kierunki.Add("Transport i logistyka");
                    kierunki.Add("Transport Morski");
                    wyswDanych(oWydz, kierunki, wydzial);
                    break;
                case "Elektryczny":
                    kierunki.Add("Informatyka");
                    kierunki.Add("Elektrotechnika");
                    kierunki.Add("Elektrotechnika i Telekomunikacja");
                    oWydz = "Początki Wydziału Elektrycznego sięgają roku 1953, kiedy w Technikum Morskim utworzono klasy" +
                    " kształcące młodzież w specjalnościach radiotechnika okrętowa i elektrotechnika okrętowa. " +
                    "Pierwsi kandydaci na ten Wydział rekrutowani byli z Wydziałów Nawigacyjnego i Mechanicznego. " +
                    "Rok szkolny 1954/1955 – to pierwszy rok nauki na nowo powołanym Wydziale Elektrycznym. " +
                    "Po „wypuszczeniu w świat” pierwszej grupy absolwentów: 32 techników elektryków i 32 " +
                    "radiotechników okrętowych, nabór na Wydział Elektryczny został nieoczekiwanie zawieszony." +
                    "\r\r\nW 1960 roku wznowiono rekrutację na Wydział Elektryczny ale tylko na kierunek " +
                    "radiotechniki okrętowej a dopiero po trzech latach otwarto ponownie kierunek elektrotechniki " +
                    "okrętowej. Do roku 1968 na Wydziale Elektrycznym Państwowej Szkoły Morskiej wypromowano 313 " +
                    "oficerów radiotechników oraz 326 oficerów elektryków okrętowych. W 1968 roku Państwowa Szkoła " +
                    "Morska uzyskała status Wyższej Uczelni zawodowej przyjmując nazwę Wyższa Szkoła Morska, " +
                    "a pierwszym dziekanem Wydziału Elektrycznego został doc. dr inż. Eugeniusz Bartosiński.";
                    wyswDanych(oWydz, kierunki, wydzial);
                    break;
                case "Mechaniczny":
                    kierunki.Add("Eksploatacja i diagnostyka systemów technicznych");
                    kierunki.Add("Mechanika i budowa maszyn");
                    oWydz = "W roku 1930 Szkoła Morska została przeniesiona do Gdyni, do nowego gmachu przy ulicy " +
                        "Morskiej 83, gdzie do dzisiaj mieści się jej siedziba. Szkoła Morska w Tczewie, a od wiosny " +
                        "1930 roku Państwowa Szkoła Morska w Gdyni, kształcące oficerów dla Marynarki Handlowej i " +
                        "specjalistów obrotu portowo-morskiego były traktowane jako wyższe uczelnie zawodowe. " +
                        "Potwierdzało ten stan rzeczy rozporządzenie Rady Ministrów RP z dnia 8 listopada 1929 " +
                        "roku (Dz. U. RP nr 88, poz. 633), oraz statuty Państwowej Szkoły Morskiej.\r\r\nW " +
                        "czasie II Wojny Światowej przebywający w Wielkiej Brytanii pracownicy PSM na czele z " +
                        "kpt. ż.w. Konstantym Kowalskim – komendantem „Daru Pomorza” poczynili działania w celu " +
                        "zorganizowania Szkoły Morskiej na terenie Anglii. Już w grudniu 1939 roku rozpoczęto kursy " +
                        "kwalifikacyjne dla oficerów, uczniów PSM i marynarzy najpierw w Southampton, następnie w " +
                        "Londynie. Łącznie według szacunków Jana Kazimierza Sawickiego wykształcono 318 oficerów " +
                        "PMH.\r\r\n11 IV 1945 Departament Morski Ministerstwa Przemysłu upoważnił kpt. ż.w. " +
                        "Konstantego Maciejewicza do przejęcia budynków szkolnych i rozpoczęcia czynności " +
                        "reaktywujących działalność PSM. Rok szkolny rozpoczęto z uwagi na prace remontowe 1 " +
                        "listopada 1945 roku.\r\r\nPowojenne zmiany i modyfikacje statutu uczelni zdegradowały " +
                        "Szkołę w 1951 roku do poziomu technikum, aby po przełomie w 1956 roku systematycznie Szkołę " +
                        "promować do rangi pomaturalnej w 1962 roku. W oparciu o bazę dydaktyczną i doświadczoną kadrę " +
                        "pracowników dydaktycznych 20 sierpnia 1968 roku Rozporządzeniem Rady Ministrów " +
                        "(Dz. U. Nr 34, poz. 230 i 179) przekształcono Państwową Szkołę Morską w Gdyni w " +
                        "Wyższą Szkołę Morską w Gdyni, nadając jej status uczelni wyższej.";
                    wyswDanych(oWydz, kierunki, wydzial);
                    break;
                case "Zarządzania i nauk o jakości":
                    kierunki.Add("Zarządzania");
                    kierunki.Add("Nauk o jakości");
                    oWydz = "Gdy w 1945 roku reaktywowano działalność szkoły, utworzono tylko 2 wydziały. " +
                        "Dopiero w PSM w 1967 roku utworzono Wydział Służby Administracyjnej kształcący " +
                        "intendentów okrętowych. \r\r\nWydział Administracyjny powstał w 1969 roku wraz " +
                        "z powstaniem Wyższej Szkoły Morskiej. Od 1969/1970 można się tu było kształcić " +
                        "w specjalności intendentura okrętowa, zaś od 1977/1978 - intendentura przedsiębiorstw" +
                        " armatorskich i eksploatacji pasażerskiej. Do 1991 Wydział kształcił intendentów " +
                        "okrętowych. W 1991 roku dokonano ostatniego naboru kandydatów na oficerów w działach " +
                        "hotelowych - ze względu na sytuację na rynku pracy. W latach 1993-2000 Wydział " +
                        "przeszedł zmiany w kierunku kształcenia kadr dla gospodarki morskiej i lądowej " +
                        "regionu. W 2005 roku zmienił nazwę na Wydział Przedsiębiorczości i Towaroznawstwa." +
                        " W 2021 roku zmienił nazwę na Wydział Zarządzania i Nauk o Jakości.\r\r\n30 listapada " +
                        "1998 roku, decyzją Centralnej Komisji Kwalifikacyjnej ds. Tytułu Naukowego i " +
                        "Stopni Naukowych Wydział uzyskał prawo nadawania stopnia doktora nauk ekonomicznych " +
                        "w zakresie towaroznawstwa.";
                    wyswDanych(oWydz, kierunki, wydzial);
                    break;
            }
        }
    }
}
