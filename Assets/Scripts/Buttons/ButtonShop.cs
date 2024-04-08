using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonShop : MonoBehaviour
{
    [SerializeField] private GameObject _shopMenu;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            _shopMenu.SetActive(true);
        });
    }
}
