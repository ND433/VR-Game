using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    float time = 15f;
    bool hasStarted = false;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;
    public int score = 0;

    public void AddScore()
    {
        hasStarted = true;
        time = 15f;
        score++;
        scoreText.text = $"Score: {score}/10";
        if (score >= 10) SceneManager.LoadScene("Win Screen");
    }

    private void Update()
    {
        if (!hasStarted) return;

        time -= Time.deltaTime;
        if (time < 0) SceneManager.LoadScene("Lose Screen");

        timeText.text = $"Time: {time:0.00}s";
    }
}
