using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb = null;
    [SerializeField] private float maxAngularVelocity = 100f;
    [SerializeField] private AnimationCurve angularDragPerVelocity = AnimationCurve.Linear(0f, 2.5f, 1f, 0.05f);

    public void Awake()
    {
        rb.maxAngularVelocity = maxAngularVelocity;
    }

    private void FixedUpdate()
    {
        rb.angularDrag = angularDragPerVelocity.Evaluate(rb.velocity.magnitude);
    }

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
