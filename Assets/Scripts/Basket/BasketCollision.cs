using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketCollision : MonoBehaviour
{
    [SerializeField] private LevelParameters _lvlSettings;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        _lvlSettings.CatchFruit();
    }
}
