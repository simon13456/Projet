using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollison : MonoBehaviour
{
    private Niveau _niveau;
    [SerializeField] private int _valPoint=50;
    [SerializeField] private int nbscoupMax = 1;
    [SerializeField] private Sprite[] _imageBloc;
    private int _currentHit = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (tag != "incassable")
        {
            _niveau = FindObjectOfType<Niveau>();
            _niveau.compterBriques();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (tag != "incassable")
        {
            _currentHit++;
            if (_currentHit >= nbscoupMax)
            {
                _niveau.enleverBrique();
                Destroy(gameObject, 0f);
                FindObjectOfType<etatJeu>().ajouterPoints(_valPoint);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = _imageBloc[_currentHit];
            }
        }
    }
    
}
