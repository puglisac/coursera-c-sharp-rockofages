using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear spawner
/// </summary>
public class RockSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField]
    GameObject prefabRock;
    [SerializeField]
    Sprite greenrock;
    [SerializeField]
    Sprite magentarock;
    [SerializeField]
    Sprite whiterock;

    // spawn control

    Timer spawnTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {


        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // check for time to spawn a new teddy bear
        if (spawnTimer.Finished)
        {
            if (GameObject.FindGameObjectsWithTag("rock").Length < 3)
            {
                SpawnRock();

                // change spawn timer duration and restart
                spawnTimer.Duration = 1;
                spawnTimer.Run();
            }
        }
    }

    /// <summary>
    /// Spawns a new teddy bear at a random location
    /// </summary>
    void SpawnRock()
    {
        // generate random location and create new teddy bear
        Vector3 location = Camera.main.transform.position;
        GameObject rock = Instantiate(prefabRock) as GameObject;
        rock.GetComponent<SpriteRenderer>().sprite = generateRandomSprite();
        rock.transform.position = location;
    }

    Sprite generateRandomSprite()
    {
        int randomInt = Random.Range(1, 4);
        if (randomInt == 1)
        {
            return greenrock;
        }
        else if (randomInt == 2)
        {
            return magentarock;
        }
        else
        {
            return whiterock;
        }
    }
}

