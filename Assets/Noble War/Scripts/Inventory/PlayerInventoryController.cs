using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


namespace NobleWar.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {

        [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
        private List<AbstractBasePlayerInventoryItemData> _instantiatedItemDataList;

        public Transform Parent;

        public ReactiveCommand ReactiveShootCommand { get; private set; }
        private void Start()
        {
            InitializeInventory(_inventoryItemDataArray);
        }

        private void OnDestroy()
        {
            ClearInventory();
        }

        public void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArray)
        {
            if (ReactiveShootCommand != null)
            {
                //adjusting reactive command
                ReactiveShootCommand.Dispose();
            }
            ReactiveShootCommand = new ReactiveCommand();

            //Clear old inventory
            ClearInventory();
            _instantiatedItemDataList = new List<AbstractBasePlayerInventoryItemData>(_inventoryItemDataArray.Length);


            for (int i = 0; i < inventoryItemDataArray.Length; i++)
            {
                var instantiated = Instantiate(inventoryItemDataArray[i]);
                instantiated.Initialize(this);
                _instantiatedItemDataList.Add(instantiated);
            }
        }

        private void ClearInventory()
        {
            if (_instantiatedItemDataList != null)
            {
                for (int i = 0; i < _instantiatedItemDataList.Count; i++)
                {
                    _instantiatedItemDataList[i].Destroy();
                }
            }
        }
    }
}
