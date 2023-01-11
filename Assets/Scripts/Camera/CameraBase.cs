using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBase : MonoBehaviour {

    public Transform target;

    void LateUpdate() {
        FollowPlayer();
    }


    void FollowPlayer() {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }
    
}
