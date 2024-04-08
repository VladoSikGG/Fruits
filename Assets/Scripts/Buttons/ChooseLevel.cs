using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseLevel : MonoBehaviour
{
    [SerializeField] private bool _isSecond;
    private int _numLevel;
    private bool _isOpen;

    private void Start()
    {
        if(_isSecond == false) _numLevel = transform.GetSiblingIndex() + 1;
        else _numLevel = transform.GetSiblingIndex() + 1+12;

        if (PlayerPrefs.GetInt("Level") >= _numLevel)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r,
                    GetComponent<Image>().color.g,
                    GetComponent<Image>().color.b,
                    1);
            _isOpen = true;
        }
        else  
        {
            GetComponent<Image>().color = 
            new Color(GetComponent<Image>().color.r,
                GetComponent<Image>().color.g,
                GetComponent<Image>().color.b,
                0.5f);
            _isOpen = false;
        }
        
        transform.GetChild(0).GetComponent<TMP_Text>().text = _numLevel.ToString();

        GetComponent<Button>().onClick.AddListener(LoadLevel);
    }

    private void LoadLevel()
    {
        if( _isOpen) SceneManager.LoadScene($"Level{_numLevel}");
        else Debug.Log($"Current level is {PlayerPrefs.GetInt("Level")}");
    }
}
