using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int totalQuestions = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }
    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetTotalQuestions()
    {
        return totalQuestions;
    }
    public void IncrementTotalQuestions()
    {
        totalQuestions++;
    }

    public int calculateScore()
    {
        return Mathf.RoundToInt((float)correctAnswers / (float)totalQuestions * 100);
    }
}
