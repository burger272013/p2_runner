using UnityEngine;

//��� �������������� � ��������
public class TrigCollis : MonoBehaviour
{
    //�������������� � ������
    private void OnCollisionEnter(Collision collision)
    {
        print("������� ������������" + " " + collision.gameObject.name + " - gameObject.name"); //������� ��������� ��� ������ ������� ������ �������� (��� �������)
       // Destroy(collision.gameObject); //������� ���� ���� �� ���������
       // Destroy(gameObject); //������� ������� �������
    }

    //����� �� ������ ��������� ������ ������� �� ����� ����� ����������
    private void OnTriggerEnter(Collider other)
    {
        print("������ �����������" + " " + other.gameObject.name + " - gameObject.name"); //������� ������������ ������ ������� ������ ������ ������� ������ (��� �������)
        Destroy(other.gameObject); //������� ���� � ����� ���� �� ������
    }
}
