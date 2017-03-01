﻿using System;
using Neutronium.Core.WebBrowserEngine.JavascriptObject;

namespace Neutronium.Core.WebBrowserEngine.Window
{
    /// <summary>
    /// HTML Window abstraction
    /// </summary>
    public interface IWebBrowserWindow
    {
        /// <summary>
        /// Get the main frame logic
        /// </summary>
        IWebView MainFrame { get; }

        /// <summary>
        /// Indicates if a type is a basic CLR type which  
        /// can be converted by the Mainframe Factory 
        /// </summary>
        /// <param name="type">
        /// Type to check
        /// </param>
        /// <returns>
        /// true if type can be handled by SolveBasic
        ///</returns>
        bool IsTypeBasic(Type type);

        /// <summary>
        /// Navigate to the specified path
        /// </summary>
        /// <param name="path">
        /// Uri to navigate to
        /// </param>
        void NavigateTo(Uri path);

        /// <summary>
        /// Url of the browser
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// true if the content is loaded and ready
        /// </summary>
        bool IsLoaded { get; }

        /// <summary>
        /// event fired when the window is loaded
        /// </summary>
        event EventHandler<LoadEndEventArgs> LoadEnd;

        /// <summary>
        /// event fired when the console log is called in the browser
        /// </summary>
        event EventHandler<ConsoleMessageArgs> ConsoleMessage;

        /// <summary>
        /// event fired when browser process crashed
        /// </summary>
        event EventHandler<BrowserCrashedArgs> Crashed;
    }
}
