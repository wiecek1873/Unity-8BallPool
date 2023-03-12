using UnityEngine;

public class ShotState_Shot : ShotState
{
    public override void OnStateEnter()
    {
        context.TargetBall.AddForce(context.Force, ForceMode.Impulse);
        context.ChangeState(nextState);
    }

    public override void Execute() { }

    public override void OnStateExit() { }
}
