using System.Data.SqlClient;
using System.Data;

namespace Projekt
{
    public partial class Form1 : Form
    {
        // Private = Kan benyttes inden i alle metoderne i koden, ogs� void
        private int autoID = 1;
        private int autoTwo = 30;
        private string path = @"c:\Jeppe-Leif-Nathalie-Parking\Database.txt";
        private string appendText = "";
        public Form1() //Starter GUI
        {
            InitializeComponent();
            //Gemmer n�ste knappen
            n�steKnap.Enabled = false;
            n�steKnap.Visible = false;
        }
        private void gemKnap_Click(object sender, EventArgs e) //Metode der k�rer n�r jeg trykker p� gem knappen i programmet
        {
            //Laver en mappe hvor jeg kan putte database textfilen ind
            Directory.CreateDirectory(@"c:\Jeppe-Leif-Nathalie-Parking");
            // Hvis ikke der er p�begynt en database, laver denne kode en ny fil p� ovenst�ende destination
            if (!File.Exists(path))
            {
                string[] createText = { "" };
                File.WriteAllLines(path, createText);
            }
            // Tjekker om passwordet er mere eller mindre end 8 cifre
            if (telBox.Text.Length < 8 || telBox.Text.Length > 8)
            {
                MessageBox.Show("Mobilnummer skal indeholde 8 cifre (Ingen landekoder)");
                telBox.Text = "";
            }
            // Tjekker om alle de n�dvendige textbokse er udfyldt, ellers gemmer den ikke informationerne
            else if (forNavnBox.Text == "" || efterNavnBox.Text == "" || adresseBox.Text == "" || postnrBox.Text == "" || byBox.Text == "" || telBox.Text == "")
            {
                MessageBox.Show("Udfyld venligst alle n�dvendige informationer");
                clear();
            }
            else
            {
                // Hvis der er indskrevet lejlighed nr. gemmer den brugerinformationern
                if (lejBox.Text == "")
                {
                    appendText = forNavnBox.Text + ", " + efterNavnBox.Text + ", " + adresseBox.Text + ", " + postnrBox.Text + ", " + byBox.Text + ", " + telBox.Text + Environment.NewLine;
                }
                // Gemmer brugerinformationerne hvis alle de n�dvendige felter er udfyldt
                else
                {
                    appendText = forNavnBox.Text + ", " + efterNavnBox.Text + ", " + adresseBox.Text + ", " + lejBox.Text + ", " + postnrBox.Text + ", " + byBox.Text + ", " + telBox.Text + Environment.NewLine;
                }
                // Sender informationen til textfil
                File.AppendAllText(path, appendText);
                MessageBox.Show("Dine oplysninger er nu gemt i databasen");
                //Benytter mig af nedenst�ende metode
                clear();
            }

        }
        public void clear() //Metode til at clear textboxene i applicationen efter en bruger har indtastet sine oplysninger
        {
            forNavnBox.Text = "";
            efterNavnBox.Text = "";
            adresseBox.Text = "";
            postnrBox.Text = "";
            byBox.Text = "";
            lejBox.Text = "";
            telBox.Text = "";
            s�gBox.Text = "";
        }
        public void visKnap_Click(object sender, EventArgs e) //Metode til at udprinte de 0 - 15 personer til side 1 i databasen
        {
            // Gemmer vis knappen efter den er blevet brugt og viser n�ste 15 knap for at undg� at brugeren laver fejl
            visKnap.Enabled = false;
            visKnap.Visible = false;
            n�steKnap.Enabled = true;
            n�steKnap.Visible = true;
            int counter = 0;
            // Indl�ser alt data fra textfilen
            string[] readData = File.ReadAllLines(path);
            // S�tter autoID og autoTwo til deres originale v�rdier s� brugeren kan benytte sig af 0-15 personer knappen igen og igen
            this.autoID = 1;
            this.autoTwo = 30;
            // Clearer den hvide datakasse for info
            dataKomplet.Clear();
            // L�ser hvor mange linjer der er i filen
            foreach (string line in File.ReadLines(path))
            {
                counter++;
            }
            MessageBox.Show("Der er " + counter + " personer i databasen");
            // tilf�jer tekst og colums til den hvide databox
            dataKomplet.Columns.Add("NR", 40, HorizontalAlignment.Center);
            dataKomplet.Columns.Add("Data", 530, HorizontalAlignment.Center);
            // this betyder at vi kan benytte os af v�rdien uden for void metoden
            int dataNum = 0;

            do
            {
                // Benytter mig af nedenst�ende metode
                addDataToList(readData[dataNum]);
                // Plus 1 til dataNum
                dataNum++;
            }
            // bliver ved indtil vi har data fra 1-15
            while (dataNum < counter && dataNum < 15);
        }
        public void addDataToList(string Data) // Metode til at tilf�je informationen fra filen til den hvide databox
        {
            // ListViewItem (en genstand der skal puttes ind i den hvide databox)
            // eachrow laver en ny linje - Putter autoID ind fordi det er det nummer som skal st� til venstre for vores data
            ListViewItem eachrow = new ListViewItem("" + autoID);
            // Inds�tter vores data til venstre for det ID dataen har f�et
            ListViewItem.ListViewSubItem info = new ListViewItem.ListViewSubItem(eachrow, Data);
            // De to nedenst�ende linjer sender dataen til den hvide databox
            eachrow.SubItems.Add(info);
            dataKomplet.Items.Add(eachrow);
            // autoID skal +1 s� vi ikke tildeler den samme v�rdi flere gange
            // Igen 'this.autoID' fordi den skal kunne benyttes udenfor vores void metode
            this.autoID++;
        }

