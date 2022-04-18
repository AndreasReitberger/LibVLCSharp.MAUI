using LibVLCSharp.Shared.MediaPlayerElement;
namespace LibVLCSharp.MAUI.Shared
{
    /// <summary>
    /// Monitors display-related information for an application view.
    /// </summary>
    internal class DisplayInformation : IDisplayInformation
    {
        /// <summary>
        /// Gets the scale factor
        /// </summary>
        public double ScalingFactor => 1; // DeviceDisplay.MainDisplayInfo.Density
        //public double ScalingFactor => Device.Info.ScalingFactor;
    }
}
