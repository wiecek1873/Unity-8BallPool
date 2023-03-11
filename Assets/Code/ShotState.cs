using UnityEngine;

public abstract class ShotState : StateBase
{
    [SerializeField] protected Shot context = null;
    [SerializeField] protected ShotState nextState = null;

    private void Reset()
    {
        context = GetComponent<Shot>();
    }
}
