using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour, IAutoSetupable
{
    [SerializeField] private List<Ball> balls = new();

    public void AutoSetup()
    {
        balls = new();
        balls.AddRange(FindObjectsOfType<Ball>());
    }
}

