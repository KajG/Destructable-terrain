using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSprite : MonoBehaviour {
	public Sprite sprite;

	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	void Update () {
		
	}
}
