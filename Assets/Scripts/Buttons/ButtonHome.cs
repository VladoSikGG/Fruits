using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHome : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(()=> SceneManager.LoadScene("MainMenu"));
    }
}
