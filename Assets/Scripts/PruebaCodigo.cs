using System;
using UnityEngine;

public class PruebaCodigo : MonoBehaviour
{
    public int A = 10;  
    public int B = 18;
    public int Resultado;

    public CharacterClass CharacterClass;

    [SerializeField][Range(0f, 10f)] private float moveSpeed = 10f;

    public bool Pregunta;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Resultado = A % B;

        Comparacion();

        PlayerController player = new PlayerController();

        AudioSource audio = new AudioSource();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Comparacion();
        Comparacion();
        Comparacion();
        Comparacion();
    }

    private void Comparacion() 
    {
        switch (Resultado)
        {
            case 0:
                Debug.Log("ES PAR");
                break;
            case 1:
                Debug.Log("ES IMPAR");
                break;
            case 2:
                Debug.Log("ES 2");
                break;
            default:
                Debug.Log("NO SE CUMPLIO NINGUN CASO");
                break;
        }
    }
}

public enum CharacterClass { Guerrero, Mago, Hechicero, Ladron }

