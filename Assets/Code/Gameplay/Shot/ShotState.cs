using Pool.Utilites;
using UnityEngine;

public abstract class ShotState : StateBase
{
    [Header("State")]
    [SerializeField] protected Shot context = null;
    [SerializeField] protected ShotState nextState = null;

    private void Reset()
    {
        context = GetComponent<Shot>();
    }
}
