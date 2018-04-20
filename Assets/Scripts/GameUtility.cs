using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtility  {
    public static Transform GetChildTransform(GameObject root, string path)//对工具类的封装
    {
        Transform t = root.transform.Find(path);
        if (t!=null)    
        {
            return t;
        }
        return null;
    }

    public static T  GetChildComponent<T>(GameObject root,string path) where T:Component//获得子物体上的组件
    {
        Transform t = root.transform.Find(path);
        if (t!=null)
        {
            T tt = t.GetComponent<T>();
            return tt;
        }
        return null;
    }
}
