using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private int _point = 100;
    [SerializeField] private int _hitMax =1;
    private int _Degat=0;
    private float[] _color= {126,218};
    SpriteRenderer renderer;
    


    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        

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

            }
            else
            {
               /* Debug.Log(_Degat);
                if (tag == "ThreeHit")
                {
                    if (_Degat == 1)
                    {
                        renderer.color = new Color(255f, 218f, 0f, 255f);
                    }
                   if (_Degat == 2)
                    {
                        renderer.color = new Color(255f, 126f, 0f, 255f);
                        
                    }
                }

                if (tag == "TwoHit")
                {
                    renderer.color = new Color(255f, 218, 0f, 255f);
                }
                */
            }


            

        }
    }

}
