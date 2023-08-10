using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ð����� �����忡�� ���� ���� �� ��ġ�� ������ ���� �ʹ�.
public class EnemyManager : MonoBehaviour
{
    // - �� ����
    public GameObject enemyFactory;
    // - ���� �ð�
    float currentTime;
    // - ���� �ð�
    public float createTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;
        // 2. ����ð��� �����ð��� �Ǹ�
        if (currentTime > createTime)
        // 3. �����忡�� ���� ����
        {
            GameObject enemy = Instantiate(enemyFactory);
            // 4. �� ��ġ�� ������ ���� �ʹ�
            enemy.transform.position = transform.position;
            // 5. ����ð��� 0���� �ʱ�ȭ �ϰ� �ʹ�
            currentTime = 0;
        }
    }
}