using Android.App;
using Android.Content;

namespace NimbleDroidMvvm
{
    /// <summary>
    ///     Class for handling starting of activities and passing parameters between activities. Gives some extenstion to
    /// </summary>
    public static class ActivityStarter
    {
        private const string ExtraIdParameterName = "Id";

        /// <summary>
        ///     Starts a new activity with the specified type and passes the parameters to the new activity.
        /// </summary>
        /// <typeparam name="TActivity">The type of the activity to start.</typeparam>
        /// <param name="activity">This activity.</param>
        /// <param name="parameters">The parameters to be passed in to started activity.</param>
        public static void StartActivity<TActivity>(this Activity activity, IActivityParameters parameters) where TActivity : Activity
        {
            //Create intent of the right type and put the parameters id in the intent extra
            Intent intent = new Intent(activity, typeof(TActivity));
            intent.PutExtra(ExtraIdParameterName, parameters.Id);

            NimbleMvvmApplication application = (NimbleMvvmApplication)activity.Application;
            application.AddParameters(parameters.Id, parameters);

            //Start the activity
            activity.StartActivity(intent);
        }

        /// <summary>
        ///     Gets the parameters for the activity with the specified type,  and deletes from the list.
        ///     This means that this method can only be called once for any given activity.
        /// </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="activity"> </param>
        /// <returns> </returns>
        public static T GetAndRemoveParameters<T>(Activity activity) where T : class, IActivityParameters
        {
            //Get the parameter is passed in with the intent
            string parametersId = activity.Intent.Extras.GetString(ExtraIdParameterName);
            NimbleMvvmApplication application = (NimbleMvvmApplication)activity.Application;
            T parameters = (T)application.ActivityParameters[parametersId];

            //Removes the parameters from list. 
            application.ActivityParameters.Remove(parametersId);

            return parameters;
        }
    }
}