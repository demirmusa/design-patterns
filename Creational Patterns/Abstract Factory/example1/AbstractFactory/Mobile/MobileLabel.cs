using System;

namespace AbstractFactory.Mobile
{
    public class MobileLabel : ILabel
    {
        public void SetText(string text)
        {
            Console.WriteLine($"Mobile label text has been set to {text}");
        }
    }
}
