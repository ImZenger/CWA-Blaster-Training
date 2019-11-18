using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDestroy : MonoBehaviour
{
	void OnMouseDown() {
		Destroy(this.gameObject);
}
}
