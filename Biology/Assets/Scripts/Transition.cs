using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour {
    public GameObject gotoObject;
    public int dir;
    GameObject background;
    Vector2 positionDif;
    Vector2 positionDif2;
    Vector2 positionDif3;
    Vector2 zeroVector;
    Move move;
    Move gotomove;
    Move backmove;

    // Use this for initialization
    void Start () {
        background = GameObject.Find("Background");
        move = this.gameObject.transform.parent.gameObject.GetComponent<Move>();
        gotomove = gotoObject.GetComponent<Move>();
        backmove = background.GetComponent<Move>();
        switch (dir) {
            case 0: positionDif = new Vector2(0, 11);
                break;
            case 1: positionDif = new Vector2(22, 0);
                break;
            case 2:
                positionDif = new Vector2(0, -11);
                break;
            case 3:
                positionDif = new Vector2(-22, 0);
                break;

        }
        positionDif2 = new Vector2(positionDif.x * -1, positionDif.y * -1);
        positionDif3 = new Vector2(positionDif.x * 0.9f, positionDif.y * 0.9f);
        zeroVector = new Vector2(0, 0);

    }

    void OnMouseDown()
    {
        move.MoveTo(zeroVector, positionDif2);
        gotomove.MoveTo(positionDif, zeroVector);
        backmove.MoveTo(positionDif3, zeroVector);
    }
}