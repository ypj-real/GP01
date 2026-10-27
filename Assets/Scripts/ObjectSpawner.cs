using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject CratePrefab;
    public GameObject CapsulePrefab;
    public GameObject CylinderPrefab;
    public GameObject SpherePrefab;
    public Transform SpawnPoint0;
    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    public Transform SpawnPoint3;

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

        if(Input.GetKeyDown(KeyCode.C)) 
        {
            SpawnCapsule();
        }

        if(Input.GetKeyDown(KeyCode.X)) 
        {
            SpawnCylinder();
        }

        if(Input.GetKeyDown(KeyCode.V)) 
        {
            SpawnSphere();
        }
    }

    void SpawnCrate () 
    {
        GameObject newCrate = Instantiate(CratePrefab, SpawnPoint0.position, SpawnPoint0.rotation);

        Destroy(newCrate, 5f);
    }

    void SpawnCapsule () 
    {
        GameObject newCapsule = Instantiate(CapsulePrefab, SpawnPoint1.position, SpawnPoint1.rotation);

        Destroy(newCapsule, 5f);
    }

    void SpawnCylinder () 
    {
        GameObject newCylinder = Instantiate(CylinderPrefab, SpawnPoint2.position, SpawnPoint2.rotation);

        Destroy(newCylinder, 5f);
    }

    void SpawnSphere () 
    {
        GameObject newSphere = Instantiate(SpherePrefab, SpawnPoint3.position, SpawnPoint3.rotation);

        Destroy(newSphere, 5f);
    }
}
