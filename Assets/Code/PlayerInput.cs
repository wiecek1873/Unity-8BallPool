using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string axisNameHorizontal = "Horizontal";
    [SerializeField] private string axisNameVertical = "Vertical";
    [SerializeField] private KeyCode spaceKey = KeyCode.Space;

    public float GetHorizontalAxis()
    {
        return Input.GetAxis(axisNameHorizontal);
    }

    public float GetVerticalAxis()
    {
        return Input.GetAxis(axisNameVertical);
    }

    public bool GetSpaceKeyUp()
    {
        return Input.GetKeyUp(spaceKey);
    }
}
