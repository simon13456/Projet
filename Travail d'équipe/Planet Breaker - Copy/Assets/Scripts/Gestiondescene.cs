﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Gestiondescene : MonoBehaviour
{
    GameObject etatsjeu = default;
    public void ChangerScene()
    {
        int indexSceneCourante = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexSceneCourante+1);
        
    }
    public int getNiveau()
    {
        int SceneCourante = SceneManager.GetActiveScene().buildIndex;
        return SceneCourante;
    }

    public void quitter()
    {
        Application.Quit();
    }
    public void reco()
    {
        int indexSceneCourante = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }
}
