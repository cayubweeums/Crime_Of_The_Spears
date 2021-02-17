using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBook : MonoBehaviour
{

    public string myText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.StartDialog(myText);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.HideDialog();
        }
    }

}
