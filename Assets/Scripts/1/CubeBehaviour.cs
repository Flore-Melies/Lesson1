using UnityEngine; // import du namespace UnityEngine

public class CubeBehaviour : MonoBehaviour // Déclaration d'une classe héritée de Mènobehaviour
{

    [SerializeField] private float rotationSpeed; // Déclaration de variable privée de type float avec un attribut de sérialisation
    
    // Update is called once per frame
    
    /// <summary>
    /// Appelée à chaque frame et fait tourner le cube
    /// </summary>
    void Update()
    {
        // Effectuer la rotation selon l'axe y de l'objet multiplié par la variable rotationSpeed et Time.deltaTime
        // On multiplie d'abord rotationSpeed et deltaTime pour optimiser
        transform.Rotate(transform.up * (rotationSpeed * Time.deltaTime));
    }
}
