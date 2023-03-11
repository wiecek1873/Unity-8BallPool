using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    [SerializeField] private int points;

    public int GetPoints()
    {
        return points;
    }

    public void AddPoints(int _points)
    {
        points += _points;
    }

}
