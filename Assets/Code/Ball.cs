using UnityEngine;

public class Ball : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Tags.Pole))
        {
            Destroy(this);
        }
    }
}
