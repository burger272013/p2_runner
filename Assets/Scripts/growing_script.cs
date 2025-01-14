using UnityEngine;

public class growing_script : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "growing")
        {
            print("kogda mi kosaemsya objecta to mi budem chtoto delaty");
            gameObject.transform.localScale = gameObject.transform.localScale + new Vector3(1, 1, 1);

            print("колизи€ активирована" + " " + other.gameObject.name + " - gameObject.name"); //выводит сообщение что хоз€ин скрипта когото коснулс€ (им€ объекта)
            Destroy(other.gameObject); //удал€ет того кого мы коснулись
        }
        if (other.tag == "small")
        {
            print("kogda mi kosaemsya objecta to mi budem chtoto delaty");
            gameObject.transform.localScale = gameObject.transform.localScale - new Vector3(1, 1, 1);
            print("колизи€ активирована" + " " + other.gameObject.name + " - gameObject.name"); //выводит сообщение что хоз€ин скрипта когото коснулс€ (им€ объекта)
            Destroy(other.gameObject); //удал€ет того кого мы коснулись
        }
    }
}
