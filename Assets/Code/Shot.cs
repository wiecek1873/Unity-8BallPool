using UnityEngine;

public class Shot : MonoBehaviour
{
    [Header("States")]
    public ShotStateDirection StateDirection = null;
    public ShotStateForce StateForce = null;
    public ShotStateWait StateWait = null;

    private ShotState stateCurrent = null;

    private void Start()
    {
        ChangeState(StateDirection);
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
