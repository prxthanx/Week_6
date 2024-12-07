using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text element
    private int score = 0;

    // Function to add score
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Update the displayed score
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
