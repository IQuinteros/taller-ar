using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarInformacion : MonoBehaviour
{
    [SerializeField]
    private GameObject textoPorMostrar;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(OnClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnClicked()
    {
        bool estadoDelTexto = textoPorMostrar.activeSelf;

        if (estadoDelTexto)
        {
            textoPorMostrar.SetActive(false);
        }
        else
        {
            textoPorMostrar.SetActive(true);
        }

    }
}
