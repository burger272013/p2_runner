using UnityEngine;

public class game_over : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("�� ��������(����� ���� ����!)"); //������� ������������ ������ ������� ������ �������� (��� �������)
        collision.gameObject.transform.position = new Vector3(0, 4, 84); //��������� ������ � ������
    }
}
