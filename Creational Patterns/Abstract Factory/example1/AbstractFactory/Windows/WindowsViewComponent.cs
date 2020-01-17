namespace AbstractFactory.Windows
{
    public class WindowsViewComponent : IViewComponent
    {
        public ILabel CreateLabel()
        {
            return new WindowsLabel();
        }
    }
}
