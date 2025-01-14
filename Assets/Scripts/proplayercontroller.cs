using UnityEngine;

public class proplayercontroller : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �������� �������� ���������
    public float lookSpeed = 2.0f; // �������� �������� ���������

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Start()
    {
        // ������������� ������ � ������ ������
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // �������� ���� � ���������� ��� ��������
        float moveForwardBack = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float moveLeftRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        // ����������� ���������
        transform.Translate(moveLeftRight, 0, moveForwardBack);

        // �������� ���� � ���� ��� ��������
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;

        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90, 90);

        // ��������� �������
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
}
