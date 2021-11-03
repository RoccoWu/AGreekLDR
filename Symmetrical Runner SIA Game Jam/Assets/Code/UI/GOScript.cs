using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GOScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = "You lasted for " + PlayerPrefs.GetString("scoreText") + "!";
    }

    public void PlayAgain()
    {
        FindObjectOfType<AudioController>().Play("click");
        SceneManager.LoadScene("Gameplay");
    }
    
    public void ReturnToMenu()
    {
        FindObjectOfType<AudioController>().Play("click");
        SceneManager.LoadScene("Main Menu");
    }
}
