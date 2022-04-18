using LibVLCSharp.MAUI.Shared;
using UIKit;

namespace LibVLCSharp.MAUI.Platforms.iOS
{
    /// <summary>
    /// Power manager.
    /// </summary>
    [Obsolete("MAUI => DeviceDisplay.KeepScreenOn = true;")]
    internal class PowerManager : IPowerManager
    {
        /// <summary>
        /// Gets or sets a value indicating whether the screen should be kept on.
        /// </summary>
        public bool KeepScreenOn
        {
            get => UIApplication.SharedApplication.IdleTimerDisabled;
            set => UIApplication.SharedApplication.IdleTimerDisabled = value;
        }
    }
}
