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
    [ImageName("BO_Person")]
    [DefaultProperty("FullName")]
    public class Employee : BaseObject {
        public Employee(Session session)
            : base(session) { }
        private string firstName;
        public string FirstName {
            get { return firstName; }
            set { SetPropertyValue("FirstName", ref firstName, value); }
        }
        private string lastName;
        public string LastName {
            get { return lastName; }
            set { SetPropertyValue("LastName", ref lastName, value); }
        }
        public string FullName {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        private Department department;
        [Association("Department-Employees")]
        public Department Department {
            get { return department; }
            set { SetPropertyValue("Department", ref department, value); }
        }
    }
}
