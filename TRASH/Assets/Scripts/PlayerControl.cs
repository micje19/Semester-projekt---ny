using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {

    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
   
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Vector2 pos = transform.position;
            // Instantiate at player specific position and zero rotation.
            GameObject SandTile;
            SandTile = Instantiate(myPrefab, pos + new Vector2(-2.86f, 5.18f), Quaternion.identity);
            // Move our position a step closer to the target.
            float step = 750f * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, SandTile.transform.position, step);
            Debug.Log("Object was spawned, left of player position");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Vector2 pos = transform.position;
            // Instantiate at player specific position and zero rotation.
            GameObject SandTile;
            SandTile = Instantiate(myPrefab, pos + new Vector2(2.86f, 5.18f), Quaternion.identity);
            // Move our position a step closer to the target.
            float step = 750f * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, SandTile.transform.position, step);
            Debug.Log("Object was spawned, right of player position");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Plastic") == true)
        {
            Debug.Log("You picked up some trash");
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag.Equals("Stone") == true)
        {
            Debug.Log("You died!");
            SceneManager.LoadScene("SampleScene");
        }
        if(collision.gameObject.tag.Equals("Tsunami") == true)
        {
            Debug.Log("You were to slow");
            SceneManager.LoadScene("SampleScene");
        }
        if(collision.gameObject.tag.Equals("Wall") == true)
        {
            Debug.Log("You hit the border");
            SceneManager.LoadScene("SampleScene");
            //dum
        }
    }
}
