using UnityEngine;

public class Sector : MonoBehaviour
{

    public bool GoodBad = true;
    public Material GoodMat;
    public Material BadMat;

    private void Awake()
    {
        UpdateMat();
    }

    private void UpdateMat()
    {
        Renderer sectorRenderer = GetComponent<Renderer>();
        sectorRenderer.sharedMaterial = GoodBad ? GoodMat : BadMat;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out Player player))
        {
            Vector3 normal = -collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.up);
            if (dot >= 0.5) 
            {
                if (GoodBad) player.Prijok();
                else player.Die();
            } 
        }
    }

    private void OnValidate()
    {
        UpdateMat();
    }
}
