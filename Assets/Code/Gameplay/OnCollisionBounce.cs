using UnityEngine;

public class OnCollisionBounce : MonoBehaviour
{
    [SerializeField][Min(0f)] private float bounciness = 0.9f;

    private void OnCollisionEnter(Collision _collision)
    {
        Rigidbody _rigidbody = _collision.rigidbody;

        Vector3 _bounceDirection = Vector3.Reflect(_rigidbody.velocity.normalized, _collision.GetContact(0).normal);
        _rigidbody.velocity = _bounceDirection * Mathf.Max(_rigidbody.velocity.magnitude * bounciness, 0f);
    }
}
