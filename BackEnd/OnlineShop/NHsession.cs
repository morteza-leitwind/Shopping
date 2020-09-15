using NHibernate;
using NHibernate.Cfg;
using System.Web;

namespace OnlineShop
{
    public class NHsession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\hibernate.cfg.xml");
            configuration.Configure(configurationPath);
            configuration.AddFile(HttpContext.Current.Server.MapPath(@"~\Mapping\CartMap.hbm.xml"));            
            configuration.AddFile(HttpContext.Current.Server.MapPath(@"~\Mapping\ProductMap.hbm.xml"));
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}