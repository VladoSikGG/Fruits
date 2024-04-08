using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private CheckStatus _checkStatus;

    private void Start()
    {
        _checkStatus = GameObject.Find("GameManager").GetComponent<CheckStatus>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            Destroy(other.gameObject);
            _checkStatus.Lose();
        }
    }
}
