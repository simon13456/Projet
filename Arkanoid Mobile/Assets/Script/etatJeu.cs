using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class etatJeu : MonoBehaviour
{
    [Range(0.1f,10.0f)][SerializeField] private float _vitJeu = 1.0f;
    private int _point = 0;
    [SerializeField] private Text _txtPointage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    private void Awake()
    {
        int compteurJeu = FindObjectsOfType<etatJeu>().Length;
        if(compteurJeu > 1)
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
    }
    public void ajouterPoints(int ValPoint)
    {
        _point += ValPoint;
        _txtPointage.text = "Score: " + _point;
    }
    public void suicide()
    {
        Destroy(gameObject);
    }
}
