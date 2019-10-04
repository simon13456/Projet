using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    private Paddle _paddle1 = new Paddle();
    [SerializeField] float _pousseX=0.5f;
    [SerializeField] float _pussY=5f;
    private Vector2 _PaddleToBall;
    private bool _estLance = false;
    // Start is called before the first frame update
    void Start()
    {
        _paddle1 = FindObjectOfType<Paddle>();
        _PaddleToBall = transform.position - _paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_estLance)
        {
            PositionBall();
            lancerBall();
        }
    }

    private void lancerBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(_pousseX, _pussY);
            _estLance = true;
        }
    }

    private void PositionBall()
    {
        Vector2 paddlePos = new Vector2(_paddle1.transform.position.x, _paddle1.transform.position.y);
        transform.position = paddlePos + _PaddleToBall;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (_estLance)
        {
            Vector2 ajustement = new Vector2(UnityEngine.Random.Range(0f, 0.2f), UnityEngine.Random.Range(0f, 0.2f));
            GetComponent<Rigidbody2D>().velocity += ajustement;
        }
        
    }
}
