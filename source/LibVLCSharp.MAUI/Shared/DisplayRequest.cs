using LibVLCSharp.Shared.MediaPlayerElement;

namespace LibVLCSharp.MAUI.Shared
{
    /// <summary>
    /// Represents a display request
    /// </summary>
    internal class DisplayRequest : IDisplayRequest
    {
        //private IPowerManager PowerManager => DependencyService.Get<IPowerManager>();

        /// <summary>
        /// Activates a display request
        /// </summary>
        public void RequestActive()
        {
            DeviceDisplay.KeepScreenOn = true;
            //PowerManager.KeepScreenOn = true;
        }

        /// <summary>
        /// Deactivates a display request
        /// </summary>
        public void RequestRelease()
        {
            DeviceDisplay.KeepScreenOn = false;
            //PowerManager.KeepScreenOn = false;
        }
    }
}
