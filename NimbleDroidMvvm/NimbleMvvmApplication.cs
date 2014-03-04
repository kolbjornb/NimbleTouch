using System;
using System.Collections.Generic;
using Android.App;
using Android.Runtime;

namespace NimbleDroidMvvm
{
    /// <summary>
    /// Inherit this Application class when implementing your own application class. 
    /// Override OnCreate in yout application class to implement your initializations.
    /// Remember to add [Application] attribute to your class.
    /// Remember to add 	
    /// <code>&lt;application android:name="com.yourApplicationClass"&gt;&lt;/application&gt;</code> 
    /// to your Manifest.xml file
    /// </summary>
    public class NimbleMvvmApplication : Application
    {
        /// <summary>
        /// Holds a dictionary of parameters passed when starting activities.
        /// </summary>
        public readonly IDictionary<string, IActivityParameters> ActivityParameters = new Dictionary<string, IActivityParameters>();

        /// <summary>
        /// This constructor signature is called by Android. 
        /// </summary>
        /// <param name="javaReference"></param>
        /// <param name="transfer"></param>
        // ReSharper disable MemberCanBeProtected.Global
        public NimbleMvvmApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public void AddParameters(string id, IActivityParameters parameters)
        {
            ActivityParameters.Add(id, parameters);
        }

    }
}