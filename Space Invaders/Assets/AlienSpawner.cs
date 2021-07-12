using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    [SerializeField] GameObject alienPrefab;
    List<GameObject> aliens = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        SpawnAliens();
    }

    public void SpawnAliens()
    {
        // Tworzenie przeciwników w kolumnach
        for (int column = -2; column < 2; column++)
        {
            for (int row = 4; row > 1; row--)
            {
                aliens.Add(Instantiate(alienPrefab, new Vector3(column, row, 0), Quaternion.identity));
            }
        }
    }

    public void DestroyAliens()
    {
        foreach(GameObject alien in aliens)
        {
            Destroy(alien);
        }
        aliens.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
