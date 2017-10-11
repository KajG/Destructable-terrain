using UnityEngine;
using System.Collections;
public class SpawnerController : MonoBehaviour {

	public GameObject oilDrumPrefab;

	void Start () {
		for( int i = 0; i < 5; i++ ){
			float posX = Random.Range(-10f, 10f);
			GameObject oilDrum = Instantiate(oilDrumPrefab);
			oilDrum.transform.position = new Vector3( posX, transform.position.y, 0f );
		}
	}
}
