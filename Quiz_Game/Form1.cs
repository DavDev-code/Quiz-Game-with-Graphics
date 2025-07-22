using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{
    public partial class Form1 : Form
    {
        public int remainingtime = 15;
        public int correctAnswer;
        public int questionNumber = 1;
        public int money = 0;
        public int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            Questions(questionNumber);
            totalQuestions = 15;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = remainingtime.ToString();
        }
        private void Answers(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag=Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                timer1.Stop();
                MessageBox.Show("Correct!");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Game Over!");
                Application.Exit();
            }
            if (questionNumber == totalQuestions)
            {
                MessageBox.Show("Congratulations! You have ansewered every question correctly and won the Grand Prize of 1 Million Pounds!");
                Application.Exit();
            }
            questionNumber++;
            Questions(questionNumber);
        }
        private void Questions(int qnum)
        {
            label5.Text = money.ToString();
            switch (qnum)
            {
                case 1:
                    money = 100;
                    label1.Text = "1. When did Hitler Invade Poland?";
                    button1.Text = "1951";
                    button2.Text = "1950";
                    button3.Text = "1940";
                    button4.Text = "1939";
                    correctAnswer = 4;
                    break;
                case 2:
                    remainingtime = 15;
                    timer1.Start();
                    money = 200;
                    label1.Text = "2. What's the name of the second album of Rage Against the Machine?";
                    button1.Text = "Rage Against the Machine";
                    button2.Text = "The Battle of Los Angeles";
                    button3.Text = "Evil Empire";
                    button4.Text = "Renegades";
                    correctAnswer = 3;
                    break;
                case 3:
                    remainingtime = 15;
                    timer1.Start();
                    money = 300;
                    label1.Text = "3. In which city does the player spend most of his time in the game Deus Ex:Mankind divided?";
                    button1.Text = "Prague";
                    button2.Text = "Detroit";
                    button3.Text = "Montreal";
                    button4.Text = "Hengsha";
                    correctAnswer = 1;
                    break;
                case 4:
                    remainingtime = 15;
                    timer1.Start();
                    money = 500;
                    label1.Text = "4. When was the album Paul's Boutique by the Beastie Boys released?";
                    button1.Text = "1985";
                    button2.Text = "1989";
                    button3.Text = "1992";
                    button4.Text = "1994";
                    correctAnswer = 2;
                    break;
                case 5:
                    remainingtime = 15;
                    timer1.Start();
                    money = 1000;
                    label1.Text = "5. Who scored the winning goal in the final of UEFA Euro 2016?";
                    button1.Text = "Cristiano Ronaldo";
                    button2.Text = "Eder";
                    button3.Text = "Nani";
                    button4.Text = "Ricardo Quaresma";
                    correctAnswer = 2;
                    break;
                case 6:
                    remainingtime = 30;
                    timer1.Start();
                    money = 2000;
                    label1.Text = "6. What's Joey Wheeler's/Katsuya Jonouchi's (Yu-Gi-Oh Duel Monsters) ace monster?";
                    button1.Text = "Elenental HERO Neos";
                    button2.Text = "Blue-Eyes White Dragon";
                    button3.Text = "Insect Queen";
                    button4.Text = "Red - Eyes Black Dragon";
                    correctAnswer = 4;
                    break;
                case 7:
                    remainingtime = 30;
                    timer1.Start();
                    money = 4000;
                    label1.Text = "7. In what year does the sequel of the movie Blade Runner take place?";
                    button1.Text = "2025";
                    button2.Text = "2049";
                    button3.Text = "2055";
                    button4.Text = "2077";
                    correctAnswer = 2;
                    break;
                case 8:
                    remainingtime = 30;
                    timer1.Start();
                    money = 8000;
                    label1.Text = "8. When was the game Winning Eleven 9 released?";
                    button1.Text = "2002";
                    button2.Text = "2005";
                    button3.Text = "2008";
                    button4.Text = "2009";
                    correctAnswer = 2;
                    break;
                case 9:
                    remainingtime = 30;
                    timer1.Start();
                    money = 16000;
                    label1.Text = "9. Who scored the first goal for Greece in UEFA Euro 2004?";
                    button1.Text = "Karagounis";
                    button2.Text = "Charisteas";
                    button3.Text = "Gianakopoulos";
                    button4.Text = "Lymperopoulos ";
                    correctAnswer = 1;
                    break;
                case 10:
                    remainingtime = 30;
                    timer1.Start();
                    money = 32000;
                    label1.Text = "10. What's the main character's name in the main Kingdom Hearts video game series?";
                    button1.Text = "Riku";
                    button2.Text = "Kairi";
                    button3.Text = "Sora";
                    button4.Text = "Roxas";
                    correctAnswer = 3;
                    break;
                case 11:
                    remainingtime = 45;
                    timer1.Start();
                    money = 64000;
                    label1.Text = "11. What's the first part of the manga Jojo's Bizzare Adventure called?";
                    button1.Text = "Stardust Crusaders";
                    button2.Text = "Phantom Blood";
                    button3.Text = "Stone Ocean";
                    button4.Text = "Golden Wind";
                    correctAnswer = 2;
                    break;
                case 12:
                    remainingtime = 45;
                    timer1.Start();
                    money = 125000;
                    label1.Text = "12. What colour is the original Playstation?";
                    button1.Text = "White";
                    button2.Text = "Grey";
                    button3.Text = "Black";
                    button4.Text = "Blue";
                    correctAnswer = 2;
                    break;
                case 13:
                    remainingtime = 45;
                    timer1.Start();
                    money = 250000;
                    label1.Text = "13. Who's second in the NBA all-time soring table?";
                    button1.Text = "Lebron James";
                    button2.Text = "Michael Jordan";
                    button3.Text = "Kareem Abdul-Jabbar";
                    button4.Text = "Karl Malone";
                    correctAnswer = 3;
                    break;
                case 14:
                    remainingtime = 45;
                    timer1.Start();
                    money = 500000;
                    label1.Text = "14. Which band released The Immigrant Song?";
                    button1.Text = "Queen";
                    button2.Text = "AC/DC";
                    button3.Text = "Guns n' Roses";
                    button4.Text = "Led Zeppelin";
                    correctAnswer = 4;
                    break;
                case 15:
                    remainingtime = 60;
                    timer1.Start();
                    money = 1000000;
                    label1.Text = "15. How many films has David Fincher directed?";
                    button1.Text = "8";
                    button2.Text = "10";
                    button3.Text = "12";
                    button4.Text = "14";
                    correctAnswer = 3;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = remainingtime.ToString();
            remainingtime = remainingtime - 1;
            if (remainingtime == -1)
            {
                timer1.Stop();
                MessageBox.Show("You are out of time!");
                Application.Exit();
            }
        }

        private void fifty_fifty(object sender, EventArgs e)
        {
            button5.Enabled = false;
            switch (questionNumber)
            {
                case 1:
                    MessageBox.Show("It's either 1940 or 1939");
                    break;
                case 2:
                    MessageBox.Show("It's either The Battle of Los Angeles or Evil Empire");
                    break;
                case 3:
                    MessageBox.Show("It's either Prague or Detroit");
                    break;
                case 4:
                    MessageBox.Show("It's either 1989 or 1992");
                    break;
                case 5:
                    MessageBox.Show("It's either Cristiano Ronaldo or Eder");
                    break;
                case 6:
                    MessageBox.Show("It's either Blue-Eyes White Dragon or Red - Eyes Black Dragon");
                    break;
                case 7:
                    MessageBox.Show("It's either 2049 or 2055");
                    break;
                case 8:
                    MessageBox.Show("It's either 2005 or 2009");
                    break;
                case 9:
                    MessageBox.Show("It's either Karagounis or Charisteas");
                    break;
                case 10:
                    MessageBox.Show("It's either Riku or Sora");
                    break;
                case 11:
                    MessageBox.Show("It's either Stardust Crusaders or Phantom Blood");
                    break;
                case 12:
                    MessageBox.Show("It's either Grey or Black");
                    break;
                case 13:
                    MessageBox.Show("It's either Lebron James or Kareem Abdul-Jabbar");
                    break;
                case 14:
                    MessageBox.Show("It's either Guns n' Roses or Led Zeppelin");
                    break;
                case 15:
                    MessageBox.Show("It's either 8 or 12");
                    break;
            }
        }

        private void phone_friend(object sender, EventArgs e)
        {
            button6.Enabled = false;
            switch (questionNumber)
            {
                case 1:
                    MessageBox.Show("I think it's 1939");
                    break;
                case 2:
                    MessageBox.Show("I think it's Evil Empire");
                    break;
                case 3:
                    MessageBox.Show("I think it's Prague");
                    break;
                case 4:
                    MessageBox.Show("I think it's 1989");
                    break;
                case 5:
                    MessageBox.Show("I think it's Eder");
                    break;
                case 6:
                    MessageBox.Show("I think it's Red - Eyes Black Dragon");
                    break;
                case 7:
                    MessageBox.Show("I think it's 2049");
                    break;
                case 8:
                    MessageBox.Show("I think it's 2005");
                    break;
                case 9:
                    MessageBox.Show("I think it's Karagounis");
                    break;
                case 10:
                    MessageBox.Show("I think it's Sora");
                    break;
                case 11:
                    MessageBox.Show("I think it's Phantom Blood");
                    break;
                case 12:
                    MessageBox.Show("I think it's Grey");
                    break;
                case 13:
                    MessageBox.Show("I think it's Kareem Abdul-Jabbar");
                    break;
                case 14:
                    MessageBox.Show("I think it's Led Zeppelin");
                    break;
                case 15:
                    MessageBox.Show("I think it's 12");
                    break;
            }
        }

        private void audience(object sender, EventArgs e)
        {
            button7.Enabled = false;
            switch (questionNumber)
            {
                case 1:
                    MessageBox.Show("1951 0%\n1950 5%\n1940 25%\n1939 70%");
                    break;
                case 2:
                    MessageBox.Show("Rage Against the Machine 0%\nThe Battle of Los Angeles 30%\nEvil Empire 55%\nRenegades 15%");
                    break;
                case 3:
                    MessageBox.Show("Prague 65%\nDetroit 20%\nMontreal 10%\nHengsha 5%");
                    break;
                case 4:
                    MessageBox.Show("1985 0%\n1989 45%\n1992 40%\n1994 15%");
                    break;
                case 5:
                    MessageBox.Show("Cristiano Ronaldo 45%\nEder 35%\nNani 20%\nRicardo Quaresma 0%");
                    break;
                case 6:
                    MessageBox.Show("Elenental HERO Neos 5%\nBlue-Eyes White Dragon 0%\nInsect Queen 10%\nRed - Eyes Black Dragon 85%");
                    break;
                case 7:
                    MessageBox.Show("2025 10%\n2049 60%\n2055 20%\n2077 10%");
                    break;
                case 8:
                    MessageBox.Show("2002 0%\n2005 35%\n2008 35%\n2009 30%");
                    break;
                case 9:
                    MessageBox.Show("Karagounis 55%\nCharisteas 30%\nGianakopoulos 5%\nLymperopoulos 10%");
                    break;
                case 10:
                    MessageBox.Show("Riku 5%\nKairi 5%\nSora 75%\nRoxas 15%");
                    break;
                case 11:
                    MessageBox.Show("Stardust Crusaders 40%\nPhantom Blood 40%\nStone Ocean 5%\nGolden Wind 15%");
                    break;
                case 12:
                    MessageBox.Show("White 5%\nGrey 85%\nBlack 10%\nBlue 0%");
                    break;
                case 13:
                    MessageBox.Show("Lebron James 30%\nMichael Jordan 30%\nKareem Abdul-Jabbar 30%\nKarl Malone 10%");
                    break;
                case 14:
                    MessageBox.Show("Queen 5%\nAC/DC 0%\nGuns n' Roses 15%\nLed Zeppelin 80%");
                    break;
                case 15:
                    MessageBox.Show("8 10%\n10 55%\n12 35%\n14 0%");
                    break;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\Tasos\Desktop\Quiz\Who Wants To Be A Millionaire Full Theme.mp3";
        }
    }
}
