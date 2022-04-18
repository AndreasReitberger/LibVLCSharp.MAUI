using Foundation;
using LibVLCSharp.MAUI.Shared;
using UIKit;

namespace LibVLCSharp.MAUI.Platforms.iOS
{
    /// <summary>
    /// Force orientation of iOS device.
    /// In iOS client project, Developer should override the GetSupportedInterfaceOrientations method.
    /// Refer to the sample LibVLCSharp.Forms.Sample.MediaElement to see how to use it.
    /// </summary>
    public class OrientationHandler : IOrientationHandler
    {
        private const string OrientationLabel = "orientation";
        private const string LockLabel = "Lock";
        private const string UnLockLabel = "UnLock";

        /// <summary>
        /// Lock device's orientation.
        /// </summary>
        public void LockOrientation()
        {
            MessagingCenter.Send(this, LockLabel);
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIDevice.CurrentDevice.Orientation), new NSString(OrientationLabel));
        }

        /// <summary>
        /// Unlock device's orientation.
        /// </summary>
        public void UnLockOrientation() => MessagingCenter.Send(this, UnLockLabel);
    }
}
