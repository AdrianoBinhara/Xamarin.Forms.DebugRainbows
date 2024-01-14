
using DebugRainbowCompat.SharedPlatform;
using Maui.DebugRainbows.Multi;

namespace DebugRainbowCompat;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder UseDebugRainbowCompat(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers((handlers) =>
        {
#if ANDROID
            handlers.AddHandler(typeof(DebugRainbow), typeof(DebugGridWrapperRendererDroid));
            
#elif IOS
            handlers.AddHandler(typeof(DebugRainbow), typeof(DebugGridWrapperRendereriOS));
#endif
        });
        return builder;
    }
}