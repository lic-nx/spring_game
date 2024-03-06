// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class flover : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public float speed = 5f;
//     // public Transform leftCheck;

//     private bool isBlockedLeft = false;
//     private void OnTriggerEnter(Collision collision)
//     {
//         isBlockedLeft = true;
//     }
//     // private void OnTriggerExit(Collider other)
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         // Проверка наличия объекта слева
//         // isBlockedLeft = Physics2D.Linecast(transform.position, leftCheck.position, LayerMask.GetMask("Obstacles"));
//         if (transform.position.x >= -8f && !isBlockedLeft) {
//             transform.Translate(Vector2.left * speed * Time.deltaTime);
//         } 
//         // else if (transform.position.x <= 4.3f) {
//             // transform.position = new Vector2(4.3f, transform.position.y);
//         // }
//         // Если слева нет объекта, двигаемся влево
//         // if (!isBlockedLeft)
//         // {
//         //     transform.Translate(Vector2.left * speed * Time.deltaTime);
//         // }
//     }
// }
