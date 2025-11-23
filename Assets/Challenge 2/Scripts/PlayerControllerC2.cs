using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerC2 : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogSpawnColldown = 1f;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > dogSpawnColldown)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, transform.rotation);
                timer = 0;
            }
        }
    }
}
