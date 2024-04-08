using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNextLevel : MonoBehaviour
{
    private void Start()
    {
        LevelParameters lvlParameters = FindObjectOfType<LevelParameters>();
        GetComponent<Button>().onClick.AddListener(()=>
        {
            Time.timeScale = 1;
            if (PlayerPrefs.GetInt("Level") > lvlParameters.GetNumLevel())
            {
                SceneManager.LoadScene($"Level{PlayerPrefs.GetInt("Level")}");
            }
            else
            {
                SceneManager.LoadScene($"Level{lvlParameters.GetNumLevel()+1}");
            }

        });
    }
}
