using UnityEngine;

public class CameraControlle : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            transform.Rotate(new Vector3(100, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.I))
        {
            transform.Rotate(new Vector3(-100, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(new Vector3(0,100, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(new Vector3(0,-100, 0) * Time.deltaTime);
        }
    }
}
