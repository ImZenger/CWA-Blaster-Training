using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleDroidSpawner4 : MonoBehaviour
{
    public GameObject droidPrefab;
    private Vector2 screenBounds;

	public float maxTime = 5;
    public float minTime = 2;

	private float time;

	private float spawnTime;

    // Use this for initialization
    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

		SetRandomTime();
         time = minTime;
    }

	 void FixedUpdate(){
 
         //Counts up
         time += Time.deltaTime;
 
         //Check if its the right time to spawn the object
         if(time >= spawnTime){
             SpawnObject();
             SetRandomTime();
         }
 
     }
    private void SpawnObject(){
		 time = 0;
        GameObject a = Instantiate(droidPrefab) as GameObject;
        a.transform.position = new Vector3(screenBounds.x * -2, 0.5f, 2);
    }


	void SetRandomTime(){
         spawnTime = Random.Range(minTime, maxTime);
     }
}