        private void s�gKnap_Click(object sender, EventArgs e) // Metode til n�r vi trykker p� 'S�g'
        {
            // Gemmer n�ste knap og viser 1-15 knap
            n�steKnap.Enabled = false;
            n�steKnap.Visible = false;
            visKnap.Enabled = true;
            visKnap.Visible = true;
            // Definerer search som det brugeren har indtastet i tekstboksen
            string search = s�gBox.Text;
            // S�tter ID til 1 s� vi kan se hvor mange resultater vi f�r
            this.autoID = 1;
            // Clearer den hvide databox
            dataKomplet.Clear();
            // Foreach l�kke s� den taker alle linjer som indeholder s�gekriteriet, og ikke kun den f�rste linje
            foreach (var line in File.ReadLines(path))
            {
                // Hvis den indeholder s�gekriteriet:
                if (line.Contains(search))
                {
                    dataKomplet.Columns.Add("NR", 40, HorizontalAlignment.Center);
                    dataKomplet.Columns.Add("Data", 530, HorizontalAlignment.Center);
                    // Metoden fra tidligere genbrugt
                    addDataToList(line);
                }
            }
        }
        private void n�steKnap_Click(object sender, EventArgs e) //Metode til at trykke n�ste 15 personer i databasen 
        {
            string[] readData = File.ReadAllLines(path);
            int counter = 0;
            // Clear den hvide databox
            dataKomplet.Clear();
            // Vi antager at brugeren har trykket 0-15 f�rst, s� vi s�tter ikke vores v�rdier tilbage
            foreach (string line in File.ReadLines(path))
            {
                counter++;
            }
            dataKomplet.Columns.Add("NR", 40, HorizontalAlignment.Center);
            dataKomplet.Columns.Add("Data", 530, HorizontalAlignment.Center);
            // S�tter dataNum til autoID v�rdi og -1 (Fordi det f�rste vi g�r er at +1 i vores do while l�kke)
            int dataNum = autoID - 1;
            do
            {
                // Metode fra tidligere
                addDataToList(readData[dataNum]);
                dataNum++;
            }
            // Forts�tter vores l�kke indtil dataNum er = autoTwo (30)
            while (dataNum < counter && dataNum < autoTwo);
            // f�jer +15 til autoTwo s� n�ste gang vi trykker k�rer lykken til 45 og s� 60 osv.
            autoTwo = autoTwo + 15;
            // Hvis der ikke er 15 personer i databasen at tilf�je giver vi brugeren en meddelelse:
            if (counter == dataNum)
            {
                MessageBox.Show("Enden af databasen");
                // Gemmer n�ste knap og viser 1-15 knap
                n�steKnap.Enabled = false;
                n�steKnap.Visible = false;
                visKnap.Enabled = true;
                visKnap.Visible = true;
            }
        }
    }
}
