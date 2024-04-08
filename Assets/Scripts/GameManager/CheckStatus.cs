using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CheckStatus : MonoBehaviour
{
    [SerializeField] private GameObject _screenLose, _screenWin, _gameItems;
    [SerializeField] private AudioSource _winSound, _loseSound;

    private void Start()
    {
        _winSound.volume = PlayerPrefs.GetFloat("Sounds");
        _loseSound.volume = PlayerPrefs.GetFloat("Sounds");
    }

    public void Win()
    {
        _screenWin.transform.localScale = new Vector3(0, 0, 0);
        _screenWin.SetActive(true);
        _gameItems.SetActive(false);
        _winSound.Play();
        if (PlayerPrefs.GetInt("Level") <= GetComponent<LevelParameters>().GetNumLevel()) PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level")+1);
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 10);
        Time.timeScale = 0;
        _screenWin.transform.DOScale(new Vector3(1, 1, 1), 1).SetUpdate(true);
    }

    public void Lose()
    {
        _screenLose.transform.localScale = new Vector3(0, 0, 0);
        _screenLose.SetActive(true);
        _gameItems.SetActive(false);
        _loseSound.Play();
        Time.timeScale = 0;
        _screenLose.transform.DOScale(new Vector3(1, 1, 1), 1).SetUpdate(true);
    }
}
