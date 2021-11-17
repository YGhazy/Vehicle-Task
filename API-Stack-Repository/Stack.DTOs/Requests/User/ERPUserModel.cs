using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.DTOs.Requests.User
{
    public class ERPUserModel
    {
        public string ERP_EMP_ID { get; set; }
        public string ERP_EMP_NAME { get; set; }
        public string ERP_EMP_EMAIL { get; set; }
        public string ERP_EMP_USER { get; set; }
        public string ERP_EMP_POSITION { get; set; }
        public string ERP_EMP_ORGUNIT_NUMBER { get; set; }
        public string ERP_EMP_ORGUNIT_DESC { get; set; }
        public string ERP_EMP_IS_DEPARTMENT_MANAGER { get; set; }
        public string ERP_EMP_STATUS { get; set; }
        public string ERP_EMP_CREATED_BY { get; set; }
        public string ERP_EMP_UPDATED_BY { get; set; }
        public string ERP_EMP_CREATION_DATE { get; set; }
        public string ERP_EMP_UPDATE_DATE { get; set; }

    }

}
