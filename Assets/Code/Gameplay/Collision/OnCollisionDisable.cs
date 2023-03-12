using UnityEngine;

public class OnCollisionDisable : MonoBehaviour
{
    [SerializeField] private string collisionTag = string.Empty;

    private void OnCollisionEnter(Collision _collision)
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
