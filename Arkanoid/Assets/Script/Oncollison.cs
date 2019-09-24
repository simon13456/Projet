using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollison : MonoBehaviour
{
    public
        Niveau niveau;
    // Start is called before the first frame update
    void Start()
    {
        niveau = FindObjectOfType<Niveau>();
        niveau.compterBriques();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        niveau.enleverBrique();
        Destroy(gameObject, 0f);

    }
    
}
