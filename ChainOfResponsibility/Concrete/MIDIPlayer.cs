using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class MIDIPlayer:PlayerHandler
    {
        public override void Play(string filepath)
        {
            //Eger gelen dosya mp3 ise cal
            if (filepath.EndsWith(".midi"))
            {
                Console.WriteLine(filepath + " dosyasi calindi");
            }
            else
            {
                //degilse zincirin son haklasidir
                Console.WriteLine("Gecersiz dosya formati");
            }
        }
    }
}
