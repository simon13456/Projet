using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mute : MonoBehaviour
{
    private Singleton music;
    private int compteur = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        music = FindObjectOfType<Singleton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void muteing()
    {

        if (compteur % 2 == 0)
        {
            music.GetComponent<AudioSource>().Stop();
            compteur++;

        }
        else if(compteur % 2 == 1)
        {
            music.GetComponent<AudioSource>().Play();
            compteur++;
        }
    }
    
}
