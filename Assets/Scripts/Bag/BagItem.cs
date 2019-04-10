using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BagItem : ButtonBase
{

    public Text label;
    public override void Awake()
    {
        base.Awake();
        label = this.transform.Find("Count").GetComponent<Text>();


    }


    public override void OnClickBtn()
    {
        Debug.Log("点击了这个按钮");
    }
}
