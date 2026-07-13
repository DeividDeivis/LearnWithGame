using TMPro; // Utilizamos TMPro para acceder a Text Mesh Pro, un package agregado a Unity que da mas opciones de configuracion a los textos. 
using UnityEngine;
using UnityEngine.SceneManagement; // Utilizamos UnityEngine.SceneManagement para utilizar metodos de carga y descarga de escenas.
using UnityEngine.UI; // Utilizamos UnityEngine.UI para poder usar las clases Button, Image, Text, etc.

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI PointsText; // Text Mesh Pro es un text el cual permite mas configuraciones que la clase Text de Unity.
    [SerializeField] private GameObject LoseScreenContainer; // GameObject que contiene el boton de reintentar y el texto. 
    public Button tryAgainButton; // Podemos asignar esta variable desde el inspector arrastrando el componente button hasta la variable. 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tryAgainButton.onClick.AddListener(TryAgainBtnClicked); // Utilizamos el metodo AddListener para subscribir un metodo al evento onClick del boton.
        LoseScreenContainer.SetActive(false); // Utilizamos el metodo SetActive(bool) para activar o desactivar instancias de objetos en Unity.
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowLoseScreen() 
    {
        LoseScreenContainer.SetActive(true);
    }

    private void TryAgainBtnClicked() 
    {
        Debug.Log("Try Again Button Clicked");
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Single); // Cargamos la escena actual de nuevo, recargamos la escena para reiniciar el juego.
    }
}
