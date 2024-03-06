using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{

    public bool isTriggered;
    public bool get_status(){
        return isTriggered;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {   
        isTriggered = true;
            
            // Выводим сообщение в консоль
            Debug.Log("В триггере есть элемент");
       
    }

 void OnTriggerExit2D(Collider2D other)
    {
        isTriggered = false;
        
            // Destroy(gameObject);
        Debug.Log(  "вышли из тригера");
        Debug.Log( isTriggered );
    
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(  "работает");
    }

}
