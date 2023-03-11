using UnityEngine;

public class ShotState_Wait : ShotState
{
    [Header("Wait")]
    [SerializeField] private Board board = null;
    [SerializeField] private TurnCounter turnCounter = null;

    public override void OnStateEnter() { }

    public override void Execute()
    {
        if (board.IsAnyBallMoving())
        {
            return;
        }

        if (turnCounter.GetTurn() == turnCounter.GetTurnMax())
        {
            context.ChangeState(null);
        }
        else
        {
            incrementTurnCounter();
            context.ChangeState(nextState);
        }
    }

    public override void OnStateExit() { }

    private void incrementTurnCounter()
    {
        turnCounter.AddTurn(1);
    }
}
