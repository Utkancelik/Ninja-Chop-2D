using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    SceneManager scene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    public void OnClickPlayButton()
    {
        SceneManager.LoadScene(0);
    }
    public void GoDiscord()
    {
        Application.OpenURL("https://discord.gg/49e27T2B");
    }
    public void GoTwitter()
    {
        Application.OpenURL("https://twitter.com/06melihgokcek");
    }
    public void GoFacebook()
    {
        Application.OpenURL("https://discord.gg/49e27T2B");
    }
}
