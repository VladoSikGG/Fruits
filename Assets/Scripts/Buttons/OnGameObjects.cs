using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnGameObjects : MonoBehaviour
{
    [SerializeField] private GameObject _gameItems;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            _gameItems.SetActive(true);
            Time.timeScale = 1;
        });
    }
}
