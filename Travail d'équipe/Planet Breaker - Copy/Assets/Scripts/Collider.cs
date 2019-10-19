﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (FindObjectsOfType<Ball>().Length == 2)
        {
            other.GetComponent<Ball>().destroyBall();
        }
        else
        {
            FindObjectOfType<etatJeu>().perdreVie();
        }
        
    }
}
