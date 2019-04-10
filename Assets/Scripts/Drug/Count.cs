using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {

    public int count;
    public int id;
    public string countname;
	// Use this for initialization
	void Start () {

        this.GetComponent<Text>().text = count.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
