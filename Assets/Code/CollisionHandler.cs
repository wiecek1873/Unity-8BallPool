using System;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public event Action<Collision> Collision;

    public void OnCollisionEnter(Collision _collision)
    {
        Collision?.Invoke(_collision);
    }
}
