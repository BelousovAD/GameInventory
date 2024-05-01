namespace GameInventory.Features.View
{
    using GameInventory.Features.Model;
    using UnityEngine;

    [RequireComponent(typeof(RectTransform))]
    public class ItemInCellsView : MonoBehaviour
    {
        private ItemInCellsInfo _itemInCellsInfo = null;
        private CellSize _cellSize = null;

        /// <summary>
        /// Отображает предмет, который хранится в ячейках.
        /// </summary>
        /// <param name="itemInCellsInfo">Информация о предмете, который хранится в ячейках.</param>
        /// <param name="cellSize">Размер ячейки.</param>
        public void Initialize(ItemInCellsInfo itemInCellsInfo, CellSize cellSize)
        {
            _itemInCellsInfo = itemInCellsInfo;
            _cellSize = cellSize;

            RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
            rectTransform.anchorMin = new Vector2(0f, 1f);
            rectTransform.anchorMax = new Vector2(0f, 1f);
            rectTransform.sizeDelta = new Vector2(
                _cellSize.Width * _itemInCellsInfo.GetSizeInInventory().x,
                _cellSize.Height * _itemInCellsInfo.GetSizeInInventory().y
                );
        }
    }
}
