namespace NimbleDroidMvvm
{
    /// <summary>
    /// Interface for setting parameters for the PageViewController
    /// </summary>
    /// <typeparam name="TParameters"></typeparam>
    public interface IPageActivity<in TParameters>
    {
        void SetParameters(TParameters parameters);
    }
}