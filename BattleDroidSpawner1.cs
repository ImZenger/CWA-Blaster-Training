using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleDroidSpawner1 : MonoBehaviour
{
    public GameObject droidPrefab, droidPrefab2;
    private Vector2 screenBounds;

	public float maxTime = 5;
    public float minTime = 2;

	private float time;

	private float spawnTime;

	int whatToSpawn;

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
            
			whatToSpawn = Random.Range (1,3);

			switch (whatToSpawn) {
            case 1: 
					SpawnObject();
					break;
			case 2:
					SpawnObject1();
					break; }
             SetRandomTime();
         }
 
     }
    private void SpawnObject(){
		 time = 0;
        GameObject a = Instantiate(droidPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, -1.914f);
    }

	private void SpawnObject1(){
		 time = 0;
        GameObject a = Instantiate(droidPrefab2) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, -1.914f);
    }


	void SetRandomTime(){
         spawnTime = Random.Range(minTime, maxTime);
     }
}
