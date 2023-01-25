﻿using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class MP3Player : PlayerHandler
    {
        public override void Play(string filepath)
        {
           //Eger gelen dosya mp3 ise cal
            if (filepath.EndsWith(".mp3"))
            {
                Console.WriteLine(filepath + " dosyasi calindi");
            }
            else 
            { 
                //degilse ve sonraki plaer kayitli ise oraya gonder
                if (_SonrakiPlayerHandler != null)
                {
                    _SonrakiPlayerHandler.Play(filepath);
                }
            }
        }
    }
}
