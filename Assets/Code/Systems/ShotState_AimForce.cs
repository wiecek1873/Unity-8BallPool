using UnityEngine;

public class ShotState_AimForce : ShotState
{
    [SerializeField][Min(0f)] private float forceMin = 0.25f;
    [SerializeField][Min(0f)] private float forceMax = 5f;
    [SerializeField] private float maxDelta = 5f;

    private float force = 0f;

    private void Awake()
    {
        force = forceMin;
    }

    public override void OnStateEnter() { }

    public override void Execute()
    {
        if (Mathf.Abs(context.PlayerInput.GetVerticalAxis()) >= Mathf.Epsilon)
        {
            force = Mathf.MoveTowards(force, Mathf.Clamp(context.PlayerInput.GetVerticalAxis() * forceMax, forceMin, forceMax), maxDelta * Time.deltaTime);

        }

        if (context.PlayerInput.GetSpaceKeyUp())
        {
            context.ChangeState(nextState);
        }
    }

    public override void OnStateExit() { }

    public float GetForce()
    {
        return force;
    }
}
