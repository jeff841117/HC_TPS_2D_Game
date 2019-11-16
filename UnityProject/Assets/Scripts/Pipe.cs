
using UnityEngine;

// 繼承:可以享有類別成員
public class Pipe : Ground
{

    private void Start()
    {
        // gameObiect 指的是此類別的遊戲物件
        // 刪除(物件，延遲時間)
        Destroy(gameObject, 5f);
    }
}
