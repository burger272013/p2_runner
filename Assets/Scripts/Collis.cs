using UnityEngine;

public class Collis : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("������� ������������" + " " + collision.gameObject.name + " - gameObject.name"); //������� ��������� ��� ������ ������� ������ �������� (��� �������)
       // Destroy(collision.gameObject); //������� ���� ���� �� ���������
    }
}
