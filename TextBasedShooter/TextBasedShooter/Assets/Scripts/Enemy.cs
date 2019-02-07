using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : Enemy_Base
{
    
    public float speed = 25f;
    //public bool isSelected = true;
    public string str = "HELLO";

    RectTransform rectTransform;
    Text enemyText;


    private void Start()
    {
        rectTransform = this.GetComponent<RectTransform>();
        enemyText = GetComponentInChildren<Text>();
        enemyText.text = str;
    }

    private void Update()
    {
        //transform.position +=(Vector3)Vector2.down*speed* Time.deltaTime;
        rectTransform.localPosition += Vector3.down * speed * Time.deltaTime;
        Debug.Log("Enemy string " + str);
    }

    public void setValues(string value)
    {
        str = value;
    }
}
