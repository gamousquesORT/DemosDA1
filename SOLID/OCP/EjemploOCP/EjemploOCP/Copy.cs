using System;

namespace EjemploOCP
{
    public class Copy
    {
        private KeyBoardReader keyboardInput = new KeyBoardReader();
        private MonitorOutput display = new MonitorOutput();

        public void CopyStrings()
        {
            string inputValue;

            while ((inputValue = keyboardInput.ReadKeyboard()) != "")
                display.WriteToMonitor(inputValue);
        }
    }

    public class KeyBoardReader
    {
        public string ReadKeyboard()
        {
            Console.Write("->");
            return Console.ReadLine();
        }
    }

    public class MonitorOutput
    {
        public void WriteToMonitor(string outputValue)
        {
            Console.Write("<-");
            Console.WriteLine(outputValue);
        }
    }
}