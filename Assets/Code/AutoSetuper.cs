using UnityEngine;

public class AutoSetuper : MonoBehaviour
{
    [SerializeField] private bool onAwake = false;

    private void Awake()
    {
        if (onAwake == false)
        {
            return;
        }

        MonoBehaviour[] _monoBehaviours = FindObjectsOfType<MonoBehaviour>(true);

        foreach (MonoBehaviour _monoBehaviour in _monoBehaviours)
        {
            IAutoSetupable _autoSetupable = _monoBehaviour as IAutoSetupable;

            if (_autoSetupable != null)
            {
                _autoSetupable.AutoSetup();
            }
        }
    }
}
