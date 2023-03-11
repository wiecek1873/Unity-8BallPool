using Pool.Utilites.AutoSetup;
using UnityEngine;

public class AutoSetuper : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private bool onAwake = false;

    [ContextMenu("Auto setup")]
    private void Awake()
    {
        if (onAwake == false)
        {
            return;
        }

        MonoBehaviour[] _monoBehaviours = FindObjectsOfType<MonoBehaviour>(true);

        foreach (MonoBehaviour _monoBehaviour in _monoBehaviours)
        {
            if (_monoBehaviour is IAutoSetupable _autoSetupable)
            {
                _autoSetupable.AutoSetup();
            }
        }
    }

#endif
}
