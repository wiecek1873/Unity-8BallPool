using Pool.Utilites.AutoSetup;
using UnityEngine;

public class OnCollisionAddScore : OnCollisionBase, IAutoSetupable
{
    [SerializeField] private ScoreCounter pointsCounter = null;
    [SerializeField] private int score = 0;
    [SerializeField] private string collisionTag = string.Empty;

    protected override void onCollision(Collision _collision)
    {
        if (_collision.gameObject.CompareTag(collisionTag) == false)
        {
            return;
        }

        addScore();
    }

    public void AutoSetup()
    {
        pointsCounter = FindObjectOfType<ScoreCounter>();
    }

    private void addScore()
    {
        if (pointsCounter == null)
        {
            return;
        }

        pointsCounter.AddScore(score);
    }
}
