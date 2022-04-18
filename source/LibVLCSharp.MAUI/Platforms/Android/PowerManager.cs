using Android.Views;
using LibVLCSharp.MAUI.Shared;

namespace LibVLCSharp.MAUI.Platforms.Android
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
            get => (Platform.Activity?.Window?.Attributes?.Flags ?? 0).HasFlag(WindowManagerFlags.KeepScreenOn);
            set
            {
                var window = Platform.Activity?.Window;
                if (window != null)
                {
                    if (value)
                    {
                        window.AddFlags(WindowManagerFlags.KeepScreenOn);
                    }
                    else
                    {
                        window.ClearFlags(WindowManagerFlags.KeepScreenOn);
                    }
                }
            }
        }
    }
}
