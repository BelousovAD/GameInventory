namespace GameInventory.Features.View
{
    using UnityEngine;

    /// <summary>
    /// Компонент создания отображений предметов в инвентаре.
    /// </summary>
    public class ItemSpawner : MonoBehaviour
    {
        [SerializeField]
        private RectTransform _parent = null;
        [SerializeField]
        private GameObject _prefab = null;
        [SerializeField]
        private ItemInCellsView _itemView = null;


    }
}
