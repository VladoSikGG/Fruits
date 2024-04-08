using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffGameObjects : MonoBehaviour
{
    [SerializeField] private GameObject _gameItems;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            _gameItems.SetActive(false);
            Time.timeScale = 0;
        });
    }
}
