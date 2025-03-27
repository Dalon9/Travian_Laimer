using UnityEngine;
using TMPro;

public class OverlayUI : MonoBehaviour
{
    public TMP_Text ScoreValue;
    public TMP_Text HighScoreValue;


    private void Start()
    {
        UpdateHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreValue.text = ((int)GameManager.Instance.Distance).ToString();
    }

    public void UpdateHighScore()
    {
        HighScoreValue.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
