using System.Data.Entity.Core.Metadata.Edm;

namespace ValSystem.SQLite.Public
{
    public interface ISqlGenerator
    {
        string Generate( EdmModel storeModel );
    }
}