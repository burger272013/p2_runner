using UnityEngine;

public class player : MonoBehaviour
{

 void Update()
    {
     
        
            transform.Translate(new Vector3(0, 0, 10) * Time.deltaTime); 
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(10, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-10, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 10, 0) * Time.deltaTime);
        }
    }

}
