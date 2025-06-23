using UnityEngine;
using UnityEngine.Tilemaps;

namespace _Scripts
{
    public class TileEraser : MonoBehaviour
    {
        [SerializeField] private Tilemap tilemap;
    
        void Update()
        {
            if (Input.GetMouseButtonDown(0)) // Sol tık
            {
                Vector3 mouseWorldPos = ConstValues.MainCamera.ScreenToWorldPoint(Input.mousePosition);
                Vector3Int tilePosition = tilemap.WorldToCell(mouseWorldPos);
                
                tilemap.SetTile(tilePosition, null);
                
                tilemap.SetTileFlags(tilePosition, TileFlags.None);
                tilemap.SetColor(tilePosition, Color.red);
            }
        }
        
    }
}
