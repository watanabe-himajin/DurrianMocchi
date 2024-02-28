using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
    public void SelectStage()
    {
        SceneManager.LoadScene("SelectStage");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void River()
    {
        SceneManager.LoadScene("River");
    }
    public void Swamp()
    {
        SceneManager.LoadScene("Swamp");
    }
    public void Sea()
    {
        SceneManager.LoadScene("Sea");
    }
}
