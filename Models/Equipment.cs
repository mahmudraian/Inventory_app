using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_app.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string EqipmentName { get; set; }

        public string EquipmentType { get; set; }

        public static List<Equipment> EquipmentList()
        {
            List<Equipment> equipmentList = new List<Equipment>();

            for (int i=1; i < 10; i++)
            {
                Equipment equipment = new Equipment();
                equipment.EquipmentId = i;
                equipment.EqipmentName = "Test Equipment_" + i.ToString();
                equipment.EquipmentType = "Medical_" + i.ToString();
                equipmentList.Add(equipment);
            }


            return equipmentList;
        }

    }
}