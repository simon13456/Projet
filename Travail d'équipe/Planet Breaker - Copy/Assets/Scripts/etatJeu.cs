using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class etatJeu : MonoBehaviour
{
    [Range(0.1f,10.0f)][SerializeField] private float _vitJeu = 0.75f;
    private int _vie=5;
    
    [SerializeField] private TextMeshProUGUI _txtPointage =default;
    [SerializeField] private TextMeshProUGUI _nbsVie =default;
    [SerializeField] private TextMeshProUGUI _Niveau = default;
    [SerializeField] private TextMeshProUGUI _temps = default;
    float live = default;
    private int _point = 0;
    private float vitBonus=0;
    private float _chrono;
    // Start is called before the first frame update
    void Start()
    {
        
        //live = Time.time;
        _nbsVie.SetText("vie:" + _vie.ToString());
        _Niveau.SetText("niveau " + SceneManager.GetActiveScene().buildIndex);
       
   
    }

   
    private void Awake()
    {

        int compteurJeu = FindObjectsOfType<etatJeu>().Length;
        if (compteurJeu > 1)
        {

            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    void Update()
    {
        Time.timeScale = _vitJeu;
        _chrono += Time.deltaTime;
        int minute = (int)(_chrono)/60;
        int seconde = (int)(_chrono) % 60;
        if (seconde == 0 || seconde == 1 || seconde == 2 || seconde == 3 || seconde == 4 || seconde == 5 || seconde == 6 || seconde == 7 || seconde == 8 || seconde == 9)
        {
            _temps.SetText(minute + ": 0" + seconde);
        }
        else
        {
            _temps.SetText(minute + " : " + seconde);
        }
        
    }
    public int Getminute()
    {
        int minute = (int)(_chrono) / 60;
        return minute;
    }
    public int Getsec()
    {
        int seconde = (int)(_chrono) % 60;
        return seconde;
    }
    public int Getscore()
    {
        return _point;
    }
        public void addPoint(int point)
    {
        _point += point;
        _txtPointage.text = "score: " + _point;
    }

    public void changeLvl()
    {
        int niveau = FindObjectOfType<Gestiondescene>().getNiveau();
        _Niveau.text = "niveau " + (niveau+1);
    }

    public void suicide()
    {
        Destroy(gameObject);
    }

    public void plusvit()
    {
        vitBonus += 0.5f;
     
    }
    public float godSpeed()
    {
        return vitBonus;
    }
    public void perdreVie()
    {
        _vie--;
        _nbsVie.SetText("vie:" + _vie.ToString());
        if (_vie <= 0)
        {
            SceneManager.LoadScene("Perdu");
        }
        else
        {
            FindObjectOfType<Ball>().restart();
        }
    }
   
}
