using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
