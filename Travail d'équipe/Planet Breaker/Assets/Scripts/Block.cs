﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private Niveau _niveau;
    private etatJeu _etatJeu;
    [SerializeField] private int _point = 50;
    [SerializeField] private int _hitMax =1;
    [SerializeField] private Sprite[] _BlockDegat;
    private int _Degat=0;
    
   
    


    void Start()
    {
        if(tag != "Indestruc")
        {
            _niveau = FindObjectOfType<Niveau>();
            _niveau.compterBriques();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag != "Indestruc")
        {
            _Degat++;
            if (_Degat >= _hitMax)
            {
                Destroy(gameObject, 0f);
                _niveau.enleverBrique();
                FindObjectOfType<etatJeu>().addPoint(_point);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = _BlockDegat[_Degat - 1];
            }


            

        }
    }

}
