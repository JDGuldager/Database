using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Projekt
{
    public partial class Form1 : Form
    {
        // Private = Kan benyttes inden i alle metoderne i koden, også void
        private int autoID = 1;
        private int autoTwo = 30;
        private int gangeBrugt = 0;
        private string path = @"c:\Jeppe-Leif-Nathalie-Parking\Database.txt";
        private string appendText = "";
        public Form1() //Starter GUI
        {
            InitializeComponent();
            //Gemmer næste knappen
            næsteKnap.Enabled = false;
            næsteKnap.Visible = false;
            //Laver en mappe hvor jeg kan putte database textfilen ind
            Directory.CreateDirectory(@"c:\Jeppe-Leif-Nathalie-Parking");
            // Hvis ikke der er påbegynt en database, laver denne kode en ny fil på ovenstående destination
            if (!File.Exists(path))
            {
                // Tilføjer Brian Mørk til databasen
                string brianText = "Christian, Mørk, Vedbæk Strandvej 2, 2950, Vedbæk, 50251287, cm@cmis.dk"+Environment.NewLine;
                File.WriteAllText(path, brianText);
            }
        }
        private void gemKnap_Click(object sender, EventArgs e) //Metode der kører når jeg trykker på gem knappen i programmet
        {
            bool telNrExists = false;
            bool emailExists = false;
            string telNrCheck = telBox.Text;
            string emailCheck = emailBox.Text;
            // Foreach løkke så den tager alle linjer som indeholder søgekriteriet, og ikke kun den første linje
            foreach (var line in File.ReadLines(path))
            {
                // Hvis en af linjerne indeholder telefon nummer eller email
                if (line.Contains(telNrCheck))
                {
                    telNrExists = true;
                }
                if (line.Contains(emailCheck))
                {
                    emailExists = true;
                }
            }
            // Tjekker om alle de nødvendige textbokse er udfyldt, ellers gemmer den ikke informationerne
            if (forNavnBox.Text == "" || efterNavnBox.Text == "" || adresseBox.Text == "" || postnrBox.Text == "" || byBox.Text == "" || telBox.Text == "" || emailBox.Text == "")
            {
                MessageBox.Show("Udfyld venligst alle nødvendige informationer");
            }
            // Tager højde for at alt indtastet i postnr kassen er tal
            else if (!postnrBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Postnummer kan kun indeholde tal");
                postnrBox.Text = "";
            }
            // Tjekker om postnummeret er mere eller mindre end 4 cifre
            else if (postnrBox.Text.Length != 4)
            {
                MessageBox.Show("Postnummeret skal indeholde 4 cifre");
                postnrBox.Text = "";
            }
            // Tager højde for at alt indtastet i mobilnummer kassen er tal
            else if (!telBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Mobilnummer kan kun indeholde tal");
                telBox.Text = "";
            }
            // Tjekker om telefon nummeret er mere eller mindre end 8 cifre
            else if (telBox.Text.Length != 8)
            {
                MessageBox.Show("Mobilnummer skal indeholde 8 cifre (Ingen landekoder)");
                telBox.Text = "";
            }
            // Hvis der var en email eller telefonnummer som eksisterede udskriver vi en fejlmeddelelse
            else if (telNrExists == true)
            {
                MessageBox.Show("Dette telefonnummer er allerede registreret i databasen");
                telBox.Text = "";
            }
            else if (emailExists == true)
            {
                MessageBox.Show("Denne email er allerede registreret i databasen");
                emailBox.Text = "";
            }
            // Indbygget C# email validation tjek
            else if (!new EmailAddressAttribute().IsValid(emailBox.Text))
            {
                MessageBox.Show("Denne email er ikke valid");
                emailBox.Text = "";
            }
            else
            {
                // Hvis der er indskrevet lejlighed nr. gemmer den brugerinformationern
                if (lejBox.Text == "")
                {
                    appendText = forNavnBox.Text + ", " + efterNavnBox.Text + ", " + adresseBox.Text + ", " + postnrBox.Text + ", " + byBox.Text + ", " + telBox.Text + ", " + emailBox.Text + Environment.NewLine;
                }
                // Gemmer brugerinformationerne hvis alle de nødvendige felter er udfyldt
                else
                {
                    appendText = forNavnBox.Text + ", " + efterNavnBox.Text + ", " + adresseBox.Text + ", " + lejBox.Text + ", " + postnrBox.Text + ", " + byBox.Text + ", " + telBox.Text + ", " + emailBox.Text + Environment.NewLine;
                }
                // Sender informationen til textfil
                File.AppendAllText(path, appendText);
                MessageBox.Show("Dine oplysninger er nu gemt i databasen");
                //Benytter mig af nedenstående metode
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
            søgBox.Text = "";
            emailBox.Text = "";
        }
        public void dataBoxOpstilling() //Metode til opstillingen af kolonnerne i databoksen
        {
            // tilføjer tekst og colums til den hvide databox
            dataKomplet.Columns.Add("NR", 40, HorizontalAlignment.Center);
            dataKomplet.Columns.Add("Data", 525, HorizontalAlignment.Center);
        }
        public void visKnap_Click(object sender, EventArgs e) //Metode til at udprinte de 0 - 15 personer til side 1 i databasen
        {
            int counter = 0;
            // Indlæser alt data fra textfilen
            string[] readData = File.ReadAllLines(path);
            // Sætter autoID og autoTwo til deres originale værdier så brugeren kan benytte sig af 0-15 personer knappen igen og igen
            this.autoID = 1;
            this.autoTwo = 30;
            // Clearer den hvide datakasse for info
            dataKomplet.Clear();
            // Læser hvor mange linjer der er i filen
            foreach (string line in File.ReadLines(path))
            {
                counter++;
            }
            // Hvis det er første gang brugeren trykker 1-15 bliver meddelelsen om antal personer vist, anden gang bliver den ikke vist
            if (gangeBrugt == 0)
            {
                MessageBox.Show("Der er " + counter + " personer i databasen");
                this.gangeBrugt++;
            }
            // ændre knappens tekst efter første brug
            visKnap.Text = "Tilbage til start";
            dataBoxOpstilling();
            // this betyder at vi kan benytte os af værdien uden for void metoden
            int dataNum = 0;

            do
            {
                // Benytter mig af nedenstående metode
                addDataToList(readData[dataNum]);
                // Plus 1 til dataNum
                dataNum++;
            }
            // bliver ved indtil vi har data fra 1-15
            while (dataNum < counter && dataNum < 15);
            if (counter > 15)
            {
                // Hvis der er mere end 15 brugere i databasen bliver næste knappen tilgængelig
                // Gemmer vis knappen efter den er blevet brugt og viser næste 15 knap for at undgå at brugeren laver fejl
                visKnap.Enabled = false;
                visKnap.Visible = false;
                næsteKnap.Enabled = true;
                næsteKnap.Visible = true;
            }
        }
        public void addDataToList(string Data) // Metode til at tilføje informationen fra filen til den hvide databox
        {
            // ListViewItem (en genstand der skal puttes ind i den hvide databox)
            // eachrow laver en ny linje - Putter autoID ind fordi det er det nummer som skal stå til venstre for vores data
            ListViewItem eachrow = new ListViewItem("" + autoID);
            // Indsætter vores data til venstre for det ID dataen har fået
            ListViewItem.ListViewSubItem info = new ListViewItem.ListViewSubItem(eachrow, Data);
            // De to nedenstående linjer sender dataen til den hvide databox
            eachrow.SubItems.Add(info);
            dataKomplet.Items.Add(eachrow);
            // autoID skal +1 så vi ikke tildeler den samme værdi flere gange
            // Igen 'this.autoID' fordi den skal kunne benyttes udenfor vores void metode
            this.autoID++;
        }

        private void søgKnap_Click(object sender, EventArgs e) // Metode til når vi trykker på 'Søg'
        {
            // Gemmer næste knap og viser 1-15 knap
            næsteKnap.Enabled = false;
            næsteKnap.Visible = false;
            visKnap.Enabled = true;
            visKnap.Visible = true;
            // Definerer search som det brugeren har indtastet i tekstboksen
            string search = søgBox.Text;
            // Sætter ID til 1 så vi kan se hvor mange resultater vi får
            this.autoID = 1;
            // Clearer den hvide databox
            dataKomplet.Clear();
            // Foreach lække så den taker alle linjer som indeholder søgekriteriet, og ikke kun den første linje
            foreach (string line in File.ReadLines(path))
            {
                // StringComparison.OrdinalIgnoreCase gør søgekriteriet case insensitive så vi kan søge både med stort og småt
                // Hvis den indeholder søgekriteriet:
                if (line.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    dataBoxOpstilling();
                    // Metoden fra tidligere genbrugt
                    addDataToList(line);
                }
            }
            søgBox.Text = "";
        }
        private void næsteKnap_Click(object sender, EventArgs e) //Metode til at trykke næste 15 personer i databasen 
        {
            string[] readData = File.ReadAllLines(path);
            int counter = 0;
            // Clear den hvide databox
            dataKomplet.Clear();
            // Vi antager at brugeren har trykket 0-15 først, så vi sætter ikke vores værdier tilbage
            foreach (string line in File.ReadLines(path))
            {
                counter++;
            }
            dataBoxOpstilling();
            // Sætter dataNum til autoID værdi og -1 (Fordi det første vi gør er at +1 i vores do while løkke)
            int dataNum = autoID - 1;
            do
            {
                // Metode fra tidligere
                addDataToList(readData[dataNum]);
                dataNum++;
            }
            // Fortsætter vores løkke indtil dataNum er = autoTwo (30)
            while (dataNum < counter && dataNum < autoTwo);
            // føjer +15 til autoTwo så næste gang vi trykker kører lykken til 45 og så 60 osv.
            autoTwo = autoTwo + 15;
            // Hvis der ikke er 15 personer i databasen at tilføje giver vi brugeren en meddelelse:
            if (counter == dataNum)
            {
                MessageBox.Show("Enden af databasen");
                // Gemmer næste knap og viser tilbage til start knap
                næsteKnap.Enabled = false; næsteKnap.Visible = false; visKnap.Enabled = true; visKnap.Visible = true;
            }
        }
    }
}
