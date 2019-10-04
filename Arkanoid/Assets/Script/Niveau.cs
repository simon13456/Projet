using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveau : MonoBehaviour
{
    [SerializeField] private float Brique = 0f;
    private Gestiondescene _gestiondescene;
    // Start is called before the first frame update
    void Start()
    {
        _gestiondescene = FindObjectOfType<Gestiondescene>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Brique <= 0)
        {
            FindObjectOfType<etatJeu>().plusvit();
            _gestiondescene.ChangerScene();
        }
    }

    public void compterBriques()
    {
        Brique++;
    }

    internal void enleverBrique()
    {
        Brique--;
    }
}
