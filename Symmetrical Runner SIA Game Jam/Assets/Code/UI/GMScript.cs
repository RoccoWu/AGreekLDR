using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMScript : MonoBehaviour
{
    //public AudioClip clickSFX;

    public void startButton()
    {
        FindObjectOfType<AudioController>().Play("click");
        SceneManager.LoadScene("Gameplay");
    }

    public void tutorialButton()
    {
        FindObjectOfType<AudioController>().Play("click");
        SceneManager.LoadScene("Tutorial");
    }
    public void creditsButton()
    {
        FindObjectOfType<AudioController>().Play("click");
        SceneManager.LoadScene("Credits");
    }
}
