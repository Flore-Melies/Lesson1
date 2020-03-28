using UnityEngine;

public class Exercice2 : MonoBehaviour
{
    [SerializeField] private string myString;
    [SerializeField] private int myInt;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myString);
        if (myInt > 5)
        {
            Debug.Log(myInt);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

