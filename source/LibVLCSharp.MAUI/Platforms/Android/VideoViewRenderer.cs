using Android.Content;
using LibVLCSharp.MAUI.Shared;
using LibVLCSharp.Shared;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform;

namespace LibVLCSharp.MAUI.Platforms.Android
{
    /// <summary>
    /// Xamarin.Forms custom renderer for the Android VideoView
    /// </summary>
    //[assembly: ExportRenderer(typeof(VideoView), typeof(VideoViewRenderer))]
    public class VideoViewRenderer : ViewRenderer<LibVLCSharp.MAUI.Shared.VideoView, LibVLCSharp.Platforms.Android.VideoView>
    {
        /// <summary>
        /// Main constructor (empty)
        /// </summary>
        /// <param name="context">Android context</param>
        public VideoViewRenderer(Context context) : base(context)
        {
        }

        /// <summary>
        /// Native control management during lifecycle events
        /// </summary>
        /// <param name="e">lifecycle event</param>
        protected override void OnElementChanged(ElementChangedEventArgs<VideoView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    SetNativeControl(new LibVLCSharp.Platforms.Android.VideoView(Context!));

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
            Control.TriggerLayoutChangeListener();
        }
    }
}
