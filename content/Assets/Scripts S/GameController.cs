using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text ScoreTextLeft;
    public TMP_Text ScoreTextRight;

    private int scoreLeft = 0;
    private int scoreRight = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         // Optionally update the UI on start
    }

    // Update is called once per frame
    void Update()
    {
        // Game logic to update the score can go here, if needed
    }

    public void ScoreGoalLeft()
    {
        Debug.Log("ScoreGoalLeft");
        this.scoreLeft += 1; // Correctly increment the left score
        UpdateUI();
    }

    public void ScoreGoalRight()
    {
        Debug.Log("ScoreGoalRight");
        this.scoreRight += 1; // Correctly increment the right score
        UpdateUI();
    }

    private void UpdateUI()
    {
        this.ScoreTextLeft.text = this.scoreLeft.ToString();
        this.ScoreTextRight.text = this.scoreRight.ToString();
    }
}
