using System;
using UnityEngine;

public partial class TurnCounter : MonoBehaviour
{
    public event Action<int> TurnChanged;

    [SerializeField][Min(1)] private int turn = 1;
    [SerializeField][Min(1)] private int maxTurns = 10;

    public int GetTurn()
    {
        return turn;
    }

    public int GetTurnMax()
    {
        return maxTurns;
    }

    public void AddTurn(int _turn)
    {
        turn += _turn;
        turn = Mathf.Min(maxTurns, turn);

        TurnChanged?.Invoke(turn);
    }
}

#if UNITY_EDITOR
public partial class TurnCounter
{
    private void OnValidate()
    {
        if (maxTurns < turn)
        {
            maxTurns = turn;
        }
    }
}
#endif