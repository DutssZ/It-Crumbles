using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] position, rotation;

    public float moveSpeedMultiplier = 1;
    
    public float sand;

    public PlayerData(ThirdPersonMovement player) {
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        rotation = new float[3];
        rotation[0] = player.transform.rotation.x;
        rotation[1] = player.transform.rotation.y;
        rotation[2] = player.transform.rotation.z;

        moveSpeedMultiplier = player.moveSpeedMultiplier ;

        sand = player.getSand();
}
}
