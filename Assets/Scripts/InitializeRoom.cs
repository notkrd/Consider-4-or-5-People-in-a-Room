using UnityEngine;
using System.Collections;

public class InitializeRoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SetEnvironmentVariables();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SetEnvironmentVariables()
    {
        Physics2D.gravity = new Vector2(0, 0);
    }
}
