
using UnityEngine;
using UnityEngine.EventSystems;


public class block_for_braick : MonoBehaviour
{

    private int count = 0;
   void OnMouseDown()
   {
        count += 1;
    	Debug.Log( count);
        if (count == 3 ){
            Destroy(gameObject);
        }
	}
//     void OnMouseDown()
//    {
//        count += 1;
//     	Debug.Log( count);
//     	Debug.Log( count);
//    }

	// public void OnPointerUp(PointerEventData eventData)
	// {
	// 	 Debug.Log( "нажмите еще : ");
	// }
}
