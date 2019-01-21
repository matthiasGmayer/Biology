using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {
    Vector2 aimedlocalScale;
    Vector2 notSelected;
    Vector2 selected;
    // Use this for initialization
    void Start () {
        aimedlocalScale = transform.localScale;
        notSelected = aimedlocalScale;
        selected = new Vector2(aimedlocalScale.x * 1.1f, aimedlocalScale.y * 1.1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Abs(transform.localScale.x - aimedlocalScale.x) > 0.01 || Mathf.Abs(transform.localScale.y - aimedlocalScale.y) > 0.01)
        {
            transform.localScale = new Vector2(transform.localScale.x + (aimedlocalScale.x - transform.localScale.x) / 10, transform.localScale.y + (aimedlocalScale.y - transform.localScale.y) / 10);
        }
        else if (!transform.localScale.Equals(aimedlocalScale))
        {
            transform.localScale = aimedlocalScale;
        }
    }
    void OnMouseEnter()
    {
        aimedlocalScale = selected;
    }
    void OnMouseExit()
    {
        aimedlocalScale = notSelected;
    }
}
