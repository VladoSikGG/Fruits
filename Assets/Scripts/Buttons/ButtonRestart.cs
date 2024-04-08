using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonRestart : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
        GetComponent<Button>().onClick.AddListener(()=>SceneManager.LoadScene(SceneManager.GetActiveScene().name));
    }
}
