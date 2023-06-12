using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject soldier;
   

   void Start()

    {

    }


    void Update()
    {
        
        // Set camera position to be behind the soldier
        Vector3 position = soldier.transform.position - soldier.transform.forward;// * 5;
        position.y = 3.3f;
        this.transform.position = position;

        // Set camera rotation to match soldier's rotation
        this.transform.rotation = soldier.transform.rotation;

        // Set camera's forward direction to be the same as soldier's forward direction
        Vector3 lookDirection = soldier.transform.position + soldier.transform.forward * 50;//was 10//75 good//50 also good
        position.z = 100;
        this.transform.LookAt(lookDirection);

    }

}