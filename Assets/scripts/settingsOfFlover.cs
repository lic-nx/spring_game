using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsOfFlover : MonoBehaviour
{
    // private Vector3 pos;
    // public GameObject enemy;

    public Transform objectToMove; // Объект, который нужно переместить
    public Triggers[] triggers; // Массив триггеров на 

    void Start(){
        
        // pos = transform.position;
        // Moved();
        // Invoke("CreateTrigger", 3f);    
    }
    void Update(){
        Invoke ("Moved", 3f);
        // Moved();
        
    }
    void Moved(){
        foreach(Triggers trigger in triggers)
        {
            if(trigger.get_status()  == false) // Если в триггере нет элементов
            {
                objectToMove.position = trigger.transform.position; // Перемещаем объект на место триггера
                break; // Прерываем цикл, так как переместили объект
            }
        }
    }
    void CreateTrigger(){
        // float posX = pos.x;
        // float posY = pos.y;
        // создание и вращение тригеров
        // for (float i = posX-1; i < posX + 2; i++) {
        //     for(float j = posY; j < posY+2; j ++){
        //         GameObject newObject = Instantiate(enemy, new Vector3(i,j , 0), Quaternion.identity);
        //         Vector3 direction = pos - newObject.transform.position;
        //         Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        //         newObject.transform.rotation = rotation;
        //     }
        // }
    }
}
