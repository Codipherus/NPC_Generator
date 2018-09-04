using NPCgenerator.Contracts;
using NPCgenerator.Data;
using NPCgenerator.Models.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPCgenerator.Services
{
    public class EquipmentService : IEquipmentService
    {
        private Guid _ownerId;

        public EquipmentService(Guid userId)
        {
            _ownerId = userId;
        }

        public bool CreateEquipment(EquipmentCreate model)
        {
            var entity = new Equipment
            {
                OwnerId = _ownerId,
                EquipmentName = model.EquipmentName
            };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.Equipments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
