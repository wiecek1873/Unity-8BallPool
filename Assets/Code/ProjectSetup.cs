using UnityEngine;

//Script to initialize crucial project settings
public class ProjectSetup : MonoBehaviour
{
    public void Awake()
    {
        Time.fixedDeltaTime = 0.001f;
    }
}
