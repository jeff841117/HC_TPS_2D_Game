﻿
using UnityEngine;
using UnityEngine.UI; // 引用 介面 API

public class GameManager : MonoBehaviour
{
    [Header("最高分數")]
    public int tappoint;
    [Header("目前分數")]
    public int nowpoint;
    [Header("水管")]
    // GameObject 可以存放場景上的遊戲物件與專案內的預製物
    public GameObject pipe;
    [Header("遊戲結算畫面")]
    public GameObject goFinal;
    [Header("分數介面")]
    public Text textPoint;
    

    // static 不會顯示在屬性 Inspector 面板上
    public static bool ganeOver;

    // 修飾詞權限:
    // private 其他類別無法使用 
    // public  其他類別可以使用
   

    /// <summary>
    /// 最高分的判定方法
    /// </summary>
    private void TapPoint()
    {

    }
    /// <summary>
    /// 遊戲結束方法
    /// </summary>
    public void GameOver()
    {
        goFinal.SetActive(true);    //顯示結算畫面
        ganeOver = true;            //遊戲結束 = 是
        CancelInvoke("SpawnPipe");  //停止 InvokeRepeati

    }
    /// <summary>
    /// 加分方式
    /// </summary>
    public void GetPoint()
    {
        
        print("加分");
        nowpoint++;
        textPoint.text = nowpoint.ToString();
    }
    /// <summary>
    /// 生成水管方式
    /// </summary>
    private void SpawnPipe()
    {
        print("生水管");
        // 生成(物件);
        // Instantiate(pipe);

        // 生成(物件，座標，角度)
        float y = Random.Range(-1f, 1.2f);
        // 區域欄位(不需要修飾詞)
        Vector3 pos = new Vector3(5, 0, 0);

        // Quaternion.identity 代表零角度
        Instantiate(pipe, pos, Quaternion.identity);

       
    }

    private void Start()
    {
        // 重複調用("方法名稱"，開始時間，間隔時間)
        InvokeRepeating("SpawnPipe", 0, 1.5f);
    }
}
