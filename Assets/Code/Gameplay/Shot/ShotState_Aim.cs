using UnityEngine;

public class ShotState_Aim : ShotState
{
    [Header("Direction")]
    [SerializeField] private float directionMaxDeltaDegrees = 180f;

    [Header("Force")]
    [SerializeField][Min(0f)] private float forceMin = 1f;
    [SerializeField][Min(0f)] private float forceMax = 5f;
    [SerializeField] private float forceMaxDelta = 5f;

    private float force = 0f;
    private Quaternion direction = Quaternion.identity;

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
        if (Mathf.Abs(context.PlayerInput.GetHorizontalAxis()) > Mathf.Epsilon)
        {
            updateDirection();
        }

        if (Mathf.Abs(context.PlayerInput.GetVerticalAxis()) >= Mathf.Epsilon)
        {
            updateForce();
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

        context.Force = getDirection() * force;
    }

    private Vector3 getDirection()
    {
        return direction * Vector3.forward;
    }

    private void updateDirection()
    {
        direction *= Quaternion.AngleAxis(directionMaxDeltaDegrees * context.PlayerInput.GetHorizontalAxis() * Time.deltaTime, Vector3.up);
    }

    private void updateForce()
    {
        force = Mathf.MoveTowards(force, Mathf.Clamp(context.PlayerInput.GetVerticalAxis() * forceMax, forceMin, forceMax), forceMaxDelta * Time.deltaTime);
    }

    private void updateVisualisation()
    {
        Vector3 _startPosition = context.TargetBall.transform.position;

        context.Visualization.SetStartPosition(_startPosition);
        context.Visualization.SetDirection(getDirection());
        context.Visualization.SetLengthClamped(Mathf.InverseLerp(forceMin, forceMax, force));
    }
}
