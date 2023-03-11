using System;
using UnityEngine;

public class TurnCounter : MonoBehaviour
{
    public event Action<int> TurnChanged;

    [SerializeField] private int turn = 1;
    [SerializeField] private int maxTurns = 10;

    public int GetTurn()
    {
        return turn;
    }

    public int GetTurnMax()
    {
        return maxTurns;
    }

    private void AddTurn(int _turn)
    {
        turn += _turn;
        turn = Mathf.Min(maxTurns, turn);

        TurnChanged?.Invoke(turn);
    }
}
