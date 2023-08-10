using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 태어날 때 30% 확률로 플레이어 방향, 나머지 확률로 아래방향으로 정하고
// 살아가면서 그 방향으로 계속 이동하고 싶다


public class Enemy : MonoBehaviour
{
    // - 방향
    Vector3 dir;
    // - 속력
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        // 태어날 때
        // 1. 30% 확률로 플레이어 방향, 나머지 확률로 아래방향으로 정하고
        int result = UnityEngine.Random.Range(0, 10);

        if (result < 3)
        {
            // 플레이어 방향
            GameObject target = GameObject.Find("Player");
            // dir = target - me (질문)
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            // 아래 방향
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    public GameObject explosionFactory;

    private void OnCollisionStay(Collision other)
    {
        // 1. 시각효과공장에서 시각효과를 만들어서
        GameObject explosion = Instantiate(explosionFactory);
        // 2. 내 위치에 가져다 놓고 싶다.
        explosion.transform.position = transform.position;

        // enemy도 죽고
        Destroy(other.gameObject);
        // player도 죽자
        Destroy(gameObject);
    }
}