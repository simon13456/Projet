using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gestiongagnant : MonoBehaviour
{
    
    GameObject etatsjeu = default;
    [SerializeField] private TextMeshProUGUI _tempsFinal = default;
    [SerializeField] private TextMeshProUGUI _Score = default;
    // Start is called before the first frame update
    void Start()
    {
        int minute = FindObjectOfType<etatJeu>().Getminute();
        int seconde = FindObjectOfType<etatJeu>().Getsec();
        _tempsFinal.SetText("temps final: " + minute + ":" + seconde );
        _Score.SetText("score final: "+FindObjectOfType<etatJeu>().Getscore().ToString());
       etatsjeu = GameObject.Find("EtatJeuC");
        etatsjeu.SetActive(false);
        Destroy(etatsjeu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
