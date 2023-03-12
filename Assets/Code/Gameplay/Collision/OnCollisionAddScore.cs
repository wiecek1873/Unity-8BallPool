using Pool.Utilites.AutoSetup;
using UnityEditor;
using UnityEngine;

public partial class OnCollisionAddScore : MonoBehaviour
{
    [SerializeField] private ScoreCounter pointsCounter = null;
    [SerializeField] private int score = 0;
    [SerializeField] private string collisionTag = string.Empty;

    private void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.CompareTag(collisionTag) == false)
        {
            return;
        }

        addScore();
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

#if UNITY_EDITOR
public partial class OnCollisionAddScore : IAutoSetupable
{
    [ContextMenu("AutoSetup")]
    public void AutoSetup()
    {
        pointsCounter = pointsCounter != null ? pointsCounter : FindObjectOfType<ScoreCounter>();
        EditorUtility.SetDirty(this);
    }
}
#endif