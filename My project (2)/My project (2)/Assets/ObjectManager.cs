using UnityEngine;
using System.Collections.Generic;

public class ObjectManager : MonoBehaviour
{
    public GameObject fuelPrefab;
    public Vector3 fuelPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        GameObject obj = Instantiate(fuelPrefab, new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), fuelPrefab.transform.position.z), Quaternion.identity);
        fuelPos = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
