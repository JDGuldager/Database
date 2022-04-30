using System.Data.SqlClient;
using System.Data;

namespace Projekt
{
    public partial class Form1 : Form
    {
        private int autoID = 1;
        private int autoTwo = 30;
        private int dataNum = 0;
        public Form1()
        {
            InitializeComponent();  
        }
        private void gemKnap_Click(object sender, EventArgs e) //Metode der kører når jeg trykker på gem knappen i programmet
        {
            //Laver en mappe hvor jeg kan putte database textfilen ind
            Directory.CreateDirectory(@"c:\Jeppe-Leif-Nathalie-Parking");
            string path = @"c:\Jeppe-Leif-Nathalie-Parking\Database.txt";
            string appendText = "";
            // Hvis ikke der er påbegynt en database, laver denne kode en ny fil på ovenstående destination
            if (!File.Exists(path))
            {
                string[] createText = { "" };
                File.WriteAllLines(path, createText);
            }
            // Tjekker om alle de nødvendige textbokse er udfyldt, ellers gemmer den ikke informationerne
            if (forNavnBox.Text == "" || efterNavnBox.Text == "" || adresseBox.Text == "" || postnrBox.Text == "" || byBox.Text == ""||telBox.Text=="")
            {
                MessageBox.Show("Udfyld venligst alle nødvendige informationer");
                clear();
            }
            else if (telBox.Text.Length < 8 || telBox.Text.Length > 8)
            {
                MessageBox.Show("Mobilnummer skal indeholde 8 cifre (Ingen landekoder)");
                telBox.Text = "";
            }
            else
            {
                if (lejBox.Text == "")
                {
                    appendText = forNavnBox.Text + ", " + efterNavnBox.Text + ", " + adresseBox.Text + ", " + postnrBox.Text + ", " + byBox.Text + ", " + telBox.Text + Environment.NewLine;
                }
                else
                {
                    appendText = forNavnBox.Text + ", " + efterNavnBox.Text + ", " + adresseBox.Text + ", "+lejBox.Text+ ", " + postnrBox.Text + ", " + byBox.Text + ", " + telBox.Text + Environment.NewLine;
                }
                File.AppendAllText(path, appendText);
                MessageBox.Show("Dine oplysninger er nu gemt i databasen");
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
        } 
        public void visKnap_Click(object sender, EventArgs e) //Metode til at udprinte de 0 - 15 personer til side 1 i databasen
        {
            string path = @"c:\Jeppe-Leif-Nathalie-Parking\Database.txt";
            string[] readData = File.ReadAllLines(path);
            int counter = 0;
            autoID = 1;
            autoTwo = 30;
            dataKomplet.Clear();
            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(path))
            {
                counter++;
            }

            MessageBox.Show("Der er "+counter+" personer i databasen");

            dataKomplet.Columns.Add("NR", 40, HorizontalAlignment.Center);
            dataKomplet.Columns.Add("Data", 530, HorizontalAlignment.Center);
            this.dataNum =0;
            do
            {
                addDataToList(readData[dataNum]);
                this.dataNum++;
            }
            while (dataNum<counter&&dataNum<15);
        }
        public void addDataToList (string Data)
        {
            ListViewItem eachrow = new ListViewItem("" + autoID);
            ListViewItem.ListViewSubItem info = new ListViewItem.ListViewSubItem(eachrow, Data);
            eachrow.SubItems.Add(info);

            dataKomplet.Items.Add(eachrow);

            this.autoID++;
        }

        private void søgKnap_Click(object sender, EventArgs e)
        {
            string path = @"c:\Jeppe-Leif-Nathalie-Parking\Database.txt";
            string search=søgBox.Text;
            string[] readData = File.ReadAllLines(path);
            autoID = 1;
            dataKomplet.Clear();

            foreach (var line in File.ReadLines(path))
            {
                if (line.Contains(search))
                {
                    dataKomplet.Columns.Add("NR", 40, HorizontalAlignment.Center);
                    dataKomplet.Columns.Add("Data", 530, HorizontalAlignment.Center);
                    addDataToList(line);
                }
            } 
        }
        private void næsteKnap_Click(object sender, EventArgs e) //Metode til at trykke næste 15 personer i databasen 
        {
            int counter = 0;
            string path = @"c:\Jeppe-Leif-Nathalie-Parking\Database.txt";
            string[] readData = File.ReadAllLines(path);
            dataKomplet.Clear();

            foreach (string line in File.ReadLines(path))
            {
                counter++;
            }

            dataKomplet.Columns.Add("NR", 40, HorizontalAlignment.Center);
            dataKomplet.Columns.Add("Data", 530, HorizontalAlignment.Center);
           
            int dataNum = autoID-1;
            do
            {
                addDataToList(readData[dataNum]);
                dataNum++;
            }
            while (dataNum<counter&&dataNum<autoTwo);
            
            autoTwo=autoTwo+15;
            if (counter == dataNum) MessageBox.Show("Enden af databasen");
        }

    }
}
