using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializationPlatform : MonoBehaviour
{
    [SerializeField] private LevelParameters _lvlParam;

    private void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
        gameObject.transform.localScale = new Vector3(_lvlParam.GetSizePlatform(), _lvlParam.GetSizePlatform(), 1);
    }
}
