using UnityEngine;

   public class CameraFollow : MonoBehaviour
   {
       public Transform target;  // توپ
       public Vector3 offset;     // فاصله دوربین از توپ

       void Start()
       {
           // تنظیم offset (فاصله)
           offset = transform.position - target.position;
       }

       void LateUpdate()
       {
           // حرکت دوربین با توپ
           transform.position = target.position + offset;
       }
   }



