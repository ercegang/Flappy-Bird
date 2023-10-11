using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Link to the TextMeshPro Text element in the Inspector.

    private int score = 0;

    // Update the score and display it in the TextMeshPro Text element.
    private void UpdateScore()
    {
        score++; // Example: Increment the score.
        scoreText.text = "Score: " + score.ToString();
    }

    // Rest of your code...
}
