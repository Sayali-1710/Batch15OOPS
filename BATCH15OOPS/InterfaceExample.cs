using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPSAssign
{
    internal interface Iplayable
    {
        void play();
    }

    public class videoplayer : Iplayable
    {
        public void play()
        {
            Console.WriteLine("The Video is Playing!!!");
        }
    }

    public class musicplayer : Iplayable
    {
        public void play()
        {
            Console.WriteLine("The Music is Playing!!!");
        }
    }

    interface InterfaceExample
    {
        static void Main()
        {
            Iplayable Video = new videoplayer();
            Iplayable Music = new musicplayer();

            Video.play();
            Music.play();
        }
    }
}
