using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCubeBehaviour : MonoBehaviour
{

    [SerializeField] private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var horizontalDirection = Input.GetAxis("Horizontal");
        var verticalDirection = Input.GetAxis("Vertical");
        var direction = new Vector3(horizontalDirection, verticalDirection, 0);
        direction = Vector3.ClampMagnitude(direction, 1);
        transform.position += direction * (speed * Time.deltaTime);
    }
}
