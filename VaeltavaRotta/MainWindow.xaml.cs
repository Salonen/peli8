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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VaeltavaRotta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int mode = 0;

        hahmo pelaaja, hirvio; // ESITTELY !!

        Random rnd = new Random();

        public MainWindow()
        {
            pelaaja = new hahmo();
            hirvio = new hahmo();
            InitializeComponent();
            textBox.Text = "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
            mode = 1;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {
                textBox.Text = "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
            }
            else if (mode == 1)
            {
                //textBox.Text = "1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                textBox.Text = "\nPoh ";
                mode = 2;
            }
            if (mode == 2)
            {
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        textBox.Text += "\n Ei mitään ";// + " 1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                        textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                        mode = 1;
                        break;
                    case 1:
                        textBox.Text += "\n Kirves ";
                        textBox.Text += "\n Otatko kirveen? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Kirves;
                        mode = 3;
                        break;

                    case 2:
                        textBox.Text += "\n Miekka ";
                        textBox.Text += "\n Otatko miekan? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Miekka;
                        mode = 4;
                        break;
                    case 3:
                        textBox.Text += "\n Hirviö! ";
                        textBox.Text += "\n Hyökkää 1. Pakene 2. ";
                        mode = 5;


                        // pelaaja.Ase = 1;
                        //joo(pelaaja);
                        //taistelu(liike2);
                        break;
                }
            }
            else if (mode == 3)
            {
                pelaaja.Kirves = rnd.Next(1, 21);
                textBox.Text += "\n Kirves on nyt : " + pelaaja.Kirves;
                /*
                                    break;
                                case "2": break;
                            }
                            break;*/
                textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
            }
            else if (mode == 4)
            {
                pelaaja.Miekka = rnd.Next(5, 16);
                textBox.Text += "\n Miekka on nyt : " + pelaaja.Miekka;
                textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
            }
            else if (mode == 5)
            {
                switch (pelaaja.Ase)
                {
                    case 1: hirvio.Terveys -= /*10;break; // */rnd.Next(1, pelaaja.Kirves); break;
                    case 2: hirvio.Terveys -= /*10; break; // */rnd.Next(1, pelaaja.Miekka); break;
                }
                switch (hirvio.Ase) // ylimääräiset pois x 2
                {
                    case 1: pelaaja.Terveys -= /* 10; /*break; // */ rnd.Next(1, hirvio.Kirves); break;
                    case 2: pelaaja.Terveys -= /*10; /*break; // */ rnd.Next(1, hirvio.Miekka); break;
                }
                if (hirvio.Terveys <= 0)
                {
                    textBox.Text += "\n Voitit hirviön !!!";
                    hirvio.Terveys = 100;
                }
                if (pelaaja.Terveys <= 0)
                {
                    textBox.Text += "\n Hirviö voitti sinut !!!";
                    pelaaja.Terveys = 100;
                }
                textBox.Text += "\n Hirviön terveys " + hirvio.Terveys;
                textBox.Text += "\n Pelaajan terveys " + pelaaja.Terveys;
                textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
            }
            //liike = Console.ReadLine();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {
                textBox.Text = "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
            }
            else if (mode == 1)
            {
                textBox.Text = "\nItä";
                mode = 2;
            }
            if (mode == 2)
            {
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        textBox.Text += "\n Ei mitään";// + " 1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                        textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                        mode = 1;
                        break;
                    case 1:
                        textBox.Text += "\n Kirves";
                        textBox.Text += "\n Otatko kirveen? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Kirves;
                        mode = 3;
                        break;

                    case 2:
                        textBox.Text += "\n Miekka ";
                        textBox.Text += "\n Otatko miekan? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Miekka;
                        mode = 4;
                        break;
                    case 3:
                        textBox.Text += "\n Hirviö! ";
                        textBox.Text += "\n Hyökkää 1. Pakene 2. ";
                        mode = 5;


                        // pelaaja.Ase = 1;
                        //joo(pelaaja);
                        //taistelu(liike2);
                        break;
                }
            }
            else if (mode == 3)
            {
                //textBox.Text = "1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
                //liike = Console.ReadLine();
            }
            else if (mode == 4)
            {
                //textBox.Text = "1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
                //liike = Console.ReadLine();
            }
            else if (mode == 5)
            {
                hirvio.Kirves = /*5; //*/ rnd.Next(1, 21);
                hirvio.Miekka = /*5; //*/ rnd.Next(5, 16);
                hirvio.Ase =  /*2; //*/ rnd.Next(1, 3);
                textBox.Text += "\n Hirviön ase " + hirvio.Ase + " Hirviön kirves " + hirvio.Kirves + " Hirviön miekka " + hirvio.Miekka;
                pelaaja.Terveys -= (hirvio.Kirves + hirvio.Miekka) / 8;

                if (pelaaja.Terveys <= 0)
                {
                    textBox.Text += "\n Hirviö voitti sinut !!!";
                    pelaaja.Terveys = 100;
                }

                textBox.Text += "\n Hirviön terveys " + hirvio.Terveys;
                textBox.Text += "\n Pelaajan terveys " + pelaaja.Terveys;
                textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {
                textBox.Text = "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
            }
            else if (mode == 1)
            {
                textBox.Text = "\nEtelä";
                mode = 2;
            }
            if (mode == 2)
            {
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        textBox.Text += "\n Ei mitään ";// + " 1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                        textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                        mode = 1;
                        break;
                    case 1:
                        textBox.Text += "\n Kirves ";
                        textBox.Text += "\n Otatko kirveen? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Kirves;
                        mode = 3;
                        break;

                    case 2:
                        textBox.Text += "\n Miekka ";
                        textBox.Text += "\n Otatko miekan? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Miekka;
                        mode = 4;
                        break;
                    case 3:
                        textBox.Text += "\n Hirviö! ";
                        textBox.Text += "\n Hyökkää 1. Pakene 2. ";
                        mode = 5;


                        // pelaaja.Ase = 1;
                        //joo(pelaaja);
                        //taistelu(liike2);
                        break;
                }
            }
            //else if (mode == 3) mode = 0;
            //liike = Console.ReadLine();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {
                textBox.Text = "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                mode = 1;
            }
            else if (mode == 1)
            {
                textBox.Text = "\nLänsi";
                mode = 2;
            }
            if (mode == 2)
            {
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        textBox.Text += "\n Ei mitään ";// + " 1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                        textBox.Text += "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
                        mode = 1;
                        break;
                    case 1:
                        textBox.Text += "\n Kirves ";
                        textBox.Text += "\n Otatko kirveen? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Kirves;
                        mode = 3;
                        break;

                    case 2:
                        textBox.Text += "\n Miekka ";
                        textBox.Text += "\n Otatko miekan? 1. Kyllä. 2. ei. Nykyinen : " + pelaaja.Miekka;
                        mode = 4;
                        break;
                    case 3:
                        textBox.Text += "\n Hirviö! ";
                        textBox.Text += "\n Hyökkää 1. Pakene 2. ";
                        mode = 5;


                        // pelaaja.Ase = 1;
                        //joo(pelaaja);
                        //taistelu(liike2);
                        break;
                }
            }
            //else if (mode == 3) mode = 0;
            //liike = Console.ReadLine();
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0) textBox.Text = "\n1. POH, 2. ITÄ, 3. ETELÄ, 4. LÄNSI, 5. LOPPU";
            //Environment.Exit(0);
            //this.Close();
            //liike = Console.ReadLine();
        }
    }

    public class hahmo // public !!!
    {
        private int ase; // 1 kirves 2 miekka
        private int kirves; // 1-20
        private int miekka; // 5-15

        private int voima; // ?
        private int nopeus; // ?
        private int terveys; // 1-100

        public hahmo() // sulut!!
        { // sulut !!
            this.ase = 1;
            this.kirves = 10;
            this.miekka = 10;
            this.voima = 10; // ?
            this.nopeus = 10; // ?
            this.terveys = 100; // 1-100
        }

        public int Ase
        {
            get { return ase; }
            set { ase = value; }
        }

        public int Kirves
        {
            get { return kirves; }
            set { kirves = value; }
        }

        public int Miekka
        {
            get { return miekka; }
            set { miekka = value; }
        }
        public int Terveys
        {
            get { return terveys; }
            set { terveys = value; }
        }
    }

}
