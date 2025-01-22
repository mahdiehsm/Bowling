using UnityEngine;

public class Ball : MonoBehaviour
{
    public CameraManager cameraManager; // ارجاع به CameraManager
    public float moveSpeed = 10f; // سرعت حرکت توپ

    void Update()
    {
        MoveBall();
    }

    void MoveBall()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pin")) // اگر به پین برخورد کرد
        {
            Debug.Log("Ball hit the pin!"); // پیغام برای اشکال‌زدایی
            Invoke("ActivateFallCamera", 0.3f); // 0.5 ثانیه تأخیر
        }
    }

    void ActivateFallCamera()
    {
        cameraManager.SwitchToFallCamera(); // سوئیچ به دوربین سقوط
    }
}






