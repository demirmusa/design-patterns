namespace AbstractFactory.Mobile
{
    public class MobileScreenGenerator : IScreenGenerator
    {
        public IPage CreatePage()
        {
            return new MobilePage();
        }

        public IViewComponent CreateViewComponent()
        {
            return new MobileViewComponent();
        }
    }
}
