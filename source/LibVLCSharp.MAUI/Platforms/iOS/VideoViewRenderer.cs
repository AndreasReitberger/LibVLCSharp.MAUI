using LibVLCSharp.Shared;
using Microsoft.Maui.Controls.Platform;
using Foundation;
using Microsoft.Maui.Controls.Handlers.Compatibility;

namespace LibVLCSharp.MAUI.Platforms.iOS
{

    public class VideoViewRenderer : ViewRenderer<LibVLCSharp.MAUI.Shared.VideoView, LibVLCSharp.Platforms.iOS.VideoView>
    {
        /// <summary>
        /// Native control management during lifecycle events
        /// </summary>
        /// <param name="e">lifecycle event</param>
        protected override void OnElementChanged(ElementChangedEventArgs<LibVLCSharp.MAUI.Shared.VideoView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(new LibVLCSharp.Platforms.iOS.VideoView());
                    e.NewElement.MediaPlayerChanging += OnMediaPlayerChanging;
                    if (Control!.MediaPlayer != e.NewElement.MediaPlayer)
                    {
                        OnMediaPlayerChanging(this, new MediaPlayerChangingEventArgs(Control!.MediaPlayer, e.NewElement.MediaPlayer));
                    }
                }
            }

            if (e.OldElement != null)
            {
                e.OldElement.MediaPlayerChanging -= OnMediaPlayerChanging;
            }
        }

        private void OnMediaPlayerChanging(object? sender, MediaPlayerChangingEventArgs e)
        {
            Control.MediaPlayer = e.NewMediaPlayer;
        }
    }
}
