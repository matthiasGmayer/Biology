using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    Vector2 aimedPosition;
    bool move;
    Vector2 movement;
	// Use this for initialization
	void Start () {
        aimedPosition = transform.position;
        movement = new Vector2(0, 0);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if ((Mathf.Abs(transform.position.x - aimedPosition.x) > 0.01))
        {
            movement = new Vector2((aimedPosition.x - transform.position.x) / 15, movement.y);
            if (Mathf.Abs(movement.x) > 0.5) movement = new Vector2(0.5f * Mathf.Sign(movement.x), movement.y);
            if (Mathf.Abs(movement.x) < 0.01) movement = new Vector2(0.01f * Mathf.Sign(movement.x), movement.y);
            transform.position = new Vector2(transform.position.x + movement.x, transform.position.y);

        }
        else
            transform.position = new Vector2(aimedPosition.x, transform.position.y);
        if (Mathf.Abs(transform.position.y - aimedPosition.y) > 0.01)
        {
            movement = new Vector2((aimedPosition.x - transform.position.x) / 15, (aimedPosition.y - transform.position.y) / 15);
            if (Mathf.Abs(movement.y) > 0.5) movement = new Vector2(movement.x, 0.5f * Mathf.Sign(movement.y));
            if (Mathf.Abs(movement.y) < 0.01) movement = new Vector2(movement.x, 0.01f * Mathf.Sign(movement.y));
            transform.position = new Vector2(transform.position.x, transform.position.y + movement.y);

        }
        else
            transform.position = new Vector2(transform.position.x, aimedPosition.y);
    }
    public void MoveTo(Vector2 start, Vector2 end) {
        transform.position = start;
        aimedPosition = end;
    }
}
