using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿� ���� �÷��̾ �̵��ϰ� �ʹ�
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
        // 1. ������� �Է¿� ����
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //print(h); // A : -1, 0, 1
        // 2. �÷��̾ �̵��ϰ� �ʹ�.
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // right : [0,0,0] [1,0,0] [-1,0,0]
        // up : [0,0,0] [0,1,0] [0,-1,0]
        // �����߻�!
        // �밢�� �̵� �� �������� ũ�Ⱑ �� ũ��
        // ���͸� ����ȭ �ؾ��Ѵ�!
        dir.Normalize();
        // 3. �� �������� �÷��̾ �̵��ϰ� �ʹ�

        // �̵����� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
