namespace GameInventory.Feature.Model
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Информация о предмете в инвентаре.
    /// </summary>
    [Serializable]
    public class InventoryItemInfo
    {
        [SerializeField]
        private ItemInfo _info = null;

        /// <summary>
        /// Возвращает информацию о предмете.
        /// </summary>
        /// <returns>Информация о предмете.</returns>
        public ItemInfo GetInfo() => _info;

        /// <summary>
        /// Координаты ячейки отсчёта размера предмета в инвентаре.
        /// </summary>
        public Vector2Int Pivot = Vector2Int.zero;

        /// <summary>
        /// Создаёт объект информации о предмете в инвентаре.
        /// </summary>
        /// <param name="info">Информация о предмете.</param>
        /// <param name="pivot">Координаты ячейки отсчёта размера предмета в инвентаре.</param>
        public InventoryItemInfo(ItemInfo info, Vector2Int pivot)
        {
            _info = info;
            Pivot = pivot;
        }
    }
}
