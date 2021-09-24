using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressbok
{
    class Prompt
    {
        //Skapa ny kontakt
        public static Person ShowDialog(string text, string caption)
        {
            Person person = new Person();

            Form prompt = new Form();
            prompt.Width = 600;
            prompt.Height = 800;
            prompt.Text = caption;

            //Namn label
            TextBox inputNamn = new TextBox() { Left = 55, Top = 50, Width = 400 };
            inputNamn.PlaceholderText = "Namn";

            //Gatuadress label
            TextBox inputGatuadress = new TextBox() { Left = 55, Top = 150, Width = 400 };
            inputGatuadress.PlaceholderText = "Gatuadress";

            //Postnummer label
            TextBox inputPostnummer = new TextBox() { Left = 55, Top = 250, Width = 400 };
            inputPostnummer.PlaceholderText = "Postnummer";

            //Postort label
            TextBox inputPostort = new TextBox() { Left = 55, Top = 350, Width = 400 };
            inputPostort.PlaceholderText = "Postort";

            //Telefon label
            TextBox inputTelefon = new TextBox() { Left = 55, Top = 450, Width = 400 };
            inputTelefon.PlaceholderText = "Telefon";

            //Epost label
            TextBox inputEpost = new TextBox() { Left = 55, Top = 550, Width = 400 };
            inputEpost.PlaceholderText = "Epost";


            Button confirmation = new Button() { Text = "Spara", Left = 350, Height = 60, Width = 100, Top = 620 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);

            Button cancellation = new Button() { Text = "Avbryt", Left = 200, Height = 60, Width = 100, Top = 620 };
            confirmation.Click += (sender, e) => { prompt.Close(); };


            //Namn
            prompt.Controls.Add(inputNamn);

            //Gatuadress
            prompt.Controls.Add(inputGatuadress);

            //Postnummer
            prompt.Controls.Add(inputPostnummer);

            //Postort
            prompt.Controls.Add(inputPostort);

            //Telefon
            prompt.Controls.Add(inputTelefon);

            //Epost
            prompt.Controls.Add(inputEpost);

            prompt.ShowDialog();

            //Tilldelar inputvärdet från formuläret till objektet person.
            //Om inputvärdet är tomt får fältet bindestreck "-".
            if(inputNamn.Text == "")
            {
                person.Namn = "-";
            }
            else
            {
                person.Namn = inputNamn.Text;
            }

            if (inputGatuadress.Text == "")
            {
                person.Gatuadress = "-";
            }
            else
            {
                person.Gatuadress = inputGatuadress.Text;
            }

            if (inputPostnummer.Text == "")
            {
                person.Postnummer = "-";
            }
            else
            {
                person.Postnummer = inputPostnummer.Text;
            }

            if (inputPostort.Text == "")
            {
                person.Postort = "-";
            }
            else
            {
                person.Postort = inputPostort.Text;
            }

            if (inputTelefon.Text == "")
            {
                person.Telefon = "-";
            }
            else
            {
                person.Telefon = inputTelefon.Text;
            }

            if (inputEpost.Text == "")
            {
                person.Epost = "-";
            }
            else
            {
                person.Epost = inputEpost.Text;
            }

            return person;
        }

        //Redigera existerande kontakt
        public static Person ShowDialogEdit(string namn, string gatuadress, string postnummer,
            string postort, string telefon, string epost)
        {
            Person person = new Person();

            Form prompt = new Form();
            prompt.Width = 600;
            prompt.Height = 800;
            prompt.Text = "Redigera kontakt";

            //Namn label
            TextBox inputNamn = new TextBox() { Left = 55, Top = 50, Width = 400 };
            inputNamn.PlaceholderText = "Namn";
            inputNamn.Text = namn;

            //Gatuadress label
            TextBox inputGatuadress = new TextBox() { Left = 55, Top = 150, Width = 400 };
            inputGatuadress.PlaceholderText = "Gatuadress";
            inputGatuadress.Text = gatuadress;

            //Postnummer label
            TextBox inputPostnummer = new TextBox() { Left = 55, Top = 250, Width = 400 };
            inputPostnummer.PlaceholderText = "Postnummer";
            inputPostnummer.Text = postnummer;


            //Postort label
            TextBox inputPostort = new TextBox() { Left = 55, Top = 350, Width = 400 };
            inputPostort.PlaceholderText = "Postort";
            inputPostort.Text = postort;

            //Telefon label
            TextBox inputTelefon = new TextBox() { Left = 55, Top = 450, Width = 400 };
            inputTelefon.PlaceholderText = "Telefon";
            inputTelefon.Text = telefon;

            //Epost label
            TextBox inputEpost = new TextBox() { Left = 55, Top = 550, Width = 400 };
            inputEpost.PlaceholderText = "Epost";
            inputEpost.Text = epost;



            Button confirmation = new Button() { Text = "Spara", Left = 350, Height = 60, Width = 100, Top = 620 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);

            Button cancellation = new Button() { Text = "Avbryt", Left = 200, Height = 60, Width = 100, Top = 620 };
            cancellation.Click += (sender, e) => { prompt.Dispose(); };
            prompt.Controls.Add(cancellation);


            //Namn
            prompt.Controls.Add(inputNamn);

            //Gatuadress
            prompt.Controls.Add(inputGatuadress);

            //Postnummer
            prompt.Controls.Add(inputPostnummer);

            //Postort
            prompt.Controls.Add(inputPostort);

            //Telefon
            prompt.Controls.Add(inputTelefon);

            //Epost
            prompt.Controls.Add(inputEpost);

            prompt.ShowDialog();

            //Tilldelar inputvärdet från formuläret till objektet person
            person.Namn = inputNamn.Text;
            person.Gatuadress = inputGatuadress.Text;
            person.Postnummer = inputPostnummer.Text;
            person.Postort = inputPostort.Text;
            person.Telefon = inputTelefon.Text;
            person.Epost = inputEpost.Text;

            return person;


        }
    }
}