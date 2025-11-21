using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private float xRange = 10f;
    [SerializeField] private float speed = 10f;
    [SerializeField] private GameObject foodPrefab;
    private float horizontal;

    void Start()
    {
        
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * speed * Vector3.right * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position + Vector3.forward * 0.5f , Quaternion.identity);
        }
    }
}
