using DeviationManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviationManager.Model
{
    public interface DeviationModelInter
    {
         Deviation addDeviation(Deviation deviation);
         IList<Deviation> listDeviations(int n, int m);
         Deviation getDeviation(int deviationId);
         Deviation getDeviationWithRef(String deviationRef);
         void deleteDeviation(int deviationId);
         void updateDeviation(Deviation deviation);
         String closeDeviation(String DeviationRef);
         void extendDeviation(Deviation deviation);
         void setIsPrintedDeviation(Deviation deviation);
         void rejectDeviation(Deviation deviation);
         String getUserNameFromActiveDirectory();
         bool isDeviationClosed(Deviation deviation);


         ApprovementGroup addApprovementGroup(ApprovementGroup approvementGroupe);
         ApprovementGroup getApprovementGroup(int id);
         IList<ApprovementGroup> listApprovementGroup();
         void deleteApprovementGroup(int id);
    }
}
