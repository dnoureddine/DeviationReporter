using DeviationManager.Entity;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviationManager.Model
{
    public class StatisticsModel
    {

        //Freigegebene Abweichungen
        public IList<Deviation> getApprovedDeviationNumber(int year, int month)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    DateTime date1 = new DateTime(year, month, 1);
                    DateTime date2 = new DateTime(year, month, 1);

                    if (month == 12)
                    {
                         date2 = new DateTime(year, 1, 1);
                    }else
                    {
                        date2 = new DateTime(year, month+1, 1);
                    }

                    var createria = session.CreateCriteria(typeof(Deviation));
                        createria.Add(NHibernate.Criterion.Restrictions.Between("dateCreation", date1, date2));

                    var deviations = createria.AddOrder(Order.Desc("deviationId"))
                               .List<Deviation>();

                    IList<Deviation> pendingDeviationList = new List<Deviation>();
                    foreach (var deviation in deviations)
                    {
                        if (deviation.Freigabe == "Freigegeben")
                        {
                            pendingDeviationList.Add(deviation);
                        }
                    }

                    return pendingDeviationList;
                }
            }
        }



        //approved oder closed Deviations
        public IList<Deviation> getRejectedDeviationNumber(int year, int month)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    DateTime date1 = new DateTime(year, month, 1);
                    DateTime date2 = new DateTime(year, month, 1);

                    if (month == 12)
                    {
                        date2 = new DateTime(year, 1, 1);
                    }
                    else
                    {
                        date2 = new DateTime(year, month + 1, 1);
                    }

                    var creteria = session.CreateCriteria(typeof(Deviation));
                        creteria.Add(NHibernate.Criterion.Restrictions.Between("dateCreation", date1, date2));

                    var deviations = creteria.AddOrder(Order.Desc("deviationId"))
                                   .List<Deviation>();

                    IList<Deviation> pendingDeviationList = new List<Deviation>();
                    foreach (var deviation in deviations)
                    {
                        if (deviation.Freigabe == "Abgelehnt" || deviation.Freigabe == "Gesperrt" || deviation.Freigabe== "Abgelaufen & Unvolständig")
                        {
                            pendingDeviationList.Add(deviation);
                        }
                    }

                    return pendingDeviationList;
                }
            }
        }






    }
}
