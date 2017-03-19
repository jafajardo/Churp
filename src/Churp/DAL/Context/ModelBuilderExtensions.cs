using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Churp.DAL.Context
{
    public static class ModelBuilderExtensions
    {
        public static void RemovePluralizingTableNameConvention(this ModelBuilder modelBuilder)
        {
            foreach(IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                if (entity.ClrType == null)
                {
                    continue;
                }

                entity.Relational().TableName = entity.ClrType.Name;
            }
        }
    }
}
