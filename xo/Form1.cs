using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace xo
{

    public partial class Form1 : Form
    {
        byte[] bates = new byte[1024];
        TcpListener serv;
        TcpClient cl;
        NetworkStream nsCL;
        IPEndPoint Ep;
        string str;
        bool[] chek = new bool[10];
        byte[] arChat = new byte[1024];
        string code = "TextMessageSending879543167";
        string chatText;
        public Form1()
        {
            InitializeComponent();
            Ep = new IPEndPoint(IPAddress.Parse("25.75.45.246"), 59619);
            serv = new TcpListener(Ep);
            serv.Start();
            
            //25.75.45.246
            //10.1.89.209
        }



         private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            nsCL.Dispose();//закриває стрім
        }

     async    private void Form1_Load(object sender, EventArgs e)
        {
            string text = await Task<string>.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (arChat != null && nsCL != null)
                    {
                        int n = nsCL.Read(arChat, 0, arChat.Length);
                        string chatText = Encoding.ASCII.GetString(arChat, 0, n);
                        if (chatText.StartsWith(code))
                            return chatText.Substring(code.Length);
                        else
                            return null;
                    }
                }
            });
            while (true)
            {
                if (text != null)
                    listBoxChat.Items.Add("Server: " + text);
            }
            //if (cl.Connected)
            //{
            //    label1.Text = "Client conected";
            //}


            // ClearForm();
            //var str = await Task<string>.Factory.StartNew(() =>
            //{

            //    while (true)
            //    {
            //        cl = serv.AcceptTcpClient();
            //        cl.GetStream();
            //        nsCL = cl.GetStream();
            //        //nsCL.Write(Encoding.ASCII.GetBytes("Hello"), 0, "Hello".Length);
            //        int n = nsCL.Read(bates, 0, 1024);

            //        return Encoding.ASCII.GetString(bates, 0, n);


            //    }
            //});


        }

     //   bool[] check = new bool[];
        private void button1_Click(object sender, EventArgs e)
        {
            if (chek[1] == true)
            {

                button1.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("1"), 0, "1".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "Хід Противника";
                    textBox1.BackColor = Color.Red;
                    rread();
                }
                               
                chek[1] = false;
            }          
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chek[2] == true)
            {
                button2.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("2"), 0, "2".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "Хід Противника";
                    textBox1.BackColor = Color.Red;
                    rread();
                }
                chek[2] = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chek[3] == true)
            {
                button3.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("3"), 0, "3".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "nono";
                    rread();
                }
                chek[3] = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chek[4] == true)
            {
                button4.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("4"), 0, "4".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "nono";
                    rread();
                }
                chek[4] = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (chek[5] == true)
            {
                button5.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("5"), 0, "5".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "nono";
                    rread();
                }
                chek[5] = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (chek[6] == true)
            {
                button6.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("6"), 0, "6".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "nono";
                    rread();
                }
                chek[6] = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (chek[7] == true)
            {
                button7.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("7"), 0, "7".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "nono";
                    rread();
                }
                chek[7] = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (chek[8] == true)
            {
                button8.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("8"), 0, "8".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "nono";
                    rread();
                }
                chek[8] = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (chek[9] == true)
            {
                button9.Text = "X";
                if (nsCL.CanWrite)
                {
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    nsCL.Write(Encoding.ASCII.GetBytes("9"), 0, "9".Length);
                }
                if (nsCL.CanRead)
                {
                    textBox1.Text = "Хід Противника";
                    textBox1.BackColor = Color.Red;
                    rread();
                }
                chek[9] = false;
            }
        }
     
       async private void rread()
        {
            str = await Task<string>.Factory.StartNew(() =>
            {
                int n = nsCL.Read(bates, 0, 1024);
                return str = Encoding.ASCII.GetString(bates, 0, n);
            });

          

            switch (str)
            {
                case "1":
                    button1.Text = "0";
                    chek[1] = false;
                    textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "2":
                    button2.Text = "0";
                    chek[2] = false; textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "3":
                    button3.Text = "0";
                    chek[3] = false; textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "4":
                    button4.Text = "0";
                    chek[4] = false; textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "5":
                    button5.Text = "0";
                    chek[5] = false; textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "6":
                    button6.Text = "0";
                    chek[6] = false; textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "7":
                    button7.Text = "0";
                    chek[7] = false; textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "8":
                    button8.Text = "0";
                    chek[8] = false; textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "9":
                    button9.Text = "0";
                    chek[9] = false; textBox1.Text = "Ваш хід";
                    textBox1.BackColor = Color.Green;
                    break;
                case "10":
                    MessageBox.Show("Player ready!");
                    ClearForm();
                    break;
                case "11":
                    MessageBox.Show("Player not ready((");
                    break;
            }

        }
        private void ClearForm()
        {
            for (int i = 0; i < 10; i++)
            {
                chek[i] = true;
            }
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            cl = serv.AcceptTcpClient();
            cl.GetStream();
            nsCL = cl.GetStream();
            nsCL.Write(Encoding.ASCII.GetBytes("0"), 0, "0".Length);                   
            rread();
            rread();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBoxChat.Text != null)
            {
                listBoxChat.Items.Add("Me: " + textBoxChat.Text);
                string text = code + textBoxChat.Text;
                nsCL.Write(Encoding.ASCII.GetBytes(text), 0, text.Length);
                textBoxChat.Clear();
            }
        }
    }
}

