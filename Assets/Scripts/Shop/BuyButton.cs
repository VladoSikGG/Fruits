using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    [SerializeField] private GameObject _buyPanel;
    public void BuySkin(int numSkin, int cost)
    {
        GetComponent<Button>().onClick.RemoveAllListeners();
        GetComponent<Button>().onClick.AddListener(() =>
        {
            if (PlayerPrefs.GetInt("Money") - cost >= 0)
            {
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - cost);
                PlayerPrefs.SetInt($"{numSkin}", 1);
                PlayerPrefs.SetInt("CurrentSkin", numSkin);
            }
            _buyPanel.SetActive(false);
        });
    }
    
    public void SelectSkin(int numSkin)
    {
        GetComponent<Button>().onClick.RemoveAllListeners();
        GetComponent<Button>().onClick.AddListener(() =>
        {
            PlayerPrefs.SetInt("CurrentSkin", numSkin);
            _buyPanel.SetActive(false);
        });
    }

    public void BuyBonus(int cost)
    {
        GetComponent<Button>().onClick.RemoveAllListeners();
        GetComponent<Button>().onClick.AddListener(() =>
        {
            if (PlayerPrefs.GetInt("Money") - cost >= 0)
            {
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - cost);
                PlayerPrefs.SetInt("Bonus", PlayerPrefs.GetInt("Bonus") + 1);
            }
            _buyPanel.SetActive(false);
        });
        
    }
}
