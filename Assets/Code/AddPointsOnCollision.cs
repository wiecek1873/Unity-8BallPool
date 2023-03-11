using UnityEngine;

public class AddPointsOnCollision : MonoBehaviour, IAutoSetupable
{
    [Header("References")]
    [SerializeField] private CollisionHandler collisionHandler = null;
    [SerializeField] private PointsCounter pointsCounter = null;

    [Header("Settings")]
    [SerializeField] private int points = 0;
    [SerializeField] private string collisionTag = null;

    public void OnEnable()
    {
        collisionHandler.Collision += onCollision;
    }

    public void OnDisable()
    {
        collisionHandler.Collision -= onCollision;
    }

    private void onCollision(Collision _collision)
    {
        if (_collision.gameObject.CompareTag(collisionTag) == false)
        {
            return;
        }

        pointsCounter.AddPoints(points);
    }

    public void AutoSetup()
    {
        pointsCounter = FindObjectOfType<PointsCounter>();
    }
}
