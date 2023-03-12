using UnityEngine;

public class ShotState_NextTurn : ShotState
{
    [Header("Next turn")]
    [SerializeField] private TurnCounter turnCounter = null;

    public override void Execute() { }

    public override void OnStateEnter()
    {
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
