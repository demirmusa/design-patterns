namespace AbstractFactory
{
    public interface IScreenGenerator
    {
        IPage CreatePage();

        IViewComponent CreateViewComponent();
    }
}
