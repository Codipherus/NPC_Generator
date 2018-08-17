using NPCgenerator.Data;
using NPCgenerator.Models.Create;
using NPCgenerator.Models.ListItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Services
{
    public class EquipmentService
    {
        public bool CreateEquipment(EquipmentCreate model)
        {
            var entity =
                new Equipment()
                {
                    EquipmentName = model.EquipmentName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Equipments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public ICollection<EquipmentListItem> GetEquipments()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Equipments
                        .Select(
                            e =>
                                new EquipmentListItem
                                {
                                    EquipmentName = e.EquipmentName,
                                }
                        );
                return query.ToArray();
            }

        }
    }
}
