using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb = null;

    private void OnDisable()
    {
        rb.Reset();
    }

    public bool IsMoving()
    {
        return rb.IsSleeping() == false;
    }

    public void AddForce(Vector3 _force, ForceMode _forceMode)
    {
        rb.AddForce(_force, _forceMode);
    }
}
