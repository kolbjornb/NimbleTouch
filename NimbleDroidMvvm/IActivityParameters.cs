namespace NimbleDroidMvvm
{
    /// <summary>
    ///     Interface for parameters to be passed between activities. You can either implement this interface and 
    /// provide your own id or just inherit ActivityParameters.
    /// </summary>
    public interface IActivityParameters
    {
        string Id { get; }
    }
}