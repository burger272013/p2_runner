using UnityEngine;

public class growing_script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "growing")
        {
            print("kogda mi kosaemsya objecta to mi budem chtoto delaty");
            gameObject.transform.localScale = gameObject.transform.localScale + new Vector3(1, 1, 1);

            print("������� ������������" + " " + other.gameObject.name + " - gameObject.name"); //������� ��������� ��� ������ ������� ������ �������� (��� �������)
            Destroy(other.gameObject); //������� ���� ���� �� ���������
        }
        if (other.tag == "small")
        {
            print("kogda mi kosaemsya objecta to mi budem chtoto delaty");
            gameObject.transform.localScale = gameObject.transform.localScale - new Vector3(1, 1, 1);
            print("������� ������������" + " " + other.gameObject.name + " - gameObject.name"); //������� ��������� ��� ������ ������� ������ �������� (��� �������)
            Destroy(other.gameObject); //������� ���� ���� �� ���������
        }
    }
}
