using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float gameTime;

    public GameObject timer;
    private TextMeshProUGUI timerText;

    // haha get it? because it's "the world"?
    public GameObject ZaWarudo;

    public bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        timerText = timer.GetComponent<TextMeshProUGUI>();
        gameTime = 0;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameTime = gameTime + Time.deltaTime;
        // int hours   = (int)(gameTime / 60 / 60 % 60);
        int minutes = (int)(gameTime / 60 % 60);
        int seconds = (int)(gameTime % 60);

        timerText.text =
            // (hours + "").PadLeft(2, '0') + ":" +
            (minutes + "").PadLeft(2, '0') + ":" +
            (seconds + "").PadLeft(2, '0');

        ZaWarudo.transform.position -= new Vector3(Time.deltaTime * 3, 0, 0);

        if (gameOver == true)
        {
            //Make Game Over scene
            Debug.Log("GameOver Loading");
            PlayerPrefs.SetString("scoreText", timerText.text);
            SceneManager.LoadScene("Game Over");
        }
    }
}