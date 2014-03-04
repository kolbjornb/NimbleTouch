using System;

namespace NimbleDroidMvvm
{
    /// <summary>
    ///     Base class for parameters to be passed between activities. Creates a unique id on instansiation.
    /// </summary>
    public class ActivityParameters : IActivityParameters
    {
        protected ActivityParameters()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; private set; }
    }
}