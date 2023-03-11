using UnityEngine;

public class ShotVisualization : MonoBehaviour
{
    [SerializeField] private LineRenderer lineRenderer = null;
    [SerializeField] private float lengthMin = 0.25f;
    [SerializeField] private float lengthDefault = 1.0f;
    [SerializeField] private float lengthMax = 2f;

    private Vector3 startPosition = default;
    private Vector3 direction = default;
    private float length = 0f;

    public void OnEnable()
    {
        length = lengthDefault;
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

    public void SetLengthClamped(float t)
    {
        length = Mathf.Lerp(lengthMin, lengthMax, t);
        updateLineRenderer();
    }

    private void updateLineRenderer()
    {
        lineRenderer.SetPosition(0, startPosition);
        lineRenderer.SetPosition(1, startPosition + direction * length);
    }
}
