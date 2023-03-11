using UnityEngine;

public class Ball : MonoBehaviour
{
    private const float VELOCITY_MIN = 0.1f;

    [SerializeField] private Rigidbody rb;

    public bool IsMoving()
    {
        return rb.velocity.magnitude > VELOCITY_MIN;
    }

    public void AddForce(Vector3 _force, ForceMode _forceMode)
    {
        rb.AddForce(_force, _forceMode);
    }
}
