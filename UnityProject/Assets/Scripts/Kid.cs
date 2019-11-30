﻿
using UnityEngine;

public class Kid : MonoBehaviour
{
    private string Kids = "小雞";

    [Header("跳躍高度"),Range(50,2000)]
    public float jump = 100f;
    [Header("旋轉角度"), Range(0, 100)]
    public float angle = 10;
    [Header("是否死亡"),Tooltip("用來判斷角色是否死亡,true 死亡 ,false 還沒死亡")]
    public bool dead;
    [Header("剛體")]
    public Rigidbody2D r2d;
    [Header("遊戲管理器")]
    public GameManager gm;

    public GameObject goScore, goGM;
    // AudioSource 存放喇叭元件
    // AudioClip   存放音效檔案
    public AudioSource aud;
    public AudioClip soundJump, soundHit, soundPoint;

    /// <summary>
    /// 小雞跳躍的方法
    /// </summary>
    private void Jump()
    {
        // 原本寫法
        //if (dead == true)
        //{
        //    return;
        //}


        // 如果 死亡 套出此程式區塊
        // 判斷式只有一行敘述可以省略大括號
        if (dead) return; //簡寫


        // 如果 玩家 按下 左鍵
        // 輸入.按下按鍵(按鍵列舉.滑鼠左鍵) (手機觸控)
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            // 小雞 往上跳
            print("玩家按下左鍵");
            aud.PlayOneShot(soundJump, 1f);    // 喇叭.播放一次音效(音效,音量);
            r2d.Sleep();                         // 小雞剛體.重置();
            r2d.gravityScale = 1;                // 小雞剛體.重力 = 1;
            r2d.AddForce(new Vector2(0, jump));  // 小雞剛體.增加推力(二維向量(左右，上下));
            goScore.SetActive(true);             // 分數 顯示
            goGM.SetActive(true);                // GM 顯示
        }
        // Rigidbody2D.SetRotation(float) 設定角度(角度)
        // Rigidbody2D.velocity 加速度 (二維向量 x ,y)
        r2d.SetRotation(angle * r2d.velocity.y);
    }
    /// <summary>
    /// 小雞死亡的方法
    /// </summary>
    private void Dead()
    {
        aud.PlayOneShot(soundHit, 1.5f);    // 喇叭.播放一次音效(音效,音量);
        print("死亡");
        dead = true;
        gm.GameOver();
    }

    private void Update()
    {
        Jump();
    }

    // 固定幀數 0.002 一幀:要控制物理請寫在此事件內
    private void FixedUpdate()
    {
        
    }
    // 事件:碰撞開始 - 碰撞開始執行一次(Collision2D hit) (碰撞類別 名稱) 存放碰到物件的資訊
    private void OnCollisionEnter2D(Collision2D hit)
    {
        // 碰撞物件.遊戲物件.名稱
        print(hit.gameObject.name);

        if(hit.gameObject.name == "地板")
        {
            Dead();
        }
    }
    
    // 事件:觸發開始 - 物件必須勾選 IsTrigger
    private void OnTriggerEnter2D(Collider2D hit)
    {
        // 如果 碰到.物件名稱 為 上 或者 下 - 死亡
        if(hit.name == "水管(上)"||hit.name == "水管(下)")
        {
            Dead();
        }
    }

    private void OnTriggerExit2D(Collider2D hit)
    {
        // 如果碰到加分區域 並且 死亡 bool值  false
        if(hit.name == "加分" && !dead)
        {
            gm.GetPoint();
            aud.PlayOneShot(soundPoint, 1f);    // 喇叭.播放一次音效(音效,音量);
        }
    }
}
