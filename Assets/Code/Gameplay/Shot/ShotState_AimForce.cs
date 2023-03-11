using UnityEngine;

public class ShotState_AimForce : ShotState
{
    [Header("Aim Force")]
    [SerializeField][Min(0f)] private float forceMin = 1f;
    [SerializeField][Min(0f)] private float forceMax = 5f;
    [SerializeField] private float maxDelta = 5f;

    private float force = 0f;

    private void Awake()
    {
        force = forceMin;
    }

    public override void OnStateEnter()
    {
        context.Visualization.gameObject.SetActive(true);
    }

    public override void Execute()
    {
        if (Mathf.Abs(context.PlayerInput.GetVerticalAxis()) >= Mathf.Epsilon)
        {
            force = Mathf.MoveTowards(force, Mathf.Clamp(context.PlayerInput.GetVerticalAxis() * forceMax, forceMin, forceMax), maxDelta * Time.deltaTime);

        }

        updateVisualisation();

        if (context.PlayerInput.GetSpaceKeyUp())
        {
            context.ChangeState(nextState);
        }
    }

    public override void OnStateExit()
    {
        context.Visualization.gameObject.SetActive(false);
    }

    public float GetForce()
    {
        return force;
    }

    private void updateVisualisation()
    {
        context.Visualization.SetLengthClamped(Mathf.InverseLerp(forceMin, forceMax, force));
    }
}
