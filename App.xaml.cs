namespace MyCoffeeMVVMSQLite;

/*
#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif
*/

public partial class App : Application
{
    // windows size 1920 x 1080 = 1080P
	const int WindowWidth = 1920;
    const int WindowHeight = 1080;

    public App()
	{
		InitializeComponent();
/*
        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
#if WINDOWS
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            
            nativeWindow.Activate();
            
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);

            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
            
            
            // HMMM
       
#endif
        });
*/
        MainPage = new AppShell();
	}
}
