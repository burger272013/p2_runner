using UnityEngine;

public class PlayerControllerAxes : MonoBehaviour
{
    void Update()
    {


        transform.Translate(new Vector3(0, 0, 10) * Time.deltaTime * Input.GetAxis("Vertical")); 
        transform.Translate(new Vector3(10, 0, 0) * Time.deltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(new Vector3(0, 10, 0) * Time.deltaTime * Input.GetAxis("Jump"));


    }
}
