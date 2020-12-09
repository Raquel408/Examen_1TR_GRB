using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{

    //---SCRIPT ASOCIADO AL EMPTY OBJECT QUE CREARÁ LOS OBSTÁCULOS--//

    //Variable que contendré el prefab con el obstáculo
    [SerializeField] GameObject EnemySphere;

    //Variable que tiene la posición del objeto de referencia
    [SerializeField] Transform InitPos;

    //Variables para generar columnas de forma random
    private float randomNumber;
    Vector3 RandomPos;

    //Distancia a la que se crean las columnas iniciales
    [SerializeField] float distanciaInicial = 3;
    //Acceder a los componentes de la nave
    public GameObject EnemySphere;
    private SpaceshipMove spaceshipMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
