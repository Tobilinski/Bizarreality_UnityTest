using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField]
    private Material _materialGlow;
    [SerializeField]
    private Material _materialNormal;
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.right * -1, out RaycastHit hit, 3f))
        {
            if (hit.collider.CompareTag("ChangeMaterial"))
            {
                _meshRenderer.material = _materialGlow;
            }
        }
        else
        {
            _meshRenderer.material = _materialNormal;
        }
    }
}
