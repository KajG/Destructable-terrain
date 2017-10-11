using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	private Rigidbody2D rb; 
	public Transform bulletSpriteTransform; 
	private bool updateAngle = true; 
	public GameObject bulletSmoke;
	public CircleCollider2D destructionCircle;
	public static GroundController groundController;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	void Update () {
		if( updateAngle ){
			Vector2 dir = new Vector2(rb.velocity.x, rb.velocity.y);
            dir.Normalize();			
			float angle = Mathf.Asin (dir.y)*Mathf.Rad2Deg;
			if( dir.x < 0f ){
				angle = 180 - angle;
			}
			bulletSpriteTransform.localEulerAngles = new Vector3(0f, 0f, angle+45f);
		}
	}
	void OnCollisionEnter2D( Collision2D coll ){
		if( coll.collider.tag == "Ground" ){
			updateAngle = false;
			bulletSmoke.SetActive(false);
			groundController.DestroyGround( destructionCircle );
			Destroy(gameObject);
		}
	}
}
