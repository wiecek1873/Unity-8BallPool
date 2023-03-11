using UnityEngine;

namespace Pool.Utilites
{
    public static class ExtensionsRigidbody
    {
        public static void Reset(this Rigidbody _rigidbody)
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
        }
    }
}