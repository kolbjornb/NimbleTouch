namespace NimbleTouchMvvm
{
    /// <summary>
    /// Interface for setting parameters for the PageViewController
    /// </summary>
    /// <typeparam name="TParameters"></typeparam>
    public interface IPageViewController<in TParameters>
    {
        void SetParameters(TParameters parameters);
    }
}