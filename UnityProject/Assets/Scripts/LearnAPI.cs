
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform tA;
    public Transform tB;

    public Camera cam;

    public AudioSource aud;

    private void Start()
    {
        // 使用靜態(static)成員 - 屬性
        print("隨機:" + Random.value);

        // 使用 數學類別.PI (Mathf) - 屬性
        print("圓周率:" + Mathf.PI);

        // 使用靜態成員 - 方法
        print("隨機範圍:" + Random.Range(1, 100));

        print("絕對值:" + Mathf.Abs(-99));

        // 非靜態成員 - 屬性
        // 需要先給予欄位存放實體物件
        print("物件A 的座標" + tA.position);

        tB.position = new Vector3(-2, 0, 0);

        cam.depth = 10;
        print("攝影機深度:" + cam.depth);

        aud.Stop();
    }

    private void Update()
    {
        // 非靜態成員 - 方法
        transform.Rotate(10,0,0);
    }
}
