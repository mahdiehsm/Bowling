using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // سرعت حرکت توپ

    void Update()
    {
        // حرکت با کیبورد
        float moveHorizontal = Input.GetAxis("Horizontal"); // چپ و راست
        Vector3 movement = new Vector3(moveHorizontal, 0, 0);
        transform.position += movement * moveSpeed * Time.deltaTime;

        // حرکت با تاچ گوشی
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                // حرکت توپ بر اساس موقعیت لمسی
                float touchMovement = touch.deltaPosition.x * Time.deltaTime;
                transform.position += new Vector3(touchMovement, 0, 0) * moveSpeed;
            }
        }
    }
}


