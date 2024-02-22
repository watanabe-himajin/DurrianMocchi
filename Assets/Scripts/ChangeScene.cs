using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static int Coin = 0;
    // Start is called before the first frame update
    public void ChangeSelectStage()
    {
        SceneManager.LoadScene("SelectStage");
    }

    public void ChangeTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void ChangeRiver()
    {
        SceneManager.LoadScene("River");
    }

    public void ChangeSwamp()
    {
        SceneManager.LoadScene("Swamp");
    }

    public void ChangeSea()
    {
        SceneManager.LoadScene("Sea");
    }

    public void ChangeTestStage()
    {
        SceneManager.LoadScene("TestStage");
    }
}
