namespace AbstractFactory.Mobile
{
    public class MobileViewComponent : IViewComponent
    {
        public ILabel CreateLabel()
        {
            return new MobileLabel();
        }

        //...
    }
}
