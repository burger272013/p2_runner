using UnityEngine;

public class player : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime); 
    }
}
