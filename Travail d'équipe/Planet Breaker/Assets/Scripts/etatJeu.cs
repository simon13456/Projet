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
    // Start is called before the first frame update
    void Start()
    {
       

        live = Time.time;
        _nbsVie.SetText("Vie:" + _vie.ToString());
        _Niveau.SetText("Niveau " + SceneManager.GetActiveScene().buildIndex);
       
   
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
        int minute = (int)(Time.realtimeSinceStartup - live)/60;
        int seconde = (int)(Time.realtimeSinceStartup - live) % 60;
        _temps.SetText(minute + ":" + seconde);
        
    }

    public void addPoint(int point)
    {
        _point += point;
        _txtPointage.text = "Score: " + _point;
    }

    public void changeLvl()
    {
        int niveau = FindObjectOfType<Gestiondescene>().getNiveau();
        _Niveau.text = "Niveau " + (niveau+1);
    }

    public void suicide()
    {
        Destroy(gameObject);
    }

    public void plusvit()
    {
        vitBonus += 0.5f;
        Debug.Log(vitBonus);
    }
    public float godSpeed()
    {
        return vitBonus;
    }
    public void perdreVie()
    {
        _vie--;
        _nbsVie.SetText("Vie:" + _vie.ToString());
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
