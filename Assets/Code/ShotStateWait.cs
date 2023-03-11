using UnityEngine;

public class ShotStateWait : ShotState
{
    [SerializeField] private Board board = null;

    public override void OnStateEnter() { }

    public override void Execute()
    {
        if (board.IsAnyBallMoving() == false)
        {
            shot.ChangeState(shot.StateDirection);
        }
    }

    public override void OnStateExit() { }
}
