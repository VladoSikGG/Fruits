using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ViewUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _viewCoin, _viewBonus, _viewLevel;

    private void Start()
    {
        _viewLevel = GameObject.Find("LevelView").transform.GetChild(0).GetComponent<TMP_Text>();
    }

    private void Update()
    {
        _viewCoin.text = PlayerPrefs.GetInt("Money").ToString();
        _viewBonus.text = PlayerPrefs.GetInt("Bonus").ToString();
        _viewLevel.text = $"LEVEL {GameObject.Find("GameManager").GetComponent<LevelParameters>().GetNumLevel()}";
    }
}
