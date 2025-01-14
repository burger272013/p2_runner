using UnityEngine;

public class Collis : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("колизи€ активирована" + " " + collision.gameObject.name + " - gameObject.name"); //выводит сообщение что хоз€ин скрипта когото коснулс€ (им€ объекта)
       // Destroy(collision.gameObject); //удал€ет того кого мы коснулись
    }
}
