using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //管理存在的对象（不在对象池中的对象）
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
        //点击左键创建物体，右键销毁
        if (Input.GetMouseButtonDown(0))
        {
            //创建
            //从对象池取出
            GameObject go = GetComponent<PoolTest>().Pop();
            list.Add(go);
            go.SetActive(true);


        }
        if (Input.GetMouseButtonDown(1))
        {
            //删除
            //放入对象池
            if (list.Count > 0)
            {
                GetComponent<PoolTest>().Push(list[0]);
                list[0].SetActive(false);//非激活状态
                list.RemoveAt(0);

            }
        }

    }
}
