namespace AbstractFactory.Windows
{
    public class WindowsScreenGenerator : IScreenGenerator
    {
        public IPage CreatePage()
        {
            return new WindowsPage();
        }

        public IViewComponent CreateViewComponent()
        {
            return new WindowsViewComponent();
        }
    }
}
