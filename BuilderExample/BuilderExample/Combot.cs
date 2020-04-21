using System.Collections.Generic;

namespace BuilderExample
{
    internal class Combot
    {
        private Dictionary<string, string> parts = new Dictionary<string, string>();
        private string name;

        public Combot(string name)
        {
            this.name = name;
        }

        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void Print()
        {
            System.Console.WriteLine($"COMBOT ({name})\n Torso: {parts["torso"]}\n Legs: {parts["legs"]}\n Left Arm: {parts["leftArm"]}\n Right Arm: {parts["rightArm"]}\n\n");
        }
    }
}