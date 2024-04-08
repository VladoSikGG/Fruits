using UnityEngine;

public class RulesMenu : MonoBehaviour
{
    [SerializeField] private GameObject _gameItems;
    private void Start()
    {
        if (PlayerPrefs.HasKey("Tutorial"))
        {
            _gameItems.SetActive(true);
            gameObject.SetActive(false);
        }

        else
        {
            _gameItems.SetActive(false);
        }
    }

    public void CompleteTutorial()
    {
        PlayerPrefs.SetInt("Tutorial", 1);
        _gameItems.SetActive(true);
    }
}
