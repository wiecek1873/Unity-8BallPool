using UnityEngine;

public class ShotState_Wait : ShotState
{
    [Header("Wait")]
    [SerializeField] private Board board = null;

    public override void OnStateEnter() { }

    public override void Execute()
    {
        if (board.IsAnyBallMoving())
        {
            return;
        }

        context.ChangeState(nextState);
    }

    public override void OnStateExit() { }
}
