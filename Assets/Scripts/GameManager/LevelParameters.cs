using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelParameters : MonoBehaviour
{
    
    [Header("Info Level")]
    [SerializeField] private int _numLevel;
    
    [Header("Player Settings")]
    [SerializeField] private float _sizePlatform;
    [SerializeField] private int _countFruits;

    [Header("View Info on screen")] 
    [SerializeField] private Slider _progressBar;
    
    private CheckStatus _checkStatus;

    private int _catchFruits;
    private void Start()
    {
        _progressBar.maxValue = _countFruits;
        _progressBar.value = 0;
        _checkStatus = gameObject.GetComponent<CheckStatus>();
    }

    public float GetSizePlatform()
    {
        return _sizePlatform; 
    }
    public int GetNumLevel()
    {
        return _numLevel;
    }

    public int GetCountFruits()
    {
        return _countFruits;
    }

    public void CatchFruit()
    {
        _catchFruits++;
        _progressBar.value = _catchFruits;
        if (_catchFruits == _countFruits) _checkStatus.Win();
    }
}
