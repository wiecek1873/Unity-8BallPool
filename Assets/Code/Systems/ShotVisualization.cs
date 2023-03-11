using UnityEngine;

public class ShotVisualization : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer = null;
    [SerializeField] private float lengthMin = 0.75f;
    [SerializeField] private float lengthMax = 2f;

    private Vector3 startPosition = default;
    private Vector3 direction = default;
    private float length = 0f;

    public void Awake()
    {
        length = lengthMin;
    }

    public void SetStartPosition(Vector3 _position)
    {
        startPosition = _position;
        updateLineRenderer();
    }

    public void SetDirection(Vector3 _direction)
    {
        direction = _direction;
        updateLineRenderer();
    }

    public void SetLengthClamped(float _t)
    {
        length = Mathf.Lerp(lengthMin, lengthMax, _t);
        updateLineRenderer();
    }

    private void updateLineRenderer()
    {
        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, startPosition + direction * length);
    }
}
