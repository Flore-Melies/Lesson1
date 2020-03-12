using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField] private GameObject toSpawn;

    private Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var minPos = mainCam.ScreenToWorldPoint(Vector3.zero);
            var maxScreenPos = new Vector3(
                mainCam.pixelWidth,
                mainCam.pixelHeight,
                0
                );
            var maxPos = mainCam.ScreenToWorldPoint(maxScreenPos);
            var position = new Vector3(
                Random.Range(minPos.x, maxPos.x),
                Random.Range(minPos.y, maxPos.y),
                0);
            Instantiate(toSpawn, position, Quaternion.identity);
        }
    }
}
