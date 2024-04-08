using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            _pauseMenu.SetActive(true);
        });
    }
}
