using UnityEngine;

public class ShotState_AimDirection : ShotState
{
    [SerializeField] private float maxDegreesDelta = 180f;

    private Quaternion direction = Quaternion.Euler(Vector3.forward);

    public override void OnStateEnter()
    {
        context.Visualization.gameObject.SetActive(true);
    }

    public override void Execute()
    {
        if (Mathf.Abs(context.PlayerInput.GetHorizontalAxis()) > Mathf.Epsilon || Mathf.Abs(context.PlayerInput.GetVerticalAxis()) > Mathf.Epsilon)
        {
            updateDirection();
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

    public Vector3 GetDirection()
    {
        return direction * Vector3.forward;
    }

    private void updateDirection()
    {
        Vector3 _inputDirection = new Vector3(context.PlayerInput.GetHorizontalAxis(), 0f, context.PlayerInput.GetVerticalAxis()).normalized;
        direction = Quaternion.RotateTowards(direction, Quaternion.LookRotation(_inputDirection, Vector3.up), maxDegreesDelta * Time.deltaTime);
    }

    private void updateVisualisation()
    {
        Vector3 _startPosition = context.TargetBall.transform.position;

        context.Visualization.SetStartPosition(_startPosition);
        context.Visualization.SetDirection(GetDirection());
    }
}
