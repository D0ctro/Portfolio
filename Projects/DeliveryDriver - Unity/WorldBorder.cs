using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldBorder : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject SpawnPoint;
    
    private Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = SpawnPoint.transform.position + new Vector3 (0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D other) {
        Player.transform.position = respawnPoint;
    }
}
