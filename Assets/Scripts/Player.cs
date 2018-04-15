using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputMode {
	NONE,
	TELEPORT,
	WALK
}

public class Player : MonoBehaviour {

	public static Player instance;

	public InputMode activeMode = InputMode.NONE;

	[SerializeField]
	private float playerSpeed = 3.0f;

	public GameObject floor;


	void Awake() {

		if (instance != null) {
			GameObject.Destroy (instance.gameObject);
		}

		instance = this; 
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TryWalk ();
	}

	public void TryWalk() {
		if (Input.GetMouseButton (0) && activeMode == InputMode.WALK)
        {
			Vector3 forward = Camera.main.transform.forward;
            forward.y = 0;
            this.transform.position += forward * Time.deltaTime * playerSpeed;
		}
	}
}
 