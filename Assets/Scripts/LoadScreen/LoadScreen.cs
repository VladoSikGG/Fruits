using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class LoadScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        StartCoroutine(PlusPercent());
    }

    private IEnumerator PlusPercent()
    {
        int temp = Random.Range(0, 10);
        _text.text = $"{temp}%";
        yield return new WaitForSeconds(0.5f);
        _text.text = "22%"; 
        yield return new WaitForSeconds(1f);
        _text.text = "57%"; 
        yield return new WaitForSeconds(0.5f);
        _text.text = "81%"; 
        yield return new WaitForSeconds(1.5f);
        _text.text = "97%"; 
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}
