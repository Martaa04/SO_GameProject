using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO_Game
{
    public partial class Interface : Form
    {
        Socket server;
        public Interface(Socket s)
        {
            InitializeComponent();
            this.server = s;
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
