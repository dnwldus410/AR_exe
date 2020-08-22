using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject menuSet;
    private bool m_clk=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* if(Application.platform == RuntimePlatform.Android )
         {
             if (Input.GetKey(KeyCode.Escape) && !m_clk)
             {
                 menuSet.SetActive(true);
                 m_clk = true;
             }
             if (Input.GetKey(KeyCode.Escape) && m_clk)
             {
                 menuSet.SetActive(true);

             }
         }*/
        if (Input.GetKey(KeyCode.Escape) && !m_clk)
        {
            menuSet.SetActive(true);
            m_clk = true;
        }
        if (Input.GetKey(KeyCode.Escape) && m_clk)
        {
            menuSet.SetActive(true);

        }


    }
    public void StartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void AgainButton()
    {
        menuSet.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
