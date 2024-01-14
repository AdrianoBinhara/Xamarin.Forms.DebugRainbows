using Maui.DebugRainbows.Multi.Platforms.SharedPlatform;

namespace Maui.DebugRainbows.Multi;

public class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseDebugRainbowCompat( MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers((handlers) =>
        {
#if ANDROID
            handlers.AddHandler(typeof(DebugRainbow), typeof(DebugGridWrapperRendererDroid));
            
#endif
        });
        return builder;
    }
}