using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;

namespace Ch13Ex03
{
    //public delegate void MessageHandler(string messageText);
    public class Connection
    {
        public event EventHandler<MessageArrivedEventArgs> MessageArrived;
        public string Name { get; set; }
        private Timer pollTimer;
        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
        }
        public void Connect() => pollTimer.Start();
        public void DisConnect() => pollTimer.Stop();
        private static Random random = new Random();
        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            WriteLine("Checking for new message.");
            if((random.Next(9) == 0) && (MessageArrived != null))
            {
                MessageArrived(this, new MessageArrivedEventArgs("Heelo Mami!!"));
            }
        }
    }
}
