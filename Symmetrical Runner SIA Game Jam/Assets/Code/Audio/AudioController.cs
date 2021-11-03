using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public Sound[] sounds;

    /*public AudioClip birdsSFX;
    public AudioClip hellSFX;
    public AudioClip walkingongrassSFX;
    public AudioClip jumpSFX;

    /**
     * A
     * Sound
     * Source
     **/
  /*
   * AudioSource ass;
    
    string scene;

    public PlayerControllerScript playerScript;
      */

    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            Debug.Log("Assigning data" + s.clip.name);

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }


       /* ass = GetComponent<AudioSource>();

        scene = SceneManager.GetActiveScene().name;

        if(scene.Equals("Gameplay"))
        {
            ass.clip = birdsSFX;
            ass.clip = hellSFX;
            
        }

        ass.loop = true;

        ass.Play();*/
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
            s.source.Play();
    }



   /* // Update is called once per frame
    void Update()
    {
        if(playerScript.touchGround == true)
        {
            ass.PlayOneShot(walkingongrassSFX, 0.5f);
            //ass.clip = walkingongrassSFX;
        }
        
        if(playerScript.touchGround == false)
        {
            ass.Stop();
        }

        if(playerScript.touchGround == false)
        {
            ass.PlayOneShot(jumpSFX, 0.7f);
            //ass.clip = jumpSFX;
        }
    }*/
}
