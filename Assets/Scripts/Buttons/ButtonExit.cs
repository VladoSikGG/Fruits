using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExit : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(()=>Application.Quit());
    }
}
