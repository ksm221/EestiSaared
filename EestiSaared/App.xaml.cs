#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

using EestiSaared.Views;

namespace EestiSaared;

public partial class App : Application
{
    const int WindowWidth = 200;
    const int WindowHeight = 1200;

    public App()
	{
		InitializeComponent();
#if WINDOWS
        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) => 
		{
			var mauiWindow = handler.VirtualView;
			var nativeWindow = handler.PlatformView;
			nativeWindow.Activate();
			IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
			WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
			AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
			appWindow.Resize(new SizeInt32(WindowHeight,WindowHeight));
 
        });
#endif

        MainPage = new NavigationPage(new StartPage());
        //MainPage = new AppShell();
	}
}

