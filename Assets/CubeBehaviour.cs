using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    public List<string> Status = new List<string>();

    private Rigidbody thisRigibody;

    private Vector3 direction = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        thisRigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = 1;
        // direction.y = 1;
        direction.z = 1;

        thisRigibody.AddForce(direction * 10);
    }

    private void nearestNeighbour() {
        
    }

    private void OnTriggerEnter(Collider other) {
        
    }
}
