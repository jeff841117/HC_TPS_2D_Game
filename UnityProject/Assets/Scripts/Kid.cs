
using UnityEngine;

public class Kid : MonoBehaviour
{
    private string Kids = "小雞";

    [Header("跳躍高度"),Range(10,2000)]
    public float jump = 1.5f;
    [Header("是否死亡"),Tooltip("用來判斷角色是否死亡,true 死亡 ,false 還沒死亡")]
    public bool dead;

    /// <summary>
    /// 小雞跳躍的方法
    /// </summary>
    private void Jump()
    {
        
    }
    /// <summary>
    /// 小雞死亡的方法
    /// </summary>
    private void Dead()
    {

    }
}
