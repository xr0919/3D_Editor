using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //������ڵĶ��󣨲��ڶ�����еĶ���
    private List<GameObject> list = new List<GameObject>();

    private PoolTest poolTest;
    // Start is called before the first frame update
    void Start()
    {
        //poolTest = GameObject.Find("CreAndDel").GetComponent<PoolTest>();
    }

    // Update is called once per frame
    void Update()
    {
        //�������������壬�Ҽ�����
        if (Input.GetMouseButtonDown(0))
        {
            //����
            //�Ӷ����ȡ��
            GameObject go = GetComponent<PoolTest>().Pop();
            list.Add(go);
            go.SetActive(true);


        }
        if (Input.GetMouseButtonDown(1))
        {
            //ɾ��
            //��������
            if (list.Count > 0)
            {
                GetComponent<PoolTest>().Push(list[0]);
                list[0].SetActive(false);//�Ǽ���״̬
                list.RemoveAt(0);

            }
        }

    }
}
