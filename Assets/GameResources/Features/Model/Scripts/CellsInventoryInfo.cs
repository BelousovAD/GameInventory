namespace GameInventory.Features.Model
{
    using UnityEngine;

    /// <summary>
    /// Информация об инвентаре, который хранит предметы в ячейках.
    /// </summary>
    [CreateAssetMenu(fileName = "CellsInventoryInfo", menuName = "GameInventory/Features/Model")]
    public class CellsInventoryInfo : BaseInventoryInfo<InventoryItemInCellsInfo>
    {
        [SerializeField]
        [Min(0)]
        private Vector2Int _size = Vector2Int.zero;

        /// <summary>
        /// Возвращает размер инвентаря в ячейках.
        /// </summary>
        /// <returns>Размер в ячейках.</returns>
        public Vector2Int GetSize() => _size;

        private bool[,] _grid = null;

        /// <summary>
        /// Создаёт сетку ячеек при изменении размера.
        /// </summary>
        public void OnValidate() => _grid = new bool[_size.x, _size.y];

        private CellsInventoryInfo _secondInventory = null;

        /// <summary>
        /// Устанавливает ссылку на инвентарь, с которым производится обмен предметами.
        /// </summary>
        /// <param name="secondInventory">Инвентарь, с которым производится обмен предметами.</param>
        public void EnterTransferMenu(CellsInventoryInfo secondInventory) => _secondInventory = secondInventory;

        /// <summary>
        /// Удаляет ссылку на инвентарь, с которым производится обмен предметами.
        /// </summary>
        public void ExitTransferMenu() => _secondInventory = null;

        /// <summary>
        /// Добавляет предмет в инвентарь.
        /// </summary>
        /// <param name="inventoryItem">Информация о предмете в инвентаре.</param>
        /// <param name="newPivot">Координаты ячейки отсчёта размера предмета в инвентаре.</param>
        public void AddItem(InventoryItemInCellsInfo inventoryItem, Vector2Int newPivot)
        {
            if (CanAddItem(newPivot, inventoryItem.GetInfo().GetSizeInInventory()))
            {
                _secondInventory.RemoveItem(inventoryItem);

                _inventoryItems.Add(new InventoryItemInCellsInfo(inventoryItem.GetInfo(), newPivot));

                UpdateGrid(newPivot, inventoryItem.GetInfo().GetSizeInInventory(), true);
            }
        }

        /// <summary>
        /// Удаляет предмет из инвентаря.
        /// </summary>
        /// <param name="inventoryItem">Информация о предмете в инвентаре.</param>
        public void RemoveItem(InventoryItemInCellsInfo inventoryItem)
        {
            InventoryItemInCellsInfo existingItem = FindItem(inventoryItem);

            if (existingItem != null)
            {
                _inventoryItems.Remove(existingItem);

                UpdateGrid(existingItem.Pivot, existingItem.GetInfo().GetSizeInInventory(), false);
            }
        }

        private bool CanAddItem(Vector2Int pivot, Vector2Int size)
        {
            for (int i = pivot.x; i < pivot.x + size.x; ++i)
            {
                for (int j = pivot.y; j < pivot.y + size.y; ++j)
                {
                    if (_grid[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void UpdateGrid(Vector2Int pivot, Vector2Int size, bool addItem)
        {
            for (int i = pivot.x; i < pivot.x + size.x; ++i)
            {
                for (int j = pivot.y; j < pivot.y + size.y; ++j)
                {
                    _grid[i, j] = addItem;
                }
            }
        }

        private InventoryItemInCellsInfo FindItem(InventoryItemInCellsInfo inventoryItem)
        {
            foreach (InventoryItemInCellsInfo item in _inventoryItems)
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
