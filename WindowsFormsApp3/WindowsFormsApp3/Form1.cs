using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Linq;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1(bool isServer)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;
            

            if (isServer)
            {
                
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
                
                setInitialState();
                
            }


        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CheckState())
                return;
            DisableAllButtons();
            label2.Text = "Opponent's Turn";
            ReceiveMove();
            label2.Text = "Your Turn";
            if (!CheckState())
                EnableAllButtons();
            
        }

        private static int PlayerOneScore = 0;
        private static int PlayerTwoScore = 0;

        int[] playerOneFlags = new int[5];
        int[] playerTwoFlags = new int[5];

        


        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;
    
        private bool CheckState()
        {
            //Checking if one of the players reach the score of 5 (capturing each property of opponent gives the player one score)

            if (PlayerOneScore == 5)
            {
                MessageBox.Show("Player1 Won!");
                DisableAllButtons();
                return true;
            }
            if (PlayerTwoScore == 5)
            {
                MessageBox.Show("Player2 Won!");
                DisableAllButtons();
                return true;
            }
            return false;

        }
        
      

        private void setInitialState()
       {
            int[] flagButtons = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };
            Random rand = new Random();

         



           
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int number = rand.Next(1, 29);
                while (array.Contains(number))
                {
                    number = rand.Next(1, 29);
                }

                array[i] = number;
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }

            for(int i = 0; i < 5; i++)
            {
                playerOneFlags[i] = array[i];
            }

            for (int i = 0; i < 5; i++)
            {
                playerTwoFlags[i] = array[i+5];
            }



            byte[] flagPos = new byte[10];
            
            
            for(int i = 0; i<5; i++) {
                flagPos[i] = Convert.ToByte(playerOneFlags[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                flagPos[i+5] = Convert.ToByte(playerTwoFlags[i]);
            }
            

           
            sock.Send(flagPos);
            
            DisableAllButtons();

            if (playerOneFlags.Contains(1))
            {
                button1.BackColor = Color.Green;
                button1.Enabled = false;
            }
            if (playerOneFlags.Contains(2))
            {
                button2.BackColor = Color.Green;
                button2.Enabled = false;
            }
            if (playerOneFlags.Contains(3))
            {
                button3.BackColor = Color.Green;
                button3.Enabled = false;
            }
            if (playerOneFlags.Contains(4))
            {
                button4.BackColor = Color.Green;
                button4.Enabled = false;
            }
            if (playerOneFlags.Contains(5))
            {
                button5.BackColor = Color.Green;
                button5.Enabled = false;
            }
            if (playerOneFlags.Contains(6))
            {
                button6.BackColor = Color.Green;
                button6.Enabled = false;
            }
            if (playerOneFlags.Contains(7))
            {
                button7.BackColor = Color.Green;
                button7.Enabled = false;
            }
            if (playerOneFlags.Contains(8))
            {
                button8.BackColor = Color.Green;
                button8.Enabled = false;
            }
            if (playerOneFlags.Contains(9))
            {
                button9.BackColor = Color.Green;
                button9.Enabled = false;
            }
            if (playerOneFlags.Contains(10))
            {
                button10.BackColor = Color.Green;
                button10.Enabled = false;
            }
            if (playerOneFlags.Contains(11))
            {
                button11.BackColor = Color.Green;
                button11.Enabled = false;
            }
            if (playerOneFlags.Contains(12))
            {
                button12.BackColor = Color.Green;
                button12.Enabled = false;
            }
            if (playerOneFlags.Contains(13))
            {
                button13.BackColor = Color.Green;
                button13.Enabled = false;
            }
            if (playerOneFlags.Contains(14))
            {
                button14.BackColor = Color.Green;
                button14.Enabled = false;
            }
            if (playerOneFlags.Contains(15))
            {
                button15.BackColor = Color.Green;
                button15.Enabled = false;
            }
            if (playerOneFlags.Contains(16))
            {
                button16.BackColor = Color.Green;
                button16.Enabled = false;
            }
            if (playerOneFlags.Contains(17))
            {
                button17.BackColor = Color.Green;
                button17.Enabled = false;
            }
            if (playerOneFlags.Contains(18))
            {
                button18.BackColor = Color.Green;
                button18.Enabled = false;
            }
            if (playerOneFlags.Contains(19))
            {
                button19.BackColor = Color.Green;
                button19.Enabled = false;
            }
            if (playerOneFlags.Contains(20))
            {
                button20.BackColor = Color.Green;
                button20.Enabled = false;
            }
            if (playerOneFlags.Contains(21))
            {
                button21.BackColor = Color.Green;
                button21.Enabled = false;
            }
            if (playerOneFlags.Contains(22))
            {
                button22.BackColor = Color.Green;
                button22.Enabled = false;
            }
            if (playerOneFlags.Contains(23))
            {
                button23.BackColor = Color.Green;
                button23.Enabled = false;
            }
            if (playerOneFlags.Contains(24))
            {
                button24.BackColor = Color.Green;
                button24.Enabled = false;
            }
            if (playerOneFlags.Contains(25))
            {
                button25.BackColor = Color.Green;
                button25.Enabled = false;
            }
            if (playerOneFlags.Contains(26))
            {
                button26.BackColor = Color.Green;
                button26.Enabled = false;
            }
            if (playerOneFlags.Contains(27))
            {
                button27.BackColor = Color.Green;
                button27.Enabled = false;
            }
            if (playerOneFlags.Contains(28))
            {
                button28.BackColor = Color.Green;
                button28.Enabled = false;
            }

            EnableAllButtons();
        }
        

        private void DisableAllButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
        }

        private void EnableAllButtons()
        {
            if(button1.BackColor == Color.Red || button1.BackColor == Color.Green || button1.BackColor == Color.Blue || button1.BackColor == Color.Yellow)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

            if (button2.BackColor == Color.Red || button2.BackColor == Color.Green || button2.BackColor == Color.Blue || button2.BackColor == Color.Yellow)
            {
                button2.Enabled = false;
            }

            else
            {
                button2.Enabled = true;
            }

            if (button3.BackColor == Color.Red || button3.BackColor == Color.Green || button3.BackColor == Color.Blue || button3.BackColor == Color.Yellow)
            {
                button3.Enabled = false;
            }

            else
            {
                button3.Enabled = true;
            }

            if (button4.BackColor == Color.Red || button4.BackColor == Color.Green || button4.BackColor == Color.Blue || button4.BackColor == Color.Yellow)
            {
                button4.Enabled = false;
            }

            else
            {
                button4.Enabled = true;
            }

            if (button5.BackColor == Color.Red || button5.BackColor == Color.Green || button5.BackColor == Color.Blue || button5.BackColor == Color.Yellow)
            {
                button5.Enabled = false;
            }

            else
            {
                button5.Enabled = true;
            }

            if (button6.BackColor == Color.Red || button6.BackColor == Color.Green || button6.BackColor == Color.Blue || button6.BackColor == Color.Yellow)
            {
                button6.Enabled = false;
            }

            else
            {
                button6.Enabled = true;
            }

            if (button7.BackColor == Color.Red || button7.BackColor == Color.Green || button7.BackColor == Color.Blue || button7.BackColor == Color.Yellow)
            {
                button7.Enabled = false;
            }

            else
            {
                button7.Enabled = true;
            }

            if (button8.BackColor == Color.Red || button8.BackColor == Color.Green || button8.BackColor == Color.Blue || button8.BackColor == Color.Yellow)
            {
                button8.Enabled = false;
            }

            else
            {
                button8.Enabled = true;
            }

            if (button9.BackColor == Color.Red || button9.BackColor == Color.Green || button9.BackColor == Color.Blue || button9.BackColor == Color.Yellow)
            {
                button9.Enabled = false;
            }

            else
            {
                button9.Enabled = true;
            }

            if (button10.BackColor == Color.Red || button10.BackColor == Color.Green || button10.BackColor == Color.Blue || button10.BackColor == Color.Yellow)
            {
                button10.Enabled = false;
            }

            else
            {
                button10.Enabled = true;
            }

            if (button11.BackColor == Color.Red || button11.BackColor == Color.Green || button11.BackColor == Color.Blue || button11.BackColor == Color.Yellow)
            {
                button11.Enabled = false;
            }

            else
            {
                button11.Enabled = true;
            }

            if (button12.BackColor == Color.Red || button12.BackColor == Color.Green || button12.BackColor == Color.Blue || button12.BackColor == Color.Yellow)
            {
                button12.Enabled = false;
            }

            else
            {
                button12.Enabled = true;
            }

            if (button13.BackColor == Color.Red || button13.BackColor == Color.Green || button13.BackColor == Color.Blue || button13.BackColor == Color.Yellow)
            {
                button13.Enabled = false;
            }

            else
            {
                button13.Enabled = true;
            }

            if (button14.BackColor == Color.Red || button14.BackColor == Color.Green || button14.BackColor == Color.Blue || button14.BackColor == Color.Yellow)
            {
                button14.Enabled = false;
            }

            else
            {
                button14.Enabled = true;
            }

            if (button15.BackColor == Color.Red || button15.BackColor == Color.Green || button15.BackColor == Color.Blue || button15.BackColor == Color.Yellow)
            {
                button15.Enabled = false;
            }

            else
            {
                button15.Enabled = true;
            }

            if (button16.BackColor == Color.Red || button16.BackColor == Color.Green || button16.BackColor == Color.Blue || button16.BackColor == Color.Yellow)
            {
                button16.Enabled = false;
            }

            else
            {
                button16.Enabled = true;
            }

            if (button17.BackColor == Color.Red || button17.BackColor == Color.Green || button17.BackColor == Color.Blue || button17.BackColor == Color.Yellow)
            {
                button17.Enabled = false;
            }

            else
            {
                button17.Enabled = true;
            }

            if (button18.BackColor == Color.Red || button18.BackColor == Color.Green || button18.BackColor == Color.Blue || button18.BackColor == Color.Yellow)
            {
                button18.Enabled = false;
            }

            else
            {
                button18.Enabled = true;
            }

            if (button19.BackColor == Color.Red || button19.BackColor == Color.Green || button19.BackColor == Color.Blue || button19.BackColor == Color.Yellow)
            {
                button19.Enabled = false;
            }

            else
            {
                button19.Enabled = true;
            }

            if (button20.BackColor == Color.Red || button20.BackColor == Color.Green || button20.BackColor == Color.Blue || button20.BackColor == Color.Yellow)
            {
                button20.Enabled = false;
            }

            else
            {
                button20.Enabled = true;
            }

            if (button21.BackColor == Color.Red || button21.BackColor == Color.Green || button21.BackColor == Color.Blue || button21.BackColor == Color.Yellow)
            {
                button21.Enabled = false;
            }

            else
            {
                button21.Enabled = true;
            }

            if (button22.BackColor == Color.Red || button22.BackColor == Color.Green || button22.BackColor == Color.Blue || button22.BackColor == Color.Yellow)
            {
                button22.Enabled = false;
            }

            else
            {
                button22.Enabled = true;
            }

            if (button23.BackColor == Color.Red || button23.BackColor == Color.Green || button23.BackColor == Color.Blue || button23.BackColor == Color.Yellow)
            {
                button23.Enabled = false;
            }

            else
            {
                button23.Enabled = true;
            }

            if (button24.BackColor == Color.Red || button24.BackColor == Color.Green || button24.BackColor == Color.Blue || button24.BackColor == Color.Yellow)
            {
                button24.Enabled = false;
            }

            else
            {
                button24.Enabled = true;
            }

            if (button25.BackColor == Color.Red || button25.BackColor == Color.Green || button25.BackColor == Color.Blue || button25.BackColor == Color.Yellow)
            {
                button25.Enabled = false;
            }

            else
            {
                button25.Enabled = true;
            }

            if (button26.BackColor == Color.Red || button26.BackColor == Color.Green || button26.BackColor == Color.Blue || button26.BackColor == Color.Yellow)
            {
                button26.Enabled = false;
            }

            else
            {
                button26.Enabled = true;
            }

            if (button27.BackColor == Color.Red || button27.BackColor == Color.Green || button27.BackColor == Color.Blue || button27.BackColor == Color.Yellow)
            {
                button27.Enabled = false;
            }

            else
            {
                button27.Enabled = true;
            }

            if (button28.BackColor == Color.Red || button28.BackColor == Color.Green || button28.BackColor == Color.Blue || button28.BackColor == Color.Yellow)
            {
                button28.Enabled = false;
            }

            else
            {
                button28.Enabled = true;
            }

         
        }





        private void button1_Click(object sender, EventArgs e)
        {
            byte[] num = { 1 };
            sock.Send(num);

            if (playerTwoFlags.Contains(1)) // bunu her butona uygula
            {
                button1.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button1.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] num = { 5 };
            sock.Send(num);

            if (playerTwoFlags.Contains(5)) // bunu her butona uygula
            {
                button5.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button5.BackColor = Color.Red;
            }

            MessageReceiver.RunWorkerAsync();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            byte[] num = { 25 };
            sock.Send(num);

            if (playerTwoFlags.Contains(25)) // bunu her butona uygula
            {
                button25.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button25.BackColor = Color.Red;
            }



            MessageReceiver.RunWorkerAsync();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            byte[] num = { 23 };
            sock.Send(num);

            if (playerTwoFlags.Contains(23)) // bunu her butona uygula
            {
                button23.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button23.BackColor = Color.Red;
            }



            MessageReceiver.RunWorkerAsync();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            byte[] num = { 21 };
            sock.Send(num);
            if (playerTwoFlags.Contains(21)) // bunu her butona uygula
            {
                button21.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button21.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            byte[] num = { 24 };
            sock.Send(num);
            if (playerTwoFlags.Contains(24)) // bunu her butona uygula
            {
                button24.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button24.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            byte[] num = { 20 };
            sock.Send(num);
            if (playerTwoFlags.Contains(20)) // bunu her butona uygula
            {
                button20.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button20.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] num = { 2 };
            sock.Send(num);
            if (playerTwoFlags.Contains(2)) // bunu her butona uygula
            {
                button2.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button2.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            byte[] num = { 19 };
            sock.Send(num);
            if (playerTwoFlags.Contains(19)) // bunu her butona uygula
            {
                button19.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button19.BackColor = Color.Red;
            }



            MessageReceiver.RunWorkerAsync();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            byte[] num = { 26 };
            sock.Send(num);
            if (playerTwoFlags.Contains(26)) // bunu her butona uygula
            {
                button26.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button26.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            byte[] num = { 28 };
            sock.Send(num);
            if (playerTwoFlags.Contains(28)) // bunu her butona uygula
            {
                button28.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button28.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            byte[] num = { 27 };
            sock.Send(num);
            if (playerTwoFlags.Contains(27)) // bunu her butona uygula
            {
                button27.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button27.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            byte[] num = { 22 };
            sock.Send(num);
            if (playerTwoFlags.Contains(22)) // bunu her butona uygula
            {
                button22.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button22.BackColor = Color.Red;
            }



            MessageReceiver.RunWorkerAsync();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            byte[] num = { 18 };
            sock.Send(num);
            if (playerTwoFlags.Contains(18)) // bunu her butona uygula
            {
                button18.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button18.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            byte[] num = { 16 };
            sock.Send(num);
            if (playerTwoFlags.Contains(16)) // bunu her butona uygula
            {
                button16.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button16.BackColor = Color.Red;
            }



            MessageReceiver.RunWorkerAsync();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            byte[] num = { 14 };
            sock.Send(num);
            if (playerTwoFlags.Contains(14)) // bunu her butona uygula
            {
                button14.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button14.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            byte[] num = { 17 };
            sock.Send(num);
            if (playerTwoFlags.Contains(17)) // bunu her butona uygula
            {
                button17.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button17.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] num = { 8 };
            sock.Send(num);
            if (playerTwoFlags.Contains(8)) // bunu her butona uygula
            {
                button8.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button8.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            byte[] num = { 12 };
            sock.Send(num);
            if (playerTwoFlags.Contains(12)) // bunu her butona uygula
            {
                button12.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button12.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] num = { 7 };
            sock.Send(num);
            if (playerTwoFlags.Contains(7)) // bunu her butona uygula
            {
                button7.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button7.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            byte[] num = { 15 };
            sock.Send(num);
            if (playerTwoFlags.Contains(15)) // bunu her butona uygula
            {
                button15.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button15.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] num = { 6 };
            sock.Send(num);
            if (playerTwoFlags.Contains(6)) // bunu her butona uygula
            {
                button6.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button6.BackColor = Color.Red;
            }



            MessageReceiver.RunWorkerAsync();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            byte[] num = { 11 };
            sock.Send(num);
            if (playerTwoFlags.Contains(11)) // bunu her butona uygula
            {
                button11.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button11.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            byte[] num = { 10 };
            sock.Send(num);
            if (playerTwoFlags.Contains(10)) // bunu her butona uygula
            {
                button10.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button10.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            byte[] num = { 13 };
            sock.Send(num);
            if (playerTwoFlags.Contains(13)) // bunu her butona uygula
            {
                button13.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button13.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] num = { 9 };
            sock.Send(num);
            if (playerTwoFlags.Contains(9)) // bunu her butona uygula
            {
                button9.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button9.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] num = { 3 };
            sock.Send(num);
            if (playerTwoFlags.Contains(3)) // bunu her butona uygula
            {
                button3.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button3.BackColor = Color.Red;
            }


            MessageReceiver.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] num = { 4 };
            sock.Send(num);
            if (playerTwoFlags.Contains(4)) // bunu her butona uygula
            {
                button4.BackColor = Color.Blue;
                PlayerOneScore++;
                label3.Text = Convert.ToString(PlayerOneScore);
            }
            else
            {
                button4.BackColor = Color.Red;
            }



            MessageReceiver.RunWorkerAsync();
        }




        private void ReceiveMove()
        {
            Console.WriteLine("ReceiveMove triggered in app3");
            byte[] movebuffer = new byte[1];
            sock.Receive(movebuffer);

            Console.WriteLine(Convert.ToInt32(movebuffer[0]));
            int move = Convert.ToInt32(movebuffer[0]);

            if (playerOneFlags.Contains(move) && move == 1)
            {
                button1.BackColor = Color.Yellow;
                button1.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 1)
            {
                button1.BackColor = Color.Red;
                button1.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 2)
            {
                button2.BackColor = Color.Yellow;
                button2.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 2)
            {
                button2.BackColor = Color.Red;
                button2.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 3)
            {
                button3.BackColor = Color.Yellow;
                button3.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 3)
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 4)
            {
                button4.BackColor = Color.Yellow;
                button4.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 4)
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 5)
            {
                button5.BackColor = Color.Yellow;
                button5.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 5)
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 6)
            {
                button6.BackColor = Color.Yellow;
                button6.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 6)
            {
                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 7)
            {
                button7.BackColor = Color.Yellow;
                button7.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 7)
            {
                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 8)
            {
                button8.BackColor = Color.Yellow;
                button8.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 8)
            {
                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 9)
            {
                button9.BackColor = Color.Yellow;
                button9.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 9)
            {
                button9.BackColor = Color.Red;
                button9.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 10)
            {
                button10.BackColor = Color.Yellow;
                button10.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 10)
            {
                button10.BackColor = Color.Red;
                button10.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 11)
            {
                button11.BackColor = Color.Yellow;
                button11.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 11)
            {
                button11.BackColor = Color.Red;
                button11.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 12)
            {
                button12.BackColor = Color.Yellow;
                button12.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 12)
            {
                button12.BackColor = Color.Red;
                button12.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 13)
            {
                button13.BackColor = Color.Yellow;
                button13.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 13)
            {
                button13.BackColor = Color.Red;
                button13.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 14)
            {
                button14.BackColor = Color.Yellow;
                button14.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 14)
            {
                button14.BackColor = Color.Red;
                button14.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 15)
            {
                button15.BackColor = Color.Yellow;
                button15.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 15)
            {
                button15.BackColor = Color.Red;
                button15.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 16)
            {
                button16.BackColor = Color.Yellow;
                button16.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 16)
            {
                button16.BackColor = Color.Red;
                button16.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 17)
            {
                button17.BackColor = Color.Yellow;
                button17.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 17)
            {
                button17.BackColor = Color.Red;
                button17.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 18)
            {
                button18.BackColor = Color.Yellow;
                button18.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 18)
            {
                button18.BackColor = Color.Red;
                button18.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 19)
            {
                button19.BackColor = Color.Yellow;
                button19.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 19)
            {
                button19.BackColor = Color.Red;
                button19.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 20)
            {
                button20.BackColor = Color.Yellow;
                button20.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 20)
            {
                button20.BackColor = Color.Red;
                button20.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 21)
            {
                button21.BackColor = Color.Yellow;
                button21.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 21)
            {
                button21.BackColor = Color.Red;
                button21.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 22)
            {
                button22.BackColor = Color.Yellow;
                button22.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 22)
            {
                button22.BackColor = Color.Red;
                button22.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 23)
            {
                button23.BackColor = Color.Yellow;
                button23.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 23)
            {
                button23.BackColor = Color.Red;
                button23.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 24)
            {
                button24.BackColor = Color.Yellow;
                button24.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 24)
            {
                button24.BackColor = Color.Red;
                button24.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 25)
            {
                button25.BackColor = Color.Yellow;
                button25.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 25)
            {
                button25.BackColor = Color.Red;
                button25.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 26)
            {
                button26.BackColor = Color.Yellow;
                button26.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 26)
            {
                button26.BackColor = Color.Red;
                button26.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 27)
            {
                button27.BackColor = Color.Yellow;
                button27.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 27)
            {
                button27.BackColor = Color.Red;
                button27.Enabled = false;
            }
            if (playerOneFlags.Contains(move) && move == 28)
            {
                button28.BackColor = Color.Yellow;
                button28.Enabled = false;
                PlayerTwoScore++;
            }
            if (!playerOneFlags.Contains(move) && move == 28)
            {
                button28.BackColor = Color.Red;
                button28.Enabled = false;
            }
            
            label4.Text = Convert.ToString(PlayerTwoScore);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            if (server != null)
            {
                server.Stop();
            }
        }

       
    }
}
