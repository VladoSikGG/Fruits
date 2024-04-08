using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private int _direction;

    private void Update()
    {
        MoveSide();
    }

    private void MoveSide()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * _speed * _direction;
    }

    public void ChooseSide(int dir)
    {
        _direction = dir;
    }

    public void UpButton()
    {
        _direction = 0;
    }
}
