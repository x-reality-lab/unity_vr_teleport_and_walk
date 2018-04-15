﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : GazeableObject {

	public override void OnPress(RaycastHit hitInfo) {
		base.OnPress(hitInfo);

		if (Player.instance.activeMode == InputMode.TELEPORT) {
			Vector3 destLocation = hitInfo.point;

			destLocation.y = Player.instance.transform.position.y;
			Player.instance.transform.position = destLocation;
		}
	}
}
