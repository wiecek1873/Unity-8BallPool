using UnityEngine;

public class Shot : MonoBehaviour
{
    public Ball TargetBall = null;
    public PlayerInput PlayerInput = null;
    public ShotVisualization Visualization = null;

    [SerializeField] private ShotState startState = null;

    private ShotState stateCurrent = null;

    private void Start()
    {
        ChangeState(startState);
    }

    private void Update()
    {
        stateCurrent.Execute();
    }

    public void ChangeState(ShotState _nextState)
    {
        if (stateCurrent != null)
        {
            stateCurrent.OnStateExit();
        }

        stateCurrent = _nextState;

        if (stateCurrent != null)
        {
            stateCurrent.OnStateEnter();
        }
        else
        {
            enabled = false;
        }
    }
}
