using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string nomeDaCena;

    public void CarregarNovaFase()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
