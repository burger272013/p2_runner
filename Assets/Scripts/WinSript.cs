using UnityEngine;

public class WinSript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
      print("1 ������� �������!"); //������� ������������ ������ ������� ������ �������� (��� �������)
        collision.gameObject.transform.position = new Vector3(-33, 4, 84); //��������� ������ � ������
    }  
    
}
