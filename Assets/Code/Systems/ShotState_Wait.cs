using UnityEngine;

public class ShotState_Wait : ShotState
{
    [SerializeField] private Board board = null;

    public override void OnStateEnter() { }

    public override void Execute()
    {
        if (board.IsAnyBallMoving() == false)
        {
            context.ChangeState(nextState);
        }
    }

    public override void OnStateExit() { }
}
