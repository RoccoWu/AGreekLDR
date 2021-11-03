using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static bool somebodyOnceToldMeTheWorldWasGonnaRollMe;
    void Start()
    {
        if (somebodyOnceToldMeTheWorldWasGonnaRollMe == false)
        {
            somebodyOnceToldMeTheWorldWasGonnaRollMe = true;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Gameplay" || SceneManager.GetActiveScene().name == "Game Over")
        {
            gameObject.GetComponent<AudioSource>().mute = true;
        }
        else
        {
            gameObject.GetComponent<AudioSource>().mute = false;
        }
    }
}
