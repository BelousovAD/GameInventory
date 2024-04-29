namespace GameInventory.Feature.Model
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Информация об инвентаре.
    /// </summary>
    [CreateAssetMenu]
    public class InventoryInfo : ScriptableObject
    {
        [SerializeField]
        [Min(0)]
        private Vector2Int _size = Vector2Int.zero;

        /// <summary>
        /// Возвращает размер инвентаря в ячейках.
        /// </summary>
        /// <returns>Размер в ячейках.</returns>
        public Vector2Int GetSize() => _size;

        [SerializeField]
        private List<InventoryItemInfo> _inventoryItems = new List<InventoryItemInfo>();

        /// <summary>
        /// Добавляет предмет в инвентарь.
        /// </summary>
        /// <param name="inventoryItem">Информация о предмете в инвентаре.</param>
        /// <param name="newPivot">Координаты ячейки отсчёта размера предмета в инвентаре.</param>
        public void AddItem(InventoryItemInfo inventoryItem, Vector2Int newPivot)
        {
            InventoryItemInfo existingItem = FindItem(inventoryItem);

            if (existingItem != null)
            {
                existingItem.Pivot = newPivot;
            }
            else
            {
                _inventoryItems.Add(new InventoryItemInfo(inventoryItem.GetInfo(), newPivot));
            }
        }

        /// <summary>
        /// Удаляет предмет из инвентаря.
        /// </summary>
        /// <param name="inventoryItem">Информация о предмете в инвентаре.</param>
        public void RemoveItem(InventoryItemInfo inventoryItem)
        {
            InventoryItemInfo existingItem = FindItem(inventoryItem);

            if (existingItem != null)
            {
                _inventoryItems.Remove(existingItem);
            }
        }

        private InventoryItemInfo FindItem(InventoryItemInfo inventoryItem)
        {
            foreach (InventoryItemInfo item in _inventoryItems)
            {
                if (item == inventoryItem)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
