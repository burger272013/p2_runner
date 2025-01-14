using UnityEngine;

public class proplayercontroller : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Скорость движения персонажа
    public float lookSpeed = 2.0f; // Скорость поворота персонажа

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Start()
    {
        // Заблокировать курсор в центре экрана
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Получить ввод с клавиатуры для движения
        float moveForwardBack = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float moveLeftRight = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        // Переместить персонажа
        transform.Translate(moveLeftRight, 0, moveForwardBack);

        // Получить ввод с мыши для поворота
        float mouseX = Input.GetAxis("Mouse X") * lookSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeed;

        rotationY += mouseX;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90, 90);

        // Применить поворот
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0);
    }
}
