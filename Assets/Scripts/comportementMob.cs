using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float vitesseRotation = 0.01f;
     public float vitesseY = 0.01f;
     public float vitesseX = 0f;
     public float tauxReduction = 0.2f;
     public Vector2 positionl;
     
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /* rotation et movement de l'objet*/
        transform.Rotate(0,0,vitesseRotation);
        transform.Translate(vitesseX, vitesseY, 0, Space.World);


        /* warping de l'objet quand il dépase un des deux points*/
        if(transform.position.y <= -14f)
        {
            transform.position = new Vector2(transform.position.x, 11f);
        }

        else if(transform.position.y >= 11f)
        {
            transform.position = new Vector2(transform.position.x, -14f);
        }


        /*changement de taille de l'objet*/
        float nouvelleTaille = transform.localScale.x - tauxReduction;
       
         if(nouvelleTaille < 1 || nouvelleTaille > 5f)
        {
            tauxReduction *= -1f;
        }

         transform.localScale = new Vector2(nouvelleTaille, nouvelleTaille);
    }
}
