using UnityEngine;

public class Ball : MonoBehaviour
{
    public CameraManager cameraManager; // ارجاع به CameraManager

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pin")) // اگر به پین برخورد کرد
        {
            // می‌توانید چند ثانیه تأخیر قبل از فعال‌سازی دوربین سقوط اضافه کنید
            Invoke("ActivateFallCamera", 0.5f); // 0.5 ثانیه تأخیر
        }
    }

    void ActivateFallCamera()
    {
        cameraManager.SwitchToFallCamera(); // سوئیچ به دوربین سقوط
    }
}


