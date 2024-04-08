using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnFruits : MonoBehaviour
{
    [Header("Spawn objects")]
    [SerializeField] private Sprite[] _skinFruits;
    [SerializeField] private GameObject _prefFruit;
    
    [Header("SettingsSpawn")]
    [SerializeField] private float _timeSpawn;
    [SerializeField] private LevelParameters _levelParameters;

    private int _numFruits;

    private void Start()
    {
        _numFruits = _levelParameters.GetCountFruits();
        StartCoroutine(Spawning());
    }

    private void OnEnable()
    {
        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        while ( _numFruits != 0)
        {
            GameObject GO = Instantiate(_prefFruit, transform.position, Quaternion.identity, gameObject.transform);
            GO.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(0.5f, 1f), 0);
            GO.transform.Rotate(0,0,-65);
            GO.GetComponent<SpriteRenderer>().sprite = _skinFruits[Random.Range(0, _skinFruits.Length)];
            GO.AddComponent<PolygonCollider2D>();
            yield return new WaitForSeconds(_timeSpawn);
            _numFruits--;
        }
    }
}
