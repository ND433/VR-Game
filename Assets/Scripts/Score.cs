using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;

    public void AddScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}
