using UnityEngine;

public class game_over : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("ты проиграл(нужно быть выше!)"); //выводит сообщениечто хоз€ин скрипта когото коснулс€ (им€ объекта)
        collision.gameObject.transform.position = new Vector3(0, 4, 84); //телепоррт игрока в начало
    }
}
