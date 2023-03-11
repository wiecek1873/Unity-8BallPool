using UnityEngine;

public class ShotState_Shot : ShotState
{
    [SerializeField] private ShotState_AimDirection shotStateAimDirection = null;
    [SerializeField] private ShotState_AimForce shotStateAimForce = null;

    public override void OnStateEnter() { }

    public override void Execute()
    {
        if (context.PlayerInput.GetSpaceKeyUp())
        {
            context.TargetBall.AddForce(shotStateAimDirection.GetDirection().normalized * shotStateAimForce.GetForce(), ForceMode.Impulse);
            context.ChangeState(nextState);
        }
    }

    public override void OnStateExit() { }
}
