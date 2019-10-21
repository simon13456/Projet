using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveau : MonoBehaviour
{
    [SerializeField] private int _nbrBrique = 0;
    private Gestiondescene _gestiondescene;
    
    void Start()
    {
        _gestiondescene = FindObjectOfType<Gestiondescene>();
    }

   
    void Update()
    {
       
    }

    public void compterBriques()
    {
        _nbrBrique++;
    }

    internal void enleverBrique()
    {
        _nbrBrique--;
        if (_nbrBrique <= 0)
        {
            FindObjectOfType<etatJeu>().plusvit();
            
            _gestiondescene.ChangerScene();
            FindObjectOfType<etatJeu>().changeLvl();
        }
    }
}
