using UnityEngine; // Import du namespace UnityEngine

public class MovingCubeBehaviour : MonoBehaviour 
{

    [SerializeField] private float speed; //Déclaration d'une variable privée de type float avec un attribut de sérialisation

    // Update is called once per frame
    private void Update()
    {
        // Déclaration d'une variable, puis assignation à celle ci du résultat de la fonction GetAxis avec "Horizontal" en paramètre 
        var horizontalDirection = Input.GetAxis("Horizontal");
        // Pareil mais on change de paramètre
        var verticalDirection = Input.GetAxis("Vertical");
        // Déclaration de variable puis assignation d'un Vector3 dont les axes x et y sont les variables déclarées précédemment
        var direction = new Vector3(horizontalDirection, verticalDirection, 0);
        // Assignation du résultat de la fonction ClampMagnitude dans la classe Vector3 avec en paramètre la variable précédente et 1
        // ClampMagnitude = réduire un vecteur jusqu'à une taille donnée
        // Si on ne Clamp pas, en diagonale on va plus vite, cf le Debug.Log ci dessous
        //Debug.Log(direction.magnitude);
        direction = Vector3.ClampMagnitude(direction, 1);
        // On assigne à notre position la somme de notre position actuelle et du déplacement de l'input multiplié par la speed et par deltaTime
        transform.position += direction * (speed * Time.deltaTime);
    }
}
