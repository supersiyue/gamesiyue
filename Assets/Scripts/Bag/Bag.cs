using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour {



    /// <summary>
    /// 生成背包框
    /// </summary>
    /// <param name="i">第几行</param>
    /// <param name="j">第几列</param>
    /// 



    public Dictionary<string, ItemBase> dic = new Dictionary<string, ItemBase>();
    public GameObject insBagItem(int i,int j,Vector3 pos,Sprite sp)
    {
        
       GameObject g =  GameObject.Instantiate(ResourcesManager.prefabDic[ResName.bagItem],this.transform);
       Image img = g.GetComponent<Image>();
       img.sprite = sp;
      
       g.GetComponent<RectTransform>().localPosition = pos;
    
      
       return g;
    
    

    }
    public void addItem(ItemBase item)
    {

           
    }

    public void insAndSetPos(int i, int j, Vector3 pos)
    {
       // GameObject g = insBagItem(i, j);
        
        //g.GetComponent<RectTransform>().localPosition = pos;
        
    }

    void Start()
    {
        //insBagItem(1, 1);
        for (int m = 1; m <= 8; m++)
            for (int n = 1; n <= 4; n++)
            {
                Vector3 vector =new Vector3(m * 100, n * 100, 1);
                GameObject game=insBagItem(m,n,vector, ResourcesManager.spDic[ResSprite.bagItem]);
                //game.AddComponent<LittleRed>();

            
            }
    }

}
