using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Paddle _paddle= null;
    [SerializeField] private float GlobalPush=0;
    private Vector2 _paddleBall;
    private bool _thrown = false;

    void Start()
    {
        _paddleBall = transform.position - _paddle.transform.position;
    }
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
            GetComponent<Rigidbody2D>().velocity = new Vector2(GlobalPush * Mathf.Cos(Mathf.Deg2Rad*180+(_paddle.TrouverAngle())), GlobalPush * Mathf.Sin(Mathf.Deg2Rad*180+(_paddle.TrouverAngle())));
            _thrown = true;
        }


    }

    private void BallPosition()
    {

        Vector2 padPosition = new Vector2(_paddle.transform.position.x, _paddle.transform.position.y);
        transform.position = (padPosition + _paddleBall);
    }

 
   
}
