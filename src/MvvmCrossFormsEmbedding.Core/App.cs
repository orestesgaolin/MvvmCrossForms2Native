using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCrossFormsEmbedding.Core.ViewModels;

namespace MvvmCrossFormsEmbedding.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
