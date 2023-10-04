using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//对象池管理器-----性能提升

public class PoolTest : MonoBehaviour
{
    //集合
    public List<GameObject> list = new List<GameObject>();
    //游戏预设体
    public GameObject GoPrefab;
    //池的最大个数
    public int MaxCount = 100;
    // Start is called before the first frame update
    void Start()
    {
        //枪->子弹   多个物体 创建->销毁  性能消耗大
        //对象池 集合  取出子弹（创建子弹）-> 加入集合（取代销毁）

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //对象保存到对象池
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

    //从对象池中取出一个对象
    public GameObject Pop()
    {
        //如果池子里有对象
        if(list.Count > 0)
        {
            GameObject go = list[0];
            list.RemoveAt(0);
            return go;
        }
        //如果没有就新实例化一个
        return Instantiate(GoPrefab);
    }

    //清除池子
    public void Clear()
    {
        list.Clear();
    }
}
