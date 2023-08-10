using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �¾ �� 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��������� ���ϰ�
// ��ư��鼭 �� �������� ��� �̵��ϰ� �ʹ�


public class Enemy : MonoBehaviour
{
    // - ����
    Vector3 dir;
    // - �ӷ�
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        // �¾ ��
        // 1. 30% Ȯ���� �÷��̾� ����, ������ Ȯ���� �Ʒ��������� ���ϰ�
        int result = UnityEngine.Random.Range(0, 10);

        if (result < 3)
        {
            // �÷��̾� ����
            GameObject target = GameObject.Find("Player");
            // dir = target - me (����)
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            // �Ʒ� ����
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
        // 1. �ð�ȿ�����忡�� �ð�ȿ���� ����
        GameObject explosion = Instantiate(explosionFactory);
        // 2. �� ��ġ�� ������ ���� �ʹ�.
        explosion.transform.position = transform.position;

        // enemy�� �װ�
        Destroy(other.gameObject);
        // player�� ����
        Destroy(gameObject);
    }
}