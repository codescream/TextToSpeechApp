using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TextToSPeechApp;

namespace DemoHarnessUpd
{
    public class Entry
    {
        static Test test = new Test();
        public static string path = "";
        public void Speak(string speech)
        {
            test.TextSpeech(speech).Wait();
            NetCoreSample.Audio(path);
        }
    }
}