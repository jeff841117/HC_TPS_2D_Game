
using UnityEngine;

// 繼承:可以享有類別成員
public class Pipe : Ground
{

    private void Start()
    {
        // gameObiect 指的是此類別的遊戲物件
        // 刪除(物件，延遲時間)
        // Destroy(gameObject, 5f);
    }

    // 掛此類的物件需要有元件:Mesh Renderer
    // 在攝影機畫面外的時候會執行一次
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 1f);
    }


    // 在攝影機畫面內的時候會執行一次
    private void OnBecameVisible()
    {
        
    }
}
