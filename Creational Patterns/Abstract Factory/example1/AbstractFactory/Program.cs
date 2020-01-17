using AbstractFactory.Mobile;
using AbstractFactory.Windows;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeMobile();
            InitializeWindows();
        }

        private static void InitializeMobile()
        {
            IScreenGenerator screenGenerator = new MobileScreenGenerator();

            screenGenerator.CreatePage();

            IViewComponent component = screenGenerator.CreateViewComponent();
            ILabel label = component.CreateLabel();
            label.SetText("Musa Demir");
        }

        private static void InitializeWindows()
        {
            IScreenGenerator screenGenerator = new WindowsScreenGenerator();

            screenGenerator.CreatePage();

            IViewComponent component = screenGenerator.CreateViewComponent();
            ILabel label = component.CreateLabel();
            label.SetText("Musa Demir");
        }
    }
}
