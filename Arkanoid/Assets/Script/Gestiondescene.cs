using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class Gestiondescene : MonoBehaviour
{
    public void ChangerScene()
    {
        int indexSceneCourante = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexSceneCourante+1);
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
