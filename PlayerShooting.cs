using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

	public GameObject bulletPrefab;
	public GameObject DamagePrefab;

	private GameObject linehandler;
	private Vector3 mousepos;

	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	void Start(){
	}
    
    // Update is called once per frame
    void Update() {
		cooldownTimer -= Time.deltaTime;

		if(Input.GetButton("Fire1") && cooldownTimer <= 0 ) {
			// SHOOT!

		mousepos = Input.mousePosition;
        mousepos.z = 10;

		mousepos = Camera.main.ScreenToWorldPoint(mousepos);

		Vector3 offset = transform.rotation * new Vector3(0, -1f, 0);

        linehandler = Instantiate(bulletPrefab, mousepos + offset, bulletPrefab.transform.rotation) as GameObject;

			Debug.Log ("Pew!");
			cooldownTimer = fireDelay;

			SoundManagerScript.PlaySound ("LaserPlayer");
		}
    }
}
