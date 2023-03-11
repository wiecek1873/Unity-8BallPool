using Pool.Utilites.AutoSetup;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour, IAutoSetupable
{
    [SerializeField] private List<Ball> balls = new();

    public bool IsAnyBallMoving()
    {
        foreach (Ball _ball in balls)
        {
            if (_ball.IsMoving())
            {
                return true;
            }
        }

        return false;
    }

    [ContextMenu("AutoSetup")]
    public void AutoSetup()
    {
        balls = new();
        balls.AddRange(FindObjectsOfType<Ball>());
    }
}

