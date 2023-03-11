using UnityEngine;

public class ShotStateShot : ShotState
{
    [SerializeField] private ShotStateAimDirection shotStateAimDirection = null;
    [SerializeField] private ShotStateAimForce shotStateAimForce = null;

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
