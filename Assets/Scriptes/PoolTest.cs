using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����ع�����-----��������

public class PoolTest : MonoBehaviour
{
    //����
    public List<GameObject> list = new List<GameObject>();
    //��ϷԤ����
    public GameObject GoPrefab;
    //�ص�������
    public int MaxCount = 100;
    // Start is called before the first frame update
    void Start()
    {
        //ǹ->�ӵ�   ������� ����->����  �������Ĵ�
        //����� ����  ȡ���ӵ��������ӵ���-> ���뼯�ϣ�ȡ�����٣�

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //���󱣴浽�����
    public void Push(GameObject go)
    {
        if(list.Count < MaxCount)
        {
            list.Add(go);
        }
        else
        {
            Destroy(go);
        }
    }

    //�Ӷ������ȡ��һ������
    public GameObject Pop()
    {
        //����������ж���
        if(list.Count > 0)
        {
            GameObject go = list[0];
            list.RemoveAt(0);
            return go;
        }
        //���û�о���ʵ����һ��
        return Instantiate(GoPrefab);
    }

    //�������
    public void Clear()
    {
        list.Clear();
    }
}
