# ScreenshotWebpage
A program that screenshots the entire page that the browser is on (creates a jpg file named "Screenshot" in the same folder as the program). Created using C#, .NET 6, and Visual Studio Winforms.

**Layout**
------------
The UI of the program is simple. On top there is an address bar, capture button, and a navigation button. In the center of the application, there is a webview2 form. The capture button by default, screenshots the webpage. Go navigates to whatever is typed in the address bar. There are safety measures in place to prevent loading invalid links.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/167742602-0a5c3960-41d6-4dc9-9b41-a0a8a8897ff8.png"><img>
</p>

**Examples of a Screenshot**
------------
The program will screenshot the entire webpage. This may seem excessive, but this program is created with archival in mind. Below is an example of what the program would output. The webpage we use in this example is the google search result of "hello world".

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/167742872-7c91bec3-e4ce-4025-8ac9-457a0344c88a.jpg" width="700" height="886"><img>
</p>

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
