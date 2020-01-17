using System;

namespace AbstractFactory.Windows
{
    public class WindowsLabel : ILabel
    {
        public void SetText(string text)
        {
            Console.WriteLine($"Windows label text has been set to {text}");
        }
    }
}
