using Pool.Utilites.AutoSetup;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public partial class Board : MonoBehaviour
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
}

#if UNITY_EDITOR
public partial class Board : IAutoSetupable
{
    [ContextMenu("AutoSetup")]
    public void AutoSetup()
    {
        balls = new();
        balls.AddRange(FindObjectsOfType<Ball>());
        EditorUtility.SetDirty(this);
    }
}
#endif