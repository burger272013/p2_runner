using UnityEngine;

public class WinScript2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("2 уровень пройден!"); //выводит сообщениечто хоз€ин скрипта когото коснулс€ (им€ объекта)
        collision.gameObject.transform.position = new Vector3(-63, 4, 84); //телепоррт игрока в начало
    }
}
