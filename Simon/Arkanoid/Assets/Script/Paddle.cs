using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float largeur = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPosInUnits = (Input.mousePosition.x / Screen.width * largeur);
        Vector3 paddlePos = new Vector3(transform.position.x, transform.position.y, 0);
        paddlePos.x = Mathf.Clamp(xPosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
