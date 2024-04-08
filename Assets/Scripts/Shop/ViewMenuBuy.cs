using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ViewMenuBuy : MonoBehaviour
{
    [SerializeField] private Image _itemView;
    [SerializeField] private TMP_Text _costView;
    private int _cost;

    public void InitializeBuyItem(Sprite image, int cost)
    {
        _itemView.sprite = image;
        _costView.text = cost.ToString();
        _cost = cost;
    }
    
    public void InitializeBuyItem(Sprite image, int cost, int numSkin)
    {
        _itemView.sprite = image;
        if (PlayerPrefs.GetInt($"{numSkin}") == 0) _costView.text = cost.ToString();
        else _costView.text = "Apply that background?";
        _cost = cost;
    }
}
