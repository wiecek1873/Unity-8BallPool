using System;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public event Action<int> ScoreChanged;

    [SerializeField] private int score;

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int _points)
    {
        score += _points;
        ScoreChanged?.Invoke(score);
    }
}
