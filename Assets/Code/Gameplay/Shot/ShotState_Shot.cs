using UnityEngine;

public class ShotState_Shot : ShotState
{
    [SerializeField] private ShotState_AimDirection shotStateAimDirection = null;
    [SerializeField] private ShotState_AimForce shotStateAimForce = null;

    public override void OnStateEnter()
    {
        context.TargetBall.AddForce(shotStateAimDirection.GetDirection().normalized * shotStateAimForce.GetForce(), ForceMode.Impulse);
        context.ChangeState(nextState);
    }

    public override void Execute() { }

    public override void OnStateExit() { }
}
