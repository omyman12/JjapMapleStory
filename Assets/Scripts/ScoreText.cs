using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    TextMeshProUGUI scoreText;

    void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreButton.OnScoreChanged += RefreshUI;

    }

    public void RefreshUI(int newScore)
    {
        scoreText.text = newScore.ToString();
    }    

}
