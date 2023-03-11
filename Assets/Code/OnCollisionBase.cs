using UnityEngine;

public abstract class OnCollisionBase : MonoBehaviour
{
    [SerializeField] protected CollisionHandler collisionHandler;

    protected virtual void OnEnable()
    {
        if (collisionHandler != null)
        {
            collisionHandler.Collision += onCollision;
        }
    }

    protected virtual void OnDisable()
    {
        if (collisionHandler != null)
        {
            collisionHandler.Collision -= onCollision;
        }
    }

    protected virtual void Reset()
    {
        collisionHandler = GetComponent<CollisionHandler>();
    }

    protected abstract void onCollision(Collision _collision);
}
