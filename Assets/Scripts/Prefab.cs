using UnityEngine;

public class InstantiatePrefabs : MonoBehaviour
{
    public GameObject prefab; // در این قسمت prefab خود را از Inspector drag & drop کنید.
    public float spacing = 2f; // فاصله بین پین‌ها

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            // موقعیت هر پین را بر اساس فاصله تعیین می‌کنیم.
            Vector3 position = transform.position + new Vector3(i * spacing, 0, 0);
            // نمونه prefab را ایجاد می‌کنیم.
            GameObject instance = Instantiate(prefab, position, Quaternion.identity);
            // می‌توانید در اینجا تنظیمات اضافی برای هر نمونه انجام دهید.
            // مثلاً: instance.name = "Pin " + i;
        }
    }
}