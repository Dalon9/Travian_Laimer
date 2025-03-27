using UnityEngine;
using TMPro;

public class StartGameScreen : MonoBehaviour
{
    public TMP_Text HighScoreValue;

    private void OnEnable()
    {
        HighScoreValue.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
