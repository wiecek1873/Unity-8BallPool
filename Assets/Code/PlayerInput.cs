using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private string horizontalAxis;
    [SerializeField] private string verticalAxis;

    public float GetHorizontalAxis()
    {
        return Input.GetAxis(horizontalAxis);
    }

    public float GetVerticalAxis()
    {
        return Input.GetAxis(verticalAxis);
    }
}
