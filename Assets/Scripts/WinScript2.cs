using UnityEngine;

public class WinScript2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("2 ������� �������!"); //������� ������������ ������ ������� ������ �������� (��� �������)
        collision.gameObject.transform.position = new Vector3(-63, 4, 84); //��������� ������ � ������
    }
}
