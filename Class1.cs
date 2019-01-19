using System;
using System.IO;
using System.Threading.Tasks;
using IrrKlang;
using NAudio.Wave;

namespace CSharp._01.HelloWorld
{
    class Class1
    {
        [STAThread]
        public void Audio(string path)
        {
            // start the sound engine with default parameters
            ISoundEngine engine = new ISoundEngine();

            // To play a sound, we only to call play2D(). The second parameter
            // tells the engine to play it looped.

            engine.Play2D(path);

            Console.Out.WriteLine("\nHello World");

            do
            {
                Console.Out.WriteLine("Press any key to play some sound, press 'q' to quit.");

                // play a single sound
                //engine.Play2D("../../media/bell.wav");
                Console.ReadLine();
            }
            while (true);
        }
    }
}