
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score =0;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void IncreaseScore(int amount) {
        score += amount;
        scoreText.text = "Score: " + score.ToString();
    }
}
