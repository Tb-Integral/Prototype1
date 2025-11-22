using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topValueForDestroy = 30f;
    [SerializeField] private float lowerValueForDestroy = -30f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topValueForDestroy || transform.position.z < lowerValueForDestroy)
        {
            Debug.Log("Игра окончена!");
            Destroy(gameObject);
        }
    }
}
