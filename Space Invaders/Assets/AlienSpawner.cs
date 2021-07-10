using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    [SerializeField] GameObject alienPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Tworzenie przeciwników w kolumnach
        for(int column = -2; column < 2; column++)
        {
            for(int row = 4; row > 1; row--)
            {
                Instantiate(alienPrefab, new Vector3(column, row, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
