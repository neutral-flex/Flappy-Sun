using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenYoutube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCgEJPXWEOQgKDNyAoaCnK-A");
    }
    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/L4zooo");
    }
    public void OpenWebsite()
    {
        Application.OpenURL("https://felixrichard.de/u/");
    }
}
