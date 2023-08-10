using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Y방향으로 스크롤 하고 싶다.

public class Background : MonoBehaviour
{
    public float speed = 0.1f;
    // MeshRenderer>Material>OffsetY
    Material mat; // 전역 변수
    // Start is called before the first frame update
    void Start()
    {
        // 태어날 때 MeshRenderer를 가져와서
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        // 그안에 있는 Material을 기억하고 싶다.
        mat = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        // 살아가면서 Material 의 OffsetY값을 증가시키고 싶다
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
