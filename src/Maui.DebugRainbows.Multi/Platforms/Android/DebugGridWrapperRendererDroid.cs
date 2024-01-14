
using Android.Content;
using DebugRainbowCompat.SharedPlatform;
using AView = Android.Views.View;
using Microsoft.Maui.Controls.Platform;


namespace Maui.DebugRainbows.Multi
{
    public class DebugGridWrapperRendererDroid : Microsoft.Maui.Controls.Handlers.Compatibility.ViewRenderer<DebugGridWrapper,AView>
    {
        public DebugGridWrapperRendererDroid(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<DebugGridWrapper> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var grid = e.NewElement as DebugGridWrapper;

                SetNativeControl(new DebugGridViewDroid(Context)
                {
                    HorizontalItemSize = (float)grid.HorizontalItemSize,
                    VerticalItemSize = (float)grid.VerticalItemSize,
                    MajorGridLineInterval = grid.MajorGridLineInterval,
                    MajorGridLineColor = grid.MajorGridLineColor,
                    GridLineColor = grid.GridLineColor,
                    MajorGridLineOpacity = (float)grid.MajorGridLineOpacity,
                    GridLineOpacity = (float)grid.GridLineOpacity,
                    MajorGridLineThickness = (float)grid.MajorGridLineWidth,
                    GridLineThickness = (float)grid.GridLineWidth,
                    MakeGridRainbows = grid.MakeGridRainbows,
                    Inverse = grid.Inverse,
                    GridOrigin = grid.GridOrigin
                });
            }
        }
    }
}
