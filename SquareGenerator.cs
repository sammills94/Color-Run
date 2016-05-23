using UnityEngine;
using System.Collections;

public class SquareGenerator : MonoBehaviour {
	public ObjectPooler squarePool;
	public float distanceBetweenSquares;


public void SpawnSquares(Vector3 startPosition){
		GameObject square1 = squarePool.GetPooledObject ();
		square1.transform.position = startPosition;
		square1.SetActive (true);

		GameObject square2 = squarePool.GetPooledObject ();
		square2.transform.position = new Vector3 (startPosition.x - distanceBetweenSquares, startPosition.y, startPosition.z);
		square2.SetActive (true);

		GameObject square3 = squarePool.GetPooledObject ();
		square3.transform.position = new Vector3 (startPosition.x + distanceBetweenSquares, startPosition.y, startPosition.z);
		square3.SetActive (true);
	}
}
