using UnityEngine;
using System.Collections;

public class HumanMotion : MonoBehaviour {
    public float energeticness;
    public Rigidbody2D my_body;
    public bool reader_controlled;

	// Use this for initialization
	void Start () {
        my_body = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (reader_controlled)
        {
            MoveWithArrowKeys();
        }
    }

    void MoveInDir (Vector2 dir)
    {
        my_body.AddForce(dir * energeticness);
    }

    void MoveWithArrowKeys()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveInDir(new Vector2(1, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveInDir(new Vector2(-1, 0));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveInDir(new Vector2(0, 1));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveInDir(new Vector2(0, -1));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            my_body.velocity = new Vector2(0, 0);
        }
    }
}
