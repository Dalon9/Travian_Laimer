using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    public TMP_Text ScoreValue;
    public TMP_Text HighScoreValue;

    private void OnEnable()
    {
        ScoreValue.text = ((int)GameManager.Instance.Distance).ToString();
        HighScoreValue.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
