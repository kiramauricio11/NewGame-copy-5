using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placement : MonoBehaviour
{

    public GameObject Building;

    public GameObject redBuidling;

    public GameObject road;

    public GameObject tree;

    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Building, new Vector3(16, 4, -18), Quaternion.Euler(0,-180,0));//Euler to make it face correctly
        Instantiate(Building, new Vector3(-18, 4, 5), Quaternion.identity);//Already facing correctly no change 
        Instantiate(Building, new Vector3(-18, 4, -6), Quaternion.identity);

        Instantiate(redBuidling, new Vector3(15, 2, -8), Quaternion.Euler(0,-180,0));
        Instantiate(redBuidling, new Vector3(-18, 2, 18), Quaternion.identity);
        Instantiate(redBuidling, new Vector3(-18, 2, -16), Quaternion.identity);
        
        Instantiate(road, new Vector3(7, 0, 10), Quaternion.Euler(0, 90, 0));
        Instantiate(road, new Vector3(7, 0, 0), Quaternion.Euler(0, 90, 0));
        Instantiate(road, new Vector3(7, 0, -10), Quaternion.Euler(0, 90, 0));
        Instantiate(road, new Vector3(7, 0, -20), Quaternion.Euler(0, 90, 0));
        Instantiate(road, new Vector3(-9, 0, 20), Quaternion.Euler(0, 90, 0));
        Instantiate(road, new Vector3(-9, 0, 10), Quaternion.Euler(0, 90, 0));
        Instantiate(road, new Vector3(-9, 0, 0), Quaternion.Euler(0, 90, 0));
        Instantiate(road, new Vector3(-9, 0, -10), Quaternion.Euler(0, 90, 0));
        Instantiate(road, new Vector3(-9, 0, -20), Quaternion.Euler(0, 90, 0));

        Instantiate(tree, new Vector3(14, 1.5f, 10), Quaternion.identity);
        Instantiate(tree, new Vector3(14, 1.5f, -4), Quaternion.identity);
        Instantiate(tree, new Vector3(14, 1.5f, -14), Quaternion.identity);
        Instantiate(tree, new Vector3(-16, 1.5f, -14), Quaternion.identity);
        Instantiate(tree, new Vector3(-16, 1.5f, -4), Quaternion.identity);
        Instantiate(tree, new Vector3(-16, 1.5f, 10), Quaternion.identity);
        Instantiate(tree, new Vector3(-16, 1.5f, 18), Quaternion.identity);

        Instantiate(wall, new Vector3(0, 0, -25), Quaternion.Euler(90, 0, 0));
        Instantiate(wall, new Vector3(-25, 0, 0), Quaternion.Euler(-90, 0, -90));
        Instantiate(wall, new Vector3(25, 0, 0), Quaternion.Euler(-90, 0, 90));




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
