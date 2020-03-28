using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))] // Permet de forcer l'existence d'un composant Button sur l'objet sur lequel est appliqué ce script
public class LoadSceneButton : MonoBehaviour
{
    [SerializeField] private string sceneName;

    // Start is called before the first frame update
    void Start()
    { 
        // On récupère le composant Button sur l'objet du script, puis on récupère la liste des actions à effectuer lors d'un click sur le bouton
        // Enfin, on ajoute à cette liste la fonction LoadScene()
        GetComponent<Button>().onClick.AddListener(LoadScene);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}