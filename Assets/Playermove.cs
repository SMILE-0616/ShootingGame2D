using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력에 따라 플레이어를 이동하고 싶다
public class Playermove : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 사용자의 입력에 따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //print(h); // A : -1, 0, 1
        // 2. 플레이어를 이동하고 싶다.
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // right : [0,0,0] [1,0,0] [-1,0,0]
        // up : [0,0,0] [0,1,0] [0,-1,0]
        // 문제발생!
        // 대각선 이동 시 움직임의 크기가 더 크다
        // 백터를 정규화 해야한다!
        dir.Normalize();
        // 3. 그 방향으로 플레이어를 이동하고 싶다

        // 이동공식 P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
