using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {
    public int a_lifetime;

	// Use this for initialization
	void Start () {
        StartCoroutine(DestroyMeSoon());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator DestroyMeSoon()
    {
        yield return new WaitForSeconds(a_lifetime);
        Destroy(gameObject);
    }
}