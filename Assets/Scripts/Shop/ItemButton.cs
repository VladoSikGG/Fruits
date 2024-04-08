using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    [SerializeField] private Sprite _icon;
    [SerializeField] private int _cost, _numSkin;
    [SerializeField] private ViewMenuBuy menuBuy;
    [SerializeField] private bool _isSkin;
    [SerializeField] private BuyButton _btnBuy;
    
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            if (_isSkin) menuBuy.InitializeBuyItem(_icon, _cost, _numSkin);
            else menuBuy.InitializeBuyItem(_icon, _cost);
            
            menuBuy.gameObject.SetActive(true);
            
            if (_isSkin)
            {
                if (PlayerPrefs.GetInt($"{_numSkin}") == 0) _btnBuy.GetComponent<BuyButton>().BuySkin(_numSkin, _cost);
                else _btnBuy.GetComponent<BuyButton>().SelectSkin(_numSkin);
            }
            else _btnBuy.GetComponent<BuyButton>().BuyBonus(_cost);
        });
        
        
    }
}
