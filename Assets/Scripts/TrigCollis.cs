using UnityEngine;

//дл€ взаимодействи€ с обектами
public class TrigCollis : MonoBehaviour
{
    //взаимодействие с вещами
    private void OnCollisionEnter(Collision collision)
    {
        print("колизи€ активирована" + " " + collision.gameObject.name + " - gameObject.name"); //выводит сообщение что хоз€ин скрипта когото коснулс€ (им€ объекта)
       // Destroy(collision.gameObject); //удал€ет того кого мы коснулись
       // Destroy(gameObject); //удал€ет хоз€ина скрипта
    }

    //когда ты можешь проходить сквозь объекты но чтото будет происходит
    private void OnTriggerEnter(Collider other)
    {
        print("тригер активирован" + " " + other.gameObject.name + " - gameObject.name"); //выводит сообщениечто хоз€ин скрипта прошел сквозь какойто объект (им€ объекта)
        Destroy(other.gameObject); //удал€ет того с квозь кого мы прошли
    }
}
