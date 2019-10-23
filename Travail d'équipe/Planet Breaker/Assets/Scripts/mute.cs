using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mute : MonoBehaviour
{
    [SerializeField] private Sprite [] iconne;
    [SerializeField] private Button button;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void muteing()
    {
        int compteur = 2;
        if (compteur % 2 == 0)
        {
            GetComponent<AudioSource>().Stop();
            button.image.sprite = iconne[0];
            compteur++;
        }
        else if(compteur % 2 == 1)
        {
            GetComponent<AudioSource>().Stop();
            button.image.sprite = iconne[1];
            compteur++;
        }
    }
}
