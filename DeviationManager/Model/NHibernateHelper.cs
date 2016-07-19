using DeviationManager.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

public class NHibernateHelper
{
    private static ISessionFactory _sessionFactory;

    private static ISessionFactory SessionFactory
    {
        get
        {
            if (_sessionFactory == null)

                InitializeSessionFactory();
            return _sessionFactory;
        }
    }

    private static void InitializeSessionFactory()
    {
        _sessionFactory = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2008

                .ConnectionString(c => c
                                .Server("10.104.17.57")
                                .Database("DevReport")
                                .Username("Visuuser")
                                .Password("Monaco-91")
              )

            )

            .Mappings(m =>
                      m.FluentMappings
                          .AddFromAssemblyOf<DeviationMap>())
             //updating schema DO NOT DELETE DB!
            /*.ExposeConfiguration(cfg => new SchemaUpdate(cfg)
                                            .Execute(true, true))*/
            .BuildSessionFactory();
    }

    public static ISession OpenSession()
    {
        return SessionFactory.OpenSession();
    }
}