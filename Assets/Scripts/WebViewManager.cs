using UnityEngine;

public class WebViewManager : MonoBehaviour
{
    private AndroidJavaObject webViewPlugin;

    public void StartView()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                var activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                webViewPlugin = new AndroidJavaObject("com.wernix.webview.WebViewPlugin");
                webViewPlugin.Call("ShowWebView", activity, "https://www.google.ru/");
                Debug.Log("Start connection");
            }
        }
    }

    public void HideWebView()
    {
        if (webViewPlugin != null)
        {
            webViewPlugin.Call("HideWebView");
        }
    }

    public void DestroyWebView()
    {
        if (webViewPlugin != null)
        {
            webViewPlugin.Call("DestroyWebView");
        }
    }
}
