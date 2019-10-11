using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 0.5f;
    [SerializeField] float maxX = 5.2f;
    [SerializeField] float largeur = 5.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPosInUnits = (Input.GetTouch(0).position.x/ Screen.width * largeur);
        Vector3 paddlePos = new Vector3(transform.position.x, transform.position.y, 0);
        paddlePos.x = Mathf.Clamp(xPosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
