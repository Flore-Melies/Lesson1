using UnityEngine;

public class AutoMovingCubeBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Renderer objectToChange; // Déclaration d'une variable de type Renderer assignable dans Unity. Permet de récupérer le material d'un objet
    
    private bool shouldMove = false; // Sert à laisser le cube immobile au lancement de la scene

    /// <summary>
    /// FixedUpdate est utilisé dès que l'on souhaite manipuler des Rigidbodies
    /// </summary>
    private void FixedUpdate()
    {
        if(shouldMove)
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.right * (speed * Time.fixedDeltaTime)); // On récupère le Rigidbody de l'objet sur lequel est appliqué le script, puis on exécute la fonction MovePosition pour le déplacer
        if (Input.GetKeyDown(KeyCode.Space) && !shouldMove) // Double conditionnelle : si on a appuyé sur espace à cette frame précise et que shouldMove == false
            shouldMove = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        objectToChange.material.color = Color.cyan; // On récupère le material de l'objet dont on doit changer la couleur, on récupère la couleur du material puis on lui assigne une nouvelle couleur
    }

    private void OnCollisionEnter(Collision other)
    {
        objectToChange.material.color = Color.red;
    }
}
