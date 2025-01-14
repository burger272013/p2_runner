using UnityEngine;

public class WinSript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
      print("1 уровень пройден!"); //выводит сообщениечто хоз€ин скрипта когото коснулс€ (им€ объекта)
        collision.gameObject.transform.position = new Vector3(-33, 4, 84); //телепоррт игрока в начало
    }  
    
}
