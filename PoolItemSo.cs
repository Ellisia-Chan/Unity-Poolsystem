using UnityEngine;

namespace SO {
    [CreateAssetMenu(fileName = "PoolItem", menuName = "ScriptableObjects/PoolItem")]
    public class PoolItemSO : ScriptableObject {
        [HideInInspector] public string itemName;
        public GameObject prefab;
        public int poolSize;
        public Vector2 resetPosition = new Vector2(0, -100f);

        private void OnValidate() {
            if (string.IsNullOrEmpty(itemName)) {
                itemName = name;
            }
        }
    } 
}
