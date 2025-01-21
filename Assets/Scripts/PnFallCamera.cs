using UnityEngine;

public class PinFallCamera : MonoBehaviour
{
    public Transform targetPin; // پین هدف
    public float distance = 5f; // فاصله دوربین
    public float height = 3f; // ارتفاع دوربین
    public float smoothSpeed = 0.125f; // سرعت حرکت دوربین
    private bool followPins = false; // متغیر برای پیروی از پین‌ها

    void LateUpdate()
    {
        if (followPins && targetPin != null)
        {
            Vector3 desiredPosition = targetPin.position + new Vector3(0, height, -distance);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // دوربین به سمت پین بچرخد
            transform.LookAt(targetPin);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pin")) // اگر به پین برخورد کرد
        {
            followPins = true; // دوربین به سمت پین‌ها پیروی کند
            targetPin = other.transform; // پین هدف را تنظیم کنید
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pin")) // اگر از پین خارج شد
        {
            followPins = false; // دوربین دیگر پیروی نکند
        }
    }
}

