# ScreenshotWebpage
A program that screenshots the entire page that the browser is on (creates a jpg file named "Screenshot" in the same folder as the program). Created using C#, .NET 6, and Visual Studio Winforms.

**Layout**
------------
The UI of the program is simple. On top there is an address bar, capture button, and a navigation button. In the center of the application, there is a webview2 form. The capture button by default, screenshots the webpage. Go navigates to whatever is typed in the address bar. There are safety measures in place to prevent loading invalid links.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/177068454-30e3973a-9690-424c-a79c-5c1e699d0167.png"><img>
</p>

**Buttons**
------------
This project has been updated to add more features and buttons. Below is a list explaining the functions of the new buttons
- Open
    - File explorer opens to the current directory (the directory of the program/image files)
- Cancel
    - Stops any processes that are currently in progress
- Custom
    - Opens custom capture options
- Settings
    - Opens the settings menu
- Capture
    - Capture the current webpage
- Go
    - Goes to the link in the address bar

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/177064714-35c6979a-62d9-4fae-baa4-03e84e4e5149.png"><img>
</p>

**Settings Button**
-------
The settings control the image type the capture will save as. It also controls the name of the image and the folder name the images will be saved to.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/177068315-7b623d0e-9fcc-403e-b261-2fecd4a64a6c.png"><img>
</p>

**Custom Button**
-------
The first tab is for screenshotting specific page numbers with set intervals. This process will append the number to the end of the url string. Interval is the set numbers you would like to capture between. Step is how much the number is incremented by per capture. Stop is the amount of captures that the program will go through before asking for user input again (0 means the program will continue until the end). Pause is the amount of time between each webpage load/capture.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/177067035-1ed772c4-6b32-4301-a230-4986806d2168.png"><img>
</p>

The second tab is for specific webpages you would like to capture.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/177067306-3c2ab798-d8ee-4c46-97ac-084f3b2ebd5c.png"><img>
</p>

**Examples of a Screenshot**
------------
The program will screenshot the entire webpage. This may seem excessive, but this program is created with archival in mind. Below is an example of what the program would output. The webpage we use in this example is the google search result of "hello world" (reduced size to not fill up too much of the readme).

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/167742872-7c91bec3-e4ce-4025-8ac9-457a0344c88a.jpg" width="400" height="506"><img>
</p>

**Webview2 Screenshot Code**
-------------------------
The code used to screenshot the webpage is shown below if you want to use it in your own program. Make sure you install the Newtonsoft Json package.

```csharp
//Call the methods to take a screenshot
private async void TakeScreenshot()
{
    Image myImage = await TakeWebScreenshot();
    myImage.Save("Screenshot.jpg");
}
//Get the webpage bitmap and then save it as an image
public async Task<Image> TakeWebScreenshot(bool currentControlClipOnly = false)
{
    dynamic scl = null;
    Size siz;

    if (!currentControlClipOnly)
    {
        var res = await myWebView.CoreWebView2.ExecuteScriptAsync(@"var v = {""w"":document.body.scrollWidth, ""h"":document.body.scrollHeight}; v;");
        try { scl = JObject.Parse(res); } catch { }
    }
    siz = scl != null ?
                new Size((int)scl.w > myWebView.Width ? (int)scl.w : myWebView.Width,
                            (int)scl.h > myWebView.Height ? (int)scl.h : myWebView.Height)
                :
                myWebView.Size;

    var img = await GetWebBrowserBitmap(siz);
    return img;
}
//Get the webpage bitmap
private async Task<Bitmap> GetWebBrowserBitmap(Size clipSize)
{
    dynamic clip = new JObject();
    clip.x = 0;
    clip.y = 0;
    clip.width = clipSize.Width;
    clip.height = clipSize.Height;
    clip.scale = 1;

    dynamic settings = new JObject();
    settings.format = "jpeg";
    settings.clip = clip;
    settings.fromSurface = true;
    settings.captureBeyondViewport = true;

    var p = settings.ToString(Newtonsoft.Json.Formatting.None);

    var devData = await myWebView.CoreWebView2.CallDevToolsProtocolMethodAsync("Page.captureScreenshot", p);
    var imgData = (string)((dynamic)JObject.Parse(devData)).data;
    var ms = new MemoryStream(Convert.FromBase64String(imgData));
    return (Bitmap)Image.FromStream(ms);
}
```

**Packages Used**
------------------
Both the Microsoft.Web.WebView2 and Newtonsoft.Json packages wer used in this project. If you wish to edit the source code, make sure to install them. The WebView2 package is used as the browser while the Newtonsoft Json package is used to help capture the page.

**Plans**
---------------
I plan to continue working on this program by making it more automated. Future features include: adding application settings, allowing for a list of links to be added for capturing, reassigning default picture name, and much more.

**Other Related Projects**
-----------------------
Below are other similar projects related to this application.

[WebView2 Template](https://github.com/Kttra/webView2Template) - I built this project using a base template that I have created in the past. You can find similar web browser based projects I have created in this repo.

[Android WebView App](https://github.com/Kttra/webViewXAM-Android) - An android broswer used to test loading different type of webpages using different user agents. Created using Xamarin.

[ScreenshotForm](https://github.com/Kttra/ScreenshotForm) - A different screenshot program that showcases how to screenshot your pc screen, screenshot the form itself, screenshot the controls contained in a panel, and displaying an image on a picture box.
