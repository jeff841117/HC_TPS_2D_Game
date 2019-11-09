using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b = 3 ,c = 10, d = 10;
    public int score = 50;
    public int num1 = 90, num2 = 10;
    public bool boola = true, boolb = false;
    public int hp = 100;
    public int prop = 10;

    private void Start()
    {
        // 數學運算子
        print(a + b);  // 加 13
        print(a - b);  // 減 7
        print(a * b);  // 乘 30
        print(a / b);  // 除 3
        print(a % b);  // 餘 10 / 3 =3...1

        //遞增 ++ 、 遞減 --
        print(c++);     // 先輸出再執行遞增
        print(++d);     // 先執行遞增再輸出

        //指定運算:等號右邊會先運算再傳給左邊
        // = 指定
        // 適用所有數學運算
        score = score + 10;
        score += 10;

        // 比較運算子 (結果為布林值)
        print(num1 > num2);
        print(num1 < num2);
        print(num1 >= num2);
        print(num1 <= num2);
        print(num1 == num2);   // 等於
        print(num1 != num2);   // 不等

        // 邏輯運算子
        // 並且 &&
        print(boola && boolb); //只要有一個false 結果為false
        print(true && true);   // 結果為true
        print(true && false);  // 結果為false
        print(false && true);  // 結果為false
        print(false && false); // 結果為false
        // 或者 ||
        print(boola || boolb);
        print(true || true);   // 結果為true
        print(true || false);
        print(false || true);
        print(false || false);

    }
}
