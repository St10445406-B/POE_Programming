using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPOE
{
    class visual
    {
            //class for the audio. uses play sync to play promt user after the recording
            public void Audio()
            {
                SoundPlayer play = new SoundPlayer("./aud.wav");
                play.PlaySync();


            }
            //designs method to display the logo
            public void logo()
            {
                String logo = @"                                                     __
                              .__                         / |
                             /  /                         |  \
                            /   |                     ,-------'_
                       ____/     \_________,     ,_--""      _/  \_
         _______------'                     `---""          ,-\___/
     _--""                                               ,-""
 ___(___                                          ,__--""
(-------0       cybersecurity awareness     __---""
 `--___                                    /
       `--___\                _______-----'
             \\    (____-----'
              \\    \_
               `""`..__\";


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(logo);
                Console.WriteLine("--------------------------------------------------------");
                Console.ResetColor();

            }

        }
    }


