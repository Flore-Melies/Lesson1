using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    [SerializeField] private GameObject toSpawn;

    private Camera mainCam; // Déclaration d'une variable qui va référencer la camera de rendu
    // Start is called before the first frame update
    void Start()
    {
        // Assignation à mainCam de la camera de rendu
        mainCam = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        // Conditionnelle d'appui sur la touche espace
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Déclaration de variable puis assignation a celle ci de l'équivalent en 3D du coin gauche bas de la camera 
            var minPos = mainCam.ScreenToWorldPoint(Vector3.zero);
            // Récupération de la résolution de sortie de la camera
            var maxScreenPos = new Vector3(
                mainCam.pixelWidth, // Largeur de rendu de la camera en pixel
                mainCam.pixelHeight, // Hauteur de rendu de la camera en pixel
                0
                );
            // Récupération de l'équivalent 3D du coin haut droite de la camera
            var maxPos = mainCam.ScreenToWorldPoint(maxScreenPos);
            // Déclaration d'un Vector3 aléatoire entre minPos et maxPos
            var position = new Vector3(
                Random.Range(minPos.x, maxPos.x),
                Random.Range(minPos.y, maxPos.y),
                0);
            // Crée l'objet à la position précédemment calculée 
            Instantiate(toSpawn, position, Quaternion.identity);
        }
    }
}
