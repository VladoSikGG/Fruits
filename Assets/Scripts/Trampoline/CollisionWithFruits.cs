using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollisionWithFruits : MonoBehaviour
{
    private AudioSource _trampline;

    private void Start()
    {
        _trampline = GameObject.Find("Trampline").GetComponent<AudioSource>();
        _trampline.volume = PlayerPrefs.GetFloat("Sounds");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            _trampline.Play();
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(0.11f, 2f), 7);
        }
    }
}
