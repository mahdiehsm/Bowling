using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // توپ (Target) که دوربین باید دنبال کند
    public float smoothSpeed = 0.125f; // سرعت نرم‌کردن حرکت دوربین
    public Vector3 offset; // فاصله دوربین از توپ

    void LateUpdate()
    {
        // موقعیت جدید دوربین با توجه به موقعیت توپ و offset
        Vector3 desiredPosition = target.position + offset; 
        // نرم‌کردن حرکت دوربین
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        // به موقعیت جدید منتقل شوید
        transform.position = smoothedPosition;

        // دوربین به سمت توپ نگاه کند
        transform.LookAt(target);
    }
}



