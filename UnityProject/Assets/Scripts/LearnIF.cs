
using UnityEngine;

public class LearnIF : MonoBehaviour
{
    private bool test;
    private string prop;
    private float hp=100;
   // 更新事件:一秒執行60次
   private void Update()
   {
        
        // 判斷式 if 語法
        // if (布林值) {陳述式或演算法}
        // () 裡面的布林值為 ture 才會執行 {}
        if (test)
        {
            print("打開開關");
        }
        // () 裡面的布林值為 false 才會執行 else {}
        else
        {
            print("關閉開關");
        }
        if (prop == "紅色藥水")
        {
            print("補血");
        }
        else if (prop == "藍色藥水")
        {
            print("補魔力");
        }
        else if (prop == "黃色藥水")
        {
            print("補體力");
        }
        else
        {
            print("沒發生任何事");
        }

        if(hp >= 70)
        {
            print("安全");
        }
        else if(hp >= 50)
        {
            print("警告                                                                               ");
        }
        else if(hp >= 20)
        {
            print("危險");
        }
        else
        {
            print("快死了");
        }
   }
}
