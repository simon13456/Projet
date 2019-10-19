using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Paddle _paddle= null;
    [SerializeField] private float GlobalPush=0;
    private Vector2 _paddleBall;
    private bool _thrown = false;
    public bool _deuxBalles = false;
    
    void Update()
    {
        if (!_thrown)
        {
             BallPosition();
             ThrowBall();
        }
    }
    private void ThrowBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GlobalPush * Mathf.Cos(Mathf.Deg2Rad*180+(FindObjectOfType<Paddle>().TrouverAngle())), GlobalPush * Mathf.Sin(Mathf.Deg2Rad*180+(FindObjectOfType<Paddle>().TrouverAngle())));
            _thrown = true;
        }


    }

    private void BallPosition()
    {
        
        Vector2 padPosition = new Vector2(FindObjectOfType<Paddle>().transform.position.x, FindObjectOfType<Paddle>().transform.position.y);
        _paddleBall = new Vector2(0.2f*Mathf.Cos(FindObjectOfType<Paddle>().TrouverAngle()), 0.2f * Mathf.Sin(FindObjectOfType<Paddle>().TrouverAngle()));
        transform.position = (padPosition + _paddleBall);
    }

    public void restart()
    {
        _thrown = false;
        BallPosition();
    }

    public bool deuxBalles()
    {
        return _deuxBalles;
    }

    public void newBall()
    {
        GameObject ball2 = Instantiate(gameObject);
        ball2.name = "ball2";
        _deuxBalles = true;
    }

    public void destroyBall()
    {
        Destroy(gameObject);
        _deuxBalles = false;
    }

  

}
