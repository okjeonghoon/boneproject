using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveinput : MonoBehaviour
{
    // 이 아래에 작성한 코드는 데이터에 해당하는 영역입니다
    public float moveSpeed = 5f;
    public Rigidbody2D rigid;

    //
    void Update()
    {
        //update의 영역 안에 코드를 작성하면 게임이 실행하는 도중에 이 코드가 작동 됩니다.
        float h = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2(h * moveSpeed, 0);
    }
}
