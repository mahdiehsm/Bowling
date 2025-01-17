using UnityEngine;

public class InstantiatePrefabs : MonoBehaviour
{
    public GameObject prefab; // به prefab خود در Inspector ارجاع دهید
    public int numberOfInstances = 10; // تعداد نمونه‌ها
    public float spacing = 2f; // فاصله بین نمونه‌ها

    void Start()
    {
        for (int i = 0; i < numberOfInstances; i++)
        {
            Vector3 position = transform.position + new Vector3(i * spacing, 0, 0);
            Quaternion rotation = Quaternion.Euler(-90, 0, 0); // تنظیم روتیشن پین‌ها
            Instantiate(prefab, position, rotation);
        }
    }
}