using NAudio.Wave;
using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace serverSound
{
    public partial class ServerSounds : Form
    {
        Socket client;
        WaveIn micSound;
        int port = 8855;
        IPEndPoint clientIPAndPort ;
        public ServerSounds()
        {
            InitializeComponent();
           
        }
        private void StartSend(object sender, WaveInEventArgs e)
        {
            try
            {
                client.SendTo(e.Buffer, clientIPAndPort);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {

            port = (int)portNUD.Value;
            clientIPAndPort = new IPEndPoint(IPAddress.Parse(ipAddres.Text), 8855);
            micSound = new WaveIn();
            micSound.BufferMilliseconds = 100;
            micSound.WaveFormat = new WaveFormat(36000, 32, 2);
            micSound.DataAvailable += StartSend;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            micSound.StartRecording();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            client.Close();
            client.Dispose();

            if (micSound != null)
            {
                micSound.Dispose();
                micSound = null;
            }
        }
    }
}