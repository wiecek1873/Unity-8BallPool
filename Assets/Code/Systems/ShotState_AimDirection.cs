using UnityEngine;

public class ShotState_AimDirection : ShotState
{
    [SerializeField] private Transform visualization = null;
    [SerializeField] private float maxDegreesDelta = 180f;

    private Quaternion direction = Quaternion.Euler(Vector3.forward);

    public override void OnStateEnter()
    {
        //visualization.gameObject.SetActive(true);
    }

    public override void Execute()
    {
        if (Mathf.Abs(context.PlayerInput.GetHorizontalAxis()) > Mathf.Epsilon || Mathf.Abs(context.PlayerInput.GetVerticalAxis()) > Mathf.Epsilon)
        {
            Vector3 _inputDirection = new Vector3(context.PlayerInput.GetHorizontalAxis(), 0f, context.PlayerInput.GetVerticalAxis()).normalized;
            direction = Quaternion.RotateTowards(direction, Quaternion.LookRotation(_inputDirection, Vector3.up), 180f * Time.deltaTime);
        }

        if (context.PlayerInput.GetSpaceKeyUp())
        {
            context.ChangeState(nextState);
        }
    }

    public override void OnStateExit()
    {
        //visualization.gameObject.SetActive(false);
    }

    public Vector3 GetDirection()
    {
        return direction * Vector3.forward;
    }
}
