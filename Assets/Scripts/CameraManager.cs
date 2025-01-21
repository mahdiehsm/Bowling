using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera followCamera; // دوربین دنبال‌کننده
    public Camera fallCamera; // دوربین سقوط

    void Start()
    {
        followCamera.gameObject.SetActive(true); // دوربین دنبال‌کننده فعال است
        fallCamera.gameObject.SetActive(false); // دوربین سقوط غیرفعال است
    }

    public void SwitchToFallCamera()
    {
        followCamera.gameObject.SetActive(false); // دوربین دنبال‌کننده غیرفعال شود
        fallCamera.gameObject.SetActive(true); // دوربین سقوط فعال شود
    }
}
