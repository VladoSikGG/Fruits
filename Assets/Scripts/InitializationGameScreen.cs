using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializationGameScreen : MonoBehaviour
{
    [SerializeField] private Sprite[] _skins;

    private void Update()
    {
        GetComponent<Image>().sprite = _skins[PlayerPrefs.GetInt("CurrentSkin")];
    }
}
