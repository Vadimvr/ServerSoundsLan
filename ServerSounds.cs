using NAudio.Wave;
using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace serverSound
{
    public partial class ServerSounds : Form
    {
        private bool play = false;
        Socket client;
        WaveIn micSound;
        int port = 8855;
        IPEndPoint clientIPAndPort;
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
            if (!play)
            {
                port = (int)portNUD.Value;
                clientIPAndPort = new IPEndPoint(IPAddress.Parse(ipAddres.Text), port);
                micSound = new WaveIn();
                micSound.BufferMilliseconds = 50;
                micSound.WaveFormat = new WaveFormat(36000, 32, 2);
                micSound.DataAvailable += StartSend;
                client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                micSound.StartRecording();
                play = true;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (play)
            {
                play = false;
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
}