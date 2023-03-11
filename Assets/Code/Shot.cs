using UnityEngine;

public class Shot : MonoBehaviour
{
    public Ball TargetBall = null;
    public PlayerInput PlayerInput = null;

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

    //todo Make it simpler
    public void ChangeState(ShotState _nextState)
    {
        if (_nextState == null)
        {
            if (stateCurrent != null)
            {
                stateCurrent.OnStateExit();
            }
            return;
        }

        if (stateCurrent != null)
        {
            stateCurrent.OnStateExit();
        }

        stateCurrent = _nextState;
        stateCurrent.OnStateEnter();
    }
}
