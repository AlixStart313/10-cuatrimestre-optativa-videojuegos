using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killZone : MonoBehaviour

{
    public GameObject spawn;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position=spawn.transform.position;
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Debug.Log("Entro el jugador, se pasara al spawn");
        }
    }
}
