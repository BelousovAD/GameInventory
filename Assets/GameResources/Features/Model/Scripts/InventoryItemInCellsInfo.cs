namespace GameInventory.Features.Model
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Информация о предмете, который хранится в ячейках в инвентаре.
    /// </summary>
    [Serializable]
    public class InventoryItemInCellsInfo
    {
        [SerializeField]
        private ItemInCellsInfo _info = null;

        /// <summary>
        /// Возвращает информацию о предмете, который хранится в ячейках.
        /// </summary>
        /// <returns>Информация о предмете, который хранится в ячейках.</returns>
        public ItemInCellsInfo GetInfo() => _info;

        /// <summary>
        /// Координаты ячейки отсчёта размера предмета в инвентаре.
        /// </summary>
        public Vector2Int Pivot = Vector2Int.zero;

        /// <summary>
        /// Создаёт объект информации о предмете, который хранится в ячейках в инвентаре.
        /// </summary>
        /// <param name="info">Информация о предмете, который хранится в ячейках.</param>
        /// <param name="pivot">Координаты ячейки отсчёта размера предмета в инвентаре.</param>
        public InventoryItemInCellsInfo(ItemInCellsInfo info, Vector2Int pivot)
        {
            _info = info;
            Pivot = pivot;
        }
    }
}
