using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CMScript : MonoBehaviour
{
    void Start() { }

    void Update() { }

    public void returnButton()
    {
        FindObjectOfType<AudioController>().Play("click");
        SceneManager.LoadScene("Main Menu");
    }
}
