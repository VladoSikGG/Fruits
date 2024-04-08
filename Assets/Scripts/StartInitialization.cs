using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInitialization : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
        
        if (!PlayerPrefs.HasKey("Money"))
        {
            PlayerPrefs.SetInt("CurrentSkin", 0);
            PlayerPrefs.SetFloat("Sounds", 1);
            PlayerPrefs.SetFloat("Music", 1);
            PlayerPrefs.SetInt("Money", 25);
            PlayerPrefs.SetInt("Level", 1);
        }
    }
}
