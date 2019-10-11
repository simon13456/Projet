using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float worldWidth = 16f;
    [SerializeField] private float worldHeight = 12f;
    void Start()
    {
        
    }

    

    public float TrouverAngle()
    {
        float xPos = ((Input.mousePosition.x / Screen.width * worldWidth) - 8);
        float yPos = ((Input.mousePosition.y / Screen.height * worldHeight) - 6);

        float angleSupp = 0;

        if (xPos < 0)
        {
            angleSupp = Mathf.Deg2Rad * 180;
        }

        float angle = Mathf.Atan(yPos / xPos) + angleSupp;
        return angle;
    }
    void Update()
    {
        float xPos = 0f;
        float yPos = 0f;
        float  anglePaddle = TrouverAngle();
        xPos = 3.74f * (Mathf.Cos(anglePaddle)+0.01f);
        yPos = 3.74f * (Mathf.Sin(anglePaddle)-0.13f);
        Vector2 padPosition = new Vector2(xPos, yPos);
        padPosition.x = Mathf.Clamp(xPos, -8f, 8f);
        transform.position = padPosition;

        transform.eulerAngles = new Vector3(0, 0, Mathf.Rad2Deg * anglePaddle + 90);

    }
}
