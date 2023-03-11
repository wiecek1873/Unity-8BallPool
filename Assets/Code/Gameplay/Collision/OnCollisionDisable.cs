using UnityEngine;

public class OnCollisionDisable : OnCollisionBase
{
    [SerializeField] private string collisionTag = string.Empty;

    protected override void onCollision(Collision _collision)
    {
        if (_collision.gameObject.CompareTag(collisionTag) == false)
        {
            return;
        }

        disableGameObject();
    }

    private void disableGameObject()
    {
        gameObject.SetActive(false);
    }
}
