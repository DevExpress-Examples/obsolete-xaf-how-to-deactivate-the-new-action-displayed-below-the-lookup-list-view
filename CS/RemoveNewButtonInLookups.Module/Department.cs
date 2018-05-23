using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace RemoveNewButtonInLookups.Module {
    [DefaultClassOptions]
    [ImageName("BO_Department")]
    [System.ComponentModel.DefaultProperty("Title")]
    public class Department : BaseObject {
        private string title;
        private string office;
        public Department(Session session) : base(session) { }
        public string Title {
            get { return title; }
            set { SetPropertyValue("Title", ref title, value); }
        }
        public string Office {
            get { return office; }
            set { SetPropertyValue("Office", ref office, value); }
        }
        [Association("Department-Employees")]
        public XPCollection<Employee> Employees {
            get { return GetCollection<Employee>("Employees"); }
        }
    }
}
