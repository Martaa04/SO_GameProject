using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SO_Game;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace SO_Game
{
    public partial class Main : Form
    {
        Socket server;
        Thread atender;
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 50175);


            //We create the socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {

                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Connected successfully");
                ThreadStart ts = delegate { AtenderServidor(); };

                atender = new Thread(ts);
                atender.Start();


            }
            catch (SocketException)
            {
                MessageBox.Show("Error connecting to server", "Error");
                this.Close();

            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            //string mensaje = "0/";
            //byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            //server.Send(msg);
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            atender.Abort();
            MessageBox.Show("Disconnected");
            this.Close();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            byte[] output = System.Text.Encoding.ASCII.GetBytes("2/" + usernameText.Text + "/" + passwordText.Text);
            server.Send(output);
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (password_TextBox.Text != ConfirmPassword_TextBox.Text)
                {
                    MessageBox.Show("The passwords do not match. Please, check it again."); //Error of not matching passwords
                }

                else
                {
                    byte[] register = System.Text.Encoding.ASCII.GetBytes("1/" + email.Text + "/" + Username_TextBox.Text + "/" + password_TextBox.Text);
                    server.Send(register);
                }
            }

            catch (SocketException ex)
            {
                MessageBox.Show("The connection with the sever failed");
            }
        }

        private void query_Click(object sender, EventArgs e)
        {
            try
            {
                string message = " "; // Prepare the message to send to the server
              

                if (PlayerGame.Checked)
                {
                    message = "3/";
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg1 = System.Text.Encoding.ASCII.GetBytes(message);
                    //server.Send(msg1);

                    if (server != null && server.Connected)
                    {
                        server.Send(msg1);
                    }
                    else
                    {
                        MessageBox.Show("Socket is not connected.");
                    }

                }
                else if (winner.Checked)
                {
                    message = "4/" + gameid.Text; // The code for fetching the winner by game ID
                                                  // Enviamos al servidor el nombre tecleado
                    byte[] msg2 = Encoding.ASCII.GetBytes(message);
                    server.Send(msg2);
                } 
                else if (gamesPlayed.Checked)  // New case for Games Played by a Player
                {
                    message = "6/" + playerName.Text; // "6" represents the new query
                                                      // Enviamos al servidor el nombre tecleado                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
                    byte[] msg3 = System.Text.Encoding.ASCII.GetBytes(message);
                    server.Send(msg3);

                }
            }
            catch (SocketException ex)
            {
                // If there's a socket exception, show an error message
                MessageBox.Show("Error connecting to the server: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "5/";
            byte[] msg = Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void AtenderServidor() //receive ALL the messages from the server!!
        {
            try
            {
                while (true)
                {
                    //Recibimos mensaje del servidor
                    byte[] msg2 = new byte[1024];
                    Array.Clear(msg2, 0, msg2.Length);
                    int receivedbytes = server.Receive(msg2);
                    string[] trozos = Encoding.ASCII.GetString(msg2, 0, receivedbytes).Split('/');
                    string codigo = (trozos[0]);
                    string mensaje;

                    switch (codigo)
                    {
                        case "1": //query 1
                            Console.WriteLine("I am executing query1");
                            string mess = trozos[1].Split('\0')[0];
                            string formattedMessage = mess.Replace(",", "\n");
                            MessageBox.Show(formattedMessage);
                            break;

                        case "2": //query 2
                            mensaje = trozos[1].Split('\0')[0];
                            MessageBox.Show(mensaje);
                            break;
                        case "3": //query 3
                            mensaje = trozos[1].Split('\0')[0];
                            MessageBox.Show(mensaje);
                            break;

                        case "4": //Connected List 
                            mensaje = trozos[1].Split('\0')[0];
                            Console.WriteLine("Llamando a ConnectedList...");
                            try
                            {
                                string[] partes = mensaje.Split(',');
                                //string messi = partes[partes.Length].Split('\0')[0];
                                string connected = partes[0];
                                label_users_connected.Text = connected;
                                //MessageBox.Show(mensaje);
                                dataGridView1.Rows.Clear();
                                //dataGridView1.Columns.Clear(); // Clear columns first
                                //dataGridView1.Rows.Add("Connected Players");
                                for (int i = 1; i < partes.Length; i++)
                                {
                                    dataGridView1.Rows.Add(partes[i]);
                                }
                                break;
                            }
                            catch (SocketException ex)
                            {
                                MessageBox.Show("Error connecting to the server: " + ex.Message);
                            }
                            break;
                        case "5":
                            mensaje = trozos[1].Split('\0')[0];
                            switch (Convert.ToInt32(mensaje))
                            {
                                case 0:
 
                                    MessageBox.Show("The email is already registered. Use another one.");

                                    break;

                                case 1:

                                    MessageBox.Show("This username already exists. Please, choose another one.");
    
                                    break;

                                case 2:
  
                                    MessageBox.Show("The email must have between 15 and 80 characters.");
                                    break;

                                case 3:

                                        MessageBox.Show("Your username must have between 3 and 80 characters.");
                                    
                                    break;


                                case 4:
                                    MessageBox.Show("Your passwrd must have between 8 and 20 characters");
                                    break;


                                case 5:
                                    MessageBox.Show("Register was unsuccessful. Please, try again.");
                                    break;

                                case 6:
                                    MessageBox.Show("New user registered successfully!");
                                    break;
                            }
                            break;

                        case "6": //Login
                            mensaje = trozos[1].Split('\0')[0];
                            int code = Convert.ToInt32(mensaje);
                            switch (code)
                            {
                                case 0:
                                    MessageBox.Show("The userame does not exist.");
                                    break;
                                case 1:
                                    MessageBox.Show("The data was not found in the database");
                                    break;

                                case 2:
                                    MessageBox.Show("Login error. Please, try again.");
                                    break;

                                case 3:
                                    MessageBox.Show("Login successful");        
                                    break;
                                case 4:
                                    MessageBox.Show("The password is not correct.");
                                    break;
                                default:
                                    MessageBox.Show(Convert.ToString(mensaje));
                                    break;
                            }
                            break;
                    }

                }
            }

            catch (SocketException ex)
            {
                MessageBox.Show($"Socket error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }
        }

    }
}