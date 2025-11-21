using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topValueForDestroy = 30f;
    [SerializeField] private float lowerValueForDestroy = -30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topValueForDestroy || transform.position.z < lowerValueForDestroy)
        {
            Destroy(gameObject);
        }
    }
}
