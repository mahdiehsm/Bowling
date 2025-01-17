using UnityEngine;

public class PinSetup : MonoBehaviour
{
    public GameObject pinPrefab; // prefab پین
    public int numberOfPins = 10; // تعداد پین‌ها
    public float spacing = 2f; // فاصله بین پین‌ها
    public float height = 1f; // ارتفاع ایستادن پین‌ها

    void Start()
    {
        for (int i = 0; i < numberOfPins; i++)
        {
            Vector3 position = new Vector3(i * spacing, height, 0); // تنظیم موقعیت
            GameObject pin = Instantiate(pinPrefab, position, Quaternion.Euler(-90, 0, 0)); // ایجاد پین با روتیشن مناسب
        }
    }
}


