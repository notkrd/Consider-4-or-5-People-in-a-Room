using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotions : MonoBehaviour {
    public float panning_speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveWithWASDKeys();
	}

    void ShiftInDir(Vector2 dir)
    {
        gameObject.transform.Translate(dir * panning_speed);
    }

    void MoveWithWASDKeys()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            ShiftInDir(new Vector2(1, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ShiftInDir(new Vector2(-1, 0));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ShiftInDir(new Vector2(0, 1));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ShiftInDir(new Vector2(0, -1));
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameObject.transform.position = new Vector3(0, 0, -10);
        }
    }
}
