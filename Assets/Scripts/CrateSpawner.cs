using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject CratePrefab;
    public Transform SpawnPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            SpawnCrate();
        }
    }

    void SpawnCrate () 
    {
        GameObject newCrate = Instantiate(CratePrefab, SpawnPoint.position, SpawnPoint.rotation);

        Destroy(newCrate, 5f);
    }
}
