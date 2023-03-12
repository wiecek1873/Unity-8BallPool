using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //Used KeyCodes instead of axis to work correctly after export to .unitypackage and load on clean project
    [SerializeField] private KeyCode horizontalAxisNegativeKey = KeyCode.A;
    [SerializeField] private KeyCode horizontalAxisPositiveKey = KeyCode.D;
    [SerializeField] private KeyCode verticalAxisNegativeKey = KeyCode.S;
    [SerializeField] private KeyCode verticalAxisPositiveKey = KeyCode.W;
    [SerializeField] private KeyCode spaceKey = KeyCode.Space;

    public float GetHorizontalAxis()
    {
        if (Input.GetKey(horizontalAxisNegativeKey))
        {
            return -1f;
        }
        else if (Input.GetKey(horizontalAxisPositiveKey))
        {
            return 1f;
        }
        else
        {
            return 0f;
        }
    }

    public float GetVerticalAxis()
    {
        if (Input.GetKey(verticalAxisNegativeKey))
        {
            return -1f;
        }
        else if (Input.GetKey(verticalAxisPositiveKey))
        {
            return 1f;
        }
        else
        {
            return 0f;
        }
    }

    public bool GetSpaceKeyUp()
    {
        return Input.GetKeyUp(spaceKey);
    }
}
