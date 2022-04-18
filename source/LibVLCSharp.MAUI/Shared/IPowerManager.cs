namespace LibVLCSharp.MAUI.Shared
{
    /// <summary>
    /// Interface for power management.
    /// </summary>
    [Obsolete("MAUI has a new object for this => DeviceDisplay.KeepScreenOn")]
    public interface IPowerManager
    {
        /// <summary>
        /// Gets or sets a value indicating whether the screen should be kept on.
        /// </summary>
        bool KeepScreenOn { get; set; }
    }
}
