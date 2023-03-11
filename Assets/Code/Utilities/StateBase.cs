using UnityEngine;

namespace Pool.Utilites
{
    public abstract class StateBase : MonoBehaviour
    {
        public abstract void OnStateEnter();
        public abstract void Execute();
        public abstract void OnStateExit();
    }
}