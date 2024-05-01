namespace GameInventory.Features.View
{
    using GameInventory.Features.Model;
    using UnityEngine;

    /// <summary>
    /// Компонент отображения предмета в инвентаре.
    /// </summary>
    [RequireComponent(typeof(ItemInCellsView))]
    public class InventoryItemInCellsView : MonoBehaviour
    {
        [SerializeField]
        private RectTransform _parent = null;

        private ItemInCellsView _itemView = null;

        /// <summary>
        /// Устанавливает отображение предмета на позицию в инвентаре и инициализирует отображение предмета.
        /// </summary>
        /// <param name="itemInCellsInfo">Информация о предмете, который хранится в ячейках.</param>
        /// <param name="cellSize">Размер ячейки.</param>
        /// <param name="parent">Инвентарь.</param>
        public void Initialize(ItemInCellsInfo itemInCellsInfo, CellSize cellSize, RectTransform parent)
        {
            _itemView = gameObject.GetComponent<ItemInCellsView>();
            _itemView.Initialize(itemInCellsInfo, cellSize);
            _parent = parent;
        }
    }
}
