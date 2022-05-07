using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource mainMusic;
    public AudioSource battleMusic;
    public GameObject battleScreen;


    private void Start()
    {
        mainMusic.Play();
        battleMusic.Stop();
    }

    private void Update()
    {
        if (battleScreen.activeInHierarchy && !battleMusic.isPlaying)
        {
            mainMusic.Stop();
            battleMusic.Play();
        }
        
        else if (!battleScreen.activeInHierarchy && !mainMusic.isPlaying)
        {
            mainMusic.Play();
            battleMusic.Stop();
        }
    }
}
