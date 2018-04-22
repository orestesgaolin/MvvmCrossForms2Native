using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MvvmCrossFormsEmbedding.Core;

namespace MvvmCrossFormsEmbedding.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
