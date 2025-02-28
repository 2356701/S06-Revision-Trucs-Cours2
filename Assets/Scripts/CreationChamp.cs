using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationChamp : MonoBehaviour
{
    [SerializeField] private GameObject _objetACreer;
    [SerializeField] private GameObject _objetPlacemenent;
    [SerializeField] Vector3 _positionCreation;

    void Start()
    {
        InvokeRepeating("CreerObjet", 0f, 1f);
    }

    void CreerObjet()
    {
        // Modifie la coordonnée X de manière aléatoire entre -2 et 2
        float randomX = Random.Range(-1.50f, 1.50f);  // Génère un nombre flottant entre -2 et 2
        float randomZ = Random.Range(-3.50f, -0.50f);
        // Utilise la coordonnée Y et Z de _positionCreation et remplace X par randomX
        Vector3 nouvellePosition = new Vector3(randomX, _positionCreation.y, randomZ);

        // Instancie l'objet à la nouvelle position avec une rotation (par exemple, 90 degrés autour de l'axe Y)
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
        Instantiate(_objetACreer, nouvellePosition, _rotation);
    }
}
