using DeviationManager.Entity;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Model
{
    public class DeviationModel : DeviationModelInter
    {

        /****************** add Derivation ******************************/

        public Deviation addDeviation(Deviation deviation)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(deviation);
                    transaction.Commit();
                }
            }

            return deviation;
        }

        //get the Number of deviation
        public long getAllDeviationNumber()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    long count = (long)session.CreateQuery("select count(*) from Deviation").UniqueResult();
                    return count;
                }
            }
        }

        /************************* List all Derivation **********************************/
        public IList<Deviation> listDeviations(int n, int m)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviations = session.CreateCriteria(typeof(Deviation))
                                     .AddOrder(Order.Desc("deviationId"))
                                     .SetFirstResult(n * m - m)
                                     .SetMaxResults(n * m)
                                     .List<Deviation>();
                    return deviations;
                }
            }
        }


        /************* Get Deviation using Deviation Ref  ****/
        public Deviation getDeviationWithRef(String deviationRef)
        {
            try
            {
                var session = NHibernateHelper.OpenSession();
                var transaction = session.BeginTransaction();

                var deviation = session.CreateCriteria(typeof(Deviation))
                    .Add(Restrictions.Eq("deviationRef", deviationRef))
                    .UniqueResult<Deviation>();

                return deviation;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch(Exception ex){
#pragma warning restore CS0168 // Variable is declared but never used
                return null;
            }
               
                   
        }

        /*********************** Get a Deviation *****************************/
        public Deviation getDeviation(int deviationId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviation = session.Get<Deviation>(deviationId);
                    return deviation;
                }
            }

        }

        /****************** Delete Deviation ****************/
        public void deleteDeviation(int deviationId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviation = this.getDeviation(deviationId);
                    if (deviation != null)
                    {
                        session.Delete(deviation);
                        transaction.Commit();
                    }
               
                }
            }

        }



        /****************** update Deviation ****************/
        public void updateDeviation(Deviation deviation)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Merge(deviation);
                    transaction.Commit();
                }
            }

        }


        /****************** close Deviation ****************/
        public String closeDeviation(String deviationRef)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Deviation deviation = this.getDeviationWithRef(deviationRef);
                    if (deviation != null)
                    {
                        deviation.status = "closed";
                        deviation.dateClosed = DateTime.Now;
                        session.Merge(deviation);
                        transaction.Commit();

                        return "closed";
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        /****************** extend Deviation ****************/
        public void extendDeviation(Deviation deviation)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    deviation.status = "extended";
                    session.Merge(deviation);
                    transaction.Commit();
                }
            }
        }


        /****************** If the Deviation is printed ****************/
        public void setIsPrintedDeviation(Deviation deviation)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    deviation.isPrinted=true;
                    session.Merge(deviation);
                    transaction.Commit();
                }
            }
        }



        /*****************  reject Deviation ************/
        public void rejectDeviation(Deviation deviation)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    deviation.status="rejected";
                    session.Merge(deviation);
                    transaction.Commit();
                }
            }
        }

        
        /******* add an approvement group  */

        public ApprovementGroup addApprovementGroup(ApprovementGroup approvementGroupe)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(approvementGroupe);
                    transaction.Commit();
                }
            }

            return approvementGroupe;
        }


        /*************** get an approvement group */
        public ApprovementGroup getApprovementGroup(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var approvementGroup = session.Get<ApprovementGroup>(id);
                    return approvementGroup;
                }
            }
        }


        /***** update approvement group *****/
        public void updateApprovementGroup(ApprovementGroup approvementGr)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Merge(approvementGr);
                    transaction.Commit();
                }
            }
        }
         

        /************* get list approvement group  *************/
        public IList<ApprovementGroup> listApprovementGroup()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var approvementGroups = session.CreateCriteria(typeof(ApprovementGroup)).List<ApprovementGroup>();
                    return approvementGroups;
                }
            }
        }


        /**** delete approvement group   ***/
        public void deleteApprovementGroup(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var approvementGroup = this.getApprovementGroup(id);
                    if (approvementGroup != null)
                    {
                        session.Delete(approvementGroup);
                        transaction.Commit();
                    }

                }
            }
        }


        /************* get Deviation nombe *********/
        public string getDeviationNumber()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Deviation deviation=null;
                    string year = DateTime.Now.Year.ToString() ;
                    var deviations = session.CreateCriteria(typeof(Deviation)).List<Deviation>();
                    if (deviations.Count != 0)
                    {
                        deviation = session.CreateCriteria(typeof(Deviation)).List<Deviation>().Last();
                    }

                    if (deviation == null)
                    {
                        return year + "-01";
                      
                    }
                    else
                    {
                        int index = deviation.deviationId + 1;

                        if (deviation.deviationId < 9)
                        { 
                            return year + "-0" + index;
                        }
                        else
                        {
                            return year + "-" + index;
                        } 
                    }
                }
            }

           
        }


        /****** search Deviation by devationRef */
        public IList<Deviation> filterDeviationByRef(String refDev){

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviations = session.CreateCriteria(typeof(Deviation))
                     .Add(Restrictions.Like("deviationRef", refDev, MatchMode.Start))
                     .AddOrder(Order.Desc("deviationId"))
                     .List<Deviation>();

                    return deviations;
                }
            }

        }

        /****** search Deviation by Requested by */
        public IList<Deviation> filterDeviationByRequestedBy(String requestedBy)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviations = session.CreateCriteria(typeof(Deviation))
                     .Add(Restrictions.Like("requestedBy", requestedBy, MatchMode.Start))
                     .AddOrder(Order.Desc("deviationId"))
                     .List<Deviation>();

                    return deviations;
                }
            }

        }

        /****** search Deviation by Requested Rick category */
        public IList<Deviation> filterDeviationByRiskCategory(String riskCategory)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviations = session.CreateCriteria(typeof(Deviation))
                     .Add(Restrictions.Eq("deviationRiskCategory", riskCategory))
                     .AddOrder(Order.Desc("deviationId"))
                     .List<Deviation>();

                    return deviations;
                }
            }

        }

        /****** search Deviation by Deviation type */
        public IList<Deviation> filterDeviationByDeviationType(String deviationType)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviations = session.CreateCriteria(typeof(Deviation))
                     .Add(Restrictions.Eq("deviationType", deviationType))
                     .AddOrder(Order.Desc("deviationId"))
                     .List<Deviation>();

                    return deviations;
                }
            }

        }

        /****** search Deviation by Deviation product */
        public IList<Deviation> filterDeviationByPruduct(String product)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviations = session.CreateCriteria(typeof(Deviation))
                     .Add(Restrictions.Like("product", product, MatchMode.Start))
                     .AddOrder(Order.Desc("deviationId"))
                     .List<Deviation>();

                    return deviations;
                }
            }

        }

        /****** search Deviation by Deviation Anlage */
        public IList<Deviation> filterDeviationByAnlage(String anlage)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviations = session.CreateCriteria(typeof(Deviation))
                     .Add(Restrictions.Like("anlage", anlage, MatchMode.Start))
                     .AddOrder(Order.Desc("deviationId"))
                     .List<Deviation>();

                    return deviations;
                }
            }

        }

        /****** search Deviation by date  span */
        public IList<Deviation> filterDeviationByDateSpan(DateTime date1, DateTime date2)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var deviations = session.CreateCriteria(typeof(Deviation))
                     .Add(Restrictions.Between("dateCreation", date1, date2))
                     .AddOrder(Order.Desc("deviationId"))
                     .List<Deviation>();

                    return deviations;
                }
            }

        }


        /****** search Deviation using all properties*/
        public IList<Deviation> filterDeviationByAll(String deviationRef, String requestedBy, String deviationRiskCategory, String deviationType, DateTime date1, DateTime date2, String anlage, String product)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var creteria  = session.CreateCriteria(typeof(Deviation));
                    if (deviationRef != "")
                    {
                        creteria.Add(Restrictions.Eq("deviationRef", deviationRef));
                    }
                    if (requestedBy != "")
                    {
                        creteria.Add(Restrictions.Eq("requestedBy", requestedBy));
                    }
                    if (deviationRiskCategory != "")
                    {
                        creteria.Add(Restrictions.Eq("deviationRiskCategory", deviationRiskCategory));
                    }
                    if (deviationType != "")
                    {
                        creteria.Add(Restrictions.Eq("deviationType", deviationType));
                    }
                    if (anlage != "")
                    {
                        creteria.Add(Restrictions.Eq("anlage", anlage));
                    }
                    if (product != "")
                    {
                        creteria.Add(Restrictions.Eq("product", product));
                    }
                    if (DateTime.Compare(date1,date2)!=0)
                    {
                        creteria.Add(Restrictions.Between("dateCreation", date1, date2));
                    }



                    var deviations= creteria.AddOrder(Order.Desc("deviationId"))
                                    .List<Deviation>();

                    return deviations;
                }
            }

        }

        /*********************** Get an Approvement *****************************/
        public Approvement getApprovement(int approvementID)
        {
            try
            {
                var session = NHibernateHelper.OpenSession();
                var transaction = session.BeginTransaction();

                var approvement = session.Get<Approvement>(approvementID);
                return approvement;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return null;
            }
               
            
        }


        /****** update Approvement  ****/
        public void updateApprovement(Approvement approvement)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Merge(approvement);
                    transaction.Commit();
                }
            }

        }

        //***************
        /************************* List all Derivation **********************************/
        public ApprovementGroup getApprovementGroup(Approvement approvement)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var approvementLazy = session.Get<Approvement>(approvement.approvementId);
                    return approvement.approvementGroup;
                }
            }
        }

        //delete attachemnt
        public bool deleteAttachment(String fileNameDB)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var attachment = session.CreateCriteria(typeof(Attachments))
                        .Add(Restrictions.Eq("fileNameDb", fileNameDB))
                        .UniqueResult<Attachments>();

                    if (attachment != null)
                    {
                        session.Delete(attachment);
                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /*****   get user name from ative directory for signature *****/
        public String getUserNameFromActiveDirectory()
        {
            String name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            return name;
        }


        //verify if the deviation is closed
        public bool isDeviationClosed(Deviation deviation)
        {
            if (deviation.status == "closed")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        //List deviation on pending--> Yellow Color: Deviation im Zeitfenster & Unvollstängig
        public IList<Deviation> listPendingDeviation(int n, int m)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    var creterea = session.CreateCriteria(typeof(Deviation))
                                     .AddOrder(Order.Desc("deviationId"))
                                     .SetFirstResult(n * m - m)
                                     .SetMaxResults(n * m);

                    var deviations = creterea.List<Deviation>();


                    IList<Deviation> pendingDeviationList = new List<Deviation>();
                    foreach (var deviation in deviations)
                    {
                        if (deviation.Freigabe == "In Bearbeitung")
                        {
                            pendingDeviationList.Add(deviation);
                        }
                    }

                    return pendingDeviationList;
                }
            }
        }

        //Number of deviation on Pending
        public int getPendingDeviationNumber()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {

                    var deviations = session.CreateCriteria(typeof(Deviation))
                                     .List<Deviation>();

                    IList<Deviation> pendingDeviationList = new List<Deviation>();
                    foreach (var deviation in deviations)
                    {
                        if (deviation.Freigabe == "In Bearbeitung")
                        {
                            pendingDeviationList.Add(deviation);
                        }
                    }

                    return pendingDeviationList.Count;
                }
            }
        }
        
        //List deviation on Rejected-->Red color: Deviation Abgeleht oder abgelaufen und unvollständig
        public IList<Deviation> listRejectedDeviation(int n, int m)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    DateTime actualDate = DateTime.Now;

                    var deviations = session.CreateCriteria(typeof(Deviation))
                        .AddOrder(Order.Desc("deviationId"))
                        .SetFirstResult(n * m - m)
                        .SetMaxResults(n * m)
                        .List<Deviation>();

                    IList<Deviation> pendingDeviationList = new List<Deviation>();
                    foreach (var deviation in deviations)
                    {
                        if (deviation.Freigabe == "Abgelehnt" || deviation.Freigabe == "Gesperrt" || deviation.Freigabe == "Abgelaufen & Unvolständig")
                        {
                            pendingDeviationList.Add(deviation);
                        }
                    }

                    return pendingDeviationList;
                }
            }
        }

        //Number of deviation on Rejected-->Red color: Deviation Abgeleht oder abgelaufen und unvollständig
        public int getRejectedDeviationNumber()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    DateTime actualDate = DateTime.Now;

                    var deviations = session.CreateCriteria(typeof(Deviation))
                        .List<Deviation>();

                    IList<Deviation> pendingDeviationList = new List<Deviation>();
                    foreach (var deviation in deviations)
                    {
                        if (deviation.Freigabe == "Abgelehnt" || deviation.Freigabe == "Gesperrt" || deviation.Freigabe == "Abgelaufen & Unvolständig")
                        {
                           
                            pendingDeviationList.Add(deviation);
                        }
                    }

                    return pendingDeviationList.Count;
                }
            }
        }

        //List deviation are approved-->green color: Deviation Freigegeben & im Zeitfenster
        public IList<Deviation> listApprovedDeviation(int n, int m)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    DateTime actualDate = DateTime.Now;

                    var deviations = session.CreateCriteria(typeof(Deviation))
                        .AddOrder(Order.Desc("deviationId"))
                        .Add(Restrictions.Ge("endDatePeriod", actualDate))
                        .SetFirstResult(n * m - m)
                        .SetMaxResults(n * m)
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



        //Number of approved Deviation
        public int getApprovedDeviationNumber()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    DateTime actualDate = DateTime.Now;

                    var deviations = session.CreateCriteria(typeof(Deviation))
                        .Add(Restrictions.Ge("endDatePeriod", actualDate))
                        .List<Deviation>();

                    IList<Deviation> pendingDeviationList = new List<Deviation>();
                    foreach (var deviation in deviations)
                    {
                        if (deviation.Freigabe == "Freigegeben")
                        {
                            pendingDeviationList.Add(deviation);
                        }
                    }

                    return pendingDeviationList.Count;
                }
            }
        }

        //List deviation are expired und approved--> gray color: Deviation freigegeb & abgelaufen
        public IList<Deviation> listApprovedExpiredDeviation(int n, int m)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    DateTime actualDate = DateTime.Now;

                    var deviations = session.CreateCriteria(typeof(Deviation))
                        .AddOrder(Order.Desc("deviationId"))
                        .Add(Restrictions.Le("endDatePeriod", actualDate))
                        .SetFirstResult(n * m - m)
                        .SetMaxResults(n * m)
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

        //Number of deviation are expired und approved--> gray color: Deviation freigegeb & abgelaufen
        public int listApprovedExpiredDeviationNumber()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    DateTime actualDate = DateTime.Now;

                    var deviations = session.CreateCriteria(typeof(Deviation))
                        .Add(Restrictions.Le("endDatePeriod", actualDate))
                        .List<Deviation>();

                    IList<Deviation> pendingDeviationList = new List<Deviation>();
                    foreach (var deviation in deviations)
                    {
                        if (deviation.Freigabe == "Freigegeben")
                        {
                            pendingDeviationList.Add(deviation);
                        }
                    }

                    return pendingDeviationList.Count;
                }
            }
        }


        //add a password 
        public bool addPassword(Connection conn)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(conn);
                    transaction.Commit();
                }
            }

            return true;
        }

        //update passwor 
        public bool updatePassword(String oldpassword, String newPasssword)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Connection conn = this.getPassword();
                    if (conn != null)
                    {
                        if (conn.password.Equals(oldpassword))
                        {
                            conn.password = newPasssword;

                            session.Merge(conn);
                            transaction.Commit();

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

#pragma warning disable CS0162 // Unreachable code detected
            return true;
#pragma warning restore CS0162 // Unreachable code detected
        }

        //get password 
        public Connection getPassword()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var connection = session.CreateCriteria(typeof(Connection)).List<Connection>();
                    if (connection.Count > 1)
                    {
                       return session.CreateCriteria(typeof(Connection)).List<Connection>().First<Connection>();
                    }
                    else
                    {
                        return session.CreateCriteria(typeof(Connection)).UniqueResult<Connection>();
                    }

                }
            }
        }

        //verify password 
        public bool verifyPassword(String password)
        {

            Connection conn = this.getPassword();
            if (conn != null)
            {
                if (password.Equals(conn.password))
                {
                    return true;
                }else
                {
                    return false;
                }
            }else
            {
                return false;
            }
        }


        //

        /******____class   */

    }
}
