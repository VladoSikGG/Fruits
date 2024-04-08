using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonuses : MonoBehaviour
{
    [Header("SettingsLevel")] 
    [SerializeField] private LevelParameters _lvlParam;
    [Header("BigPlatform")] 
    [SerializeField] private float _durationBonus, 
                                    _speedFlicker, 
                                    _timeForFlick;
    
    public void UseBigPlatform()
    {
        if (PlayerPrefs.GetInt("Bonus") > 0)
        {
            PlayerPrefs.SetInt("Bonus", PlayerPrefs.GetInt("Bonus") - 1);
            StartCoroutine(IncreasePlatform());
        }
    }

    private IEnumerator IncreasePlatform()
    {
        gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1);
        yield return new WaitForSeconds(_durationBonus - _timeForFlick);
        float time = 0;
        int _sideForFlick = 1;
        while (time < _timeForFlick)
        {
            if (gameObject.GetComponent<SpriteRenderer>().color.a <= 0.5f) _sideForFlick = -1;
            else if (gameObject.GetComponent<SpriteRenderer>().color.a >= 0.9f) _sideForFlick = 1;
        
            gameObject.GetComponent<SpriteRenderer>().color = new Color(
                gameObject.GetComponent<SpriteRenderer>().color.r,
                gameObject.GetComponent<SpriteRenderer>().color.g,
                gameObject.GetComponent<SpriteRenderer>().color.b,
                gameObject.GetComponent<SpriteRenderer>().color.a - (Time.deltaTime*_speedFlicker*_sideForFlick));
            

            time += Time.deltaTime;
            Debug.Log(time);
            yield return new WaitForSeconds(0.001f);
        }
        
        gameObject.transform.localScale = new Vector3(_lvlParam.GetSizePlatform(), _lvlParam.GetSizePlatform(), 1);
        gameObject.GetComponent<SpriteRenderer>().color = new Color(
            gameObject.GetComponent<SpriteRenderer>().color.r,
            gameObject.GetComponent<SpriteRenderer>().color.g,
            gameObject.GetComponent<SpriteRenderer>().color.b,
            1);
    }
}
