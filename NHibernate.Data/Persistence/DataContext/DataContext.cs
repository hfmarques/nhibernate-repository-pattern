using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace NHibernate.Data.Persistence.DataContext
{
    public class DataContext
    {
        public ISessionFactory SessionFactory { get; }

        public DataContext()
        {

            SessionFactory = Fluently
                .Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DataContext>())
                .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
