/*
 Program: Form1.cs
 Desc. : 

 
 */


using System.Runtime.InteropServices.Marshalling;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace DemoSocketsMarch2026
{




    public partial class Form1 : Form
    {


        Socket? ConnSock = null;

        
        public Form1()
        {
            InitializeComponent();


            
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                ConnSock = new Socket(
                                AddressFamily.InterNetwork, // IP V4 address scheme
                                SocketType.Stream,          // streaming socket (connection-based)
                                ProtocolType.Tcp);

                ConnSock.BeginConnect(
                    TB_Text.Text,        // target address (a string, supports DNS lookup)
                    1666,               // target port
                    cbConnectDone,      // callback function when operation completes
                    null);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("BTN_Connect_Click method");
                System.Diagnostics.Trace.WriteLine(ex.Message);
            }
        }

        private void cbConnectDone(IAsyncResult ar)
        {
            try
            {
                ConnSock.EndConnect(ar); // complete the connection attempt

                // no error! We should be connected!

                // update a control in the form, Invoke is required
                Invoke(new Action(() => { Text = "Connected!"; }));
            }
            catch (Exception err)
            {
                System.Diagnostics.Trace.WriteLine("cbConnectDone method");
                System.Diagnostics.Trace.WriteLine(err.Message);

                // not connected... what should you do?
            }
        }

    }
}
