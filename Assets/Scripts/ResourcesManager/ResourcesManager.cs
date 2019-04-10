using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour {

    public static Dictionary<string, GameObject> prefabDic = new Dictionary<string, GameObject>();
    public static Dictionary<string, Sprite> spDic = new Dictionary<string, Sprite>();
    void Awake()
    {

        load(ResName.bagItem);
        loadSp(ResSprite.bagItem);
     }



    public void load(string res_name)
    {
        GameObject g = Resources.Load<GameObject>(res_name);
        prefabDic.Add(res_name,g);
    
    }
    /// <summary>
    /// 加载图片资源
    /// </summary>
    /// <param name="res_name"></param>
    public void loadSp(string res_name)
    {
        Sprite sp = Resources.Load<Sprite>(res_name);
        spDic.Add(res_name, sp);

    }


}
