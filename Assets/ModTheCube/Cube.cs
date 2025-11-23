using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    [SerializeField] private Vector3 position = new Vector3(3, 4, 1);
    [SerializeField] private float rotateSpeed = 10f;
    [SerializeField] private float colorRepeating = 1f;
    private Material material;
    //[SerializeField] private Vector3 localPosition;

    void Start()
    {
        transform.position = position;
        //transform.localScale = Vector3.one * 1.3f;
        
        material = Renderer.material;

        InvokeRepeating("ChangeColor", 0, colorRepeating);
    }
    
    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0.0f, 0.0f);
    }

    void ChangeColor()
    {
        material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
