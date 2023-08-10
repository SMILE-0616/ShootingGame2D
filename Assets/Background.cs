using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Y�������� ��ũ�� �ϰ� �ʹ�.

public class Background : MonoBehaviour
{
    public float speed = 0.1f;
    // MeshRenderer>Material>OffsetY
    Material mat; // ���� ����
    // Start is called before the first frame update
    void Start()
    {
        // �¾ �� MeshRenderer�� �����ͼ�
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        // �׾ȿ� �ִ� Material�� ����ϰ� �ʹ�.
        mat = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        // ��ư��鼭 Material �� OffsetY���� ������Ű�� �ʹ�
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
