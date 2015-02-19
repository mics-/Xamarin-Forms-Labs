using XLabs.Platform.Services;

namespace XLabs.Forms.Mvvm
{
    public interface IBindableObject
    {
        void BindViewModel<T>()  where T : class, IViewModel ;
    }
}