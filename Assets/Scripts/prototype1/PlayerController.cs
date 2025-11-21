using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isPlayer1 = true;

    public Camera[] cameras;

    public float speed = 20f;
    public float turnSpeed = 50f;

    private float hor;
    private float vert;
    private int camIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var cam in cameras)
        {
            cam.gameObject.SetActive(false);
        }
        cameras[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                SwitchCamera();
            }

            hor = Input.GetAxis("Horizontal 1");
            vert = Input.GetAxis("Vertical 1");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                SwitchCamera();
            }

            hor = Input.GetAxis("Horizontal 2");
            vert = Input.GetAxis("Vertical 2");
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vert);
        transform.Rotate(Vector3.up, hor * turnSpeed * Time.deltaTime);
    }

    private void SwitchCamera()
    {
        cameras[camIndex].gameObject.SetActive(false);

        camIndex = (camIndex + 1) % cameras.Length;

        cameras[camIndex].gameObject.SetActive(true);
    }
}
