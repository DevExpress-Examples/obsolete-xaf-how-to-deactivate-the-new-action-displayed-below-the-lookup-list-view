using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace RemoveNewButtonInLookups.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Department department = ObjectSpace.FindObject<Department>(
            CriteriaOperator.Parse("Title == 'Development Department'"));
            if (department == null) {
                department = ObjectSpace.CreateObject<Department>();
                department.Title = "Development Department";
                department.Office = "101";
                department.Save();
            }
            Employee employee = ObjectSpace.FindObject<Employee>(
            CriteriaOperator.Parse("FirstName == 'Robert' && LastName == 'King'"));
            if (employee == null) {
                employee = ObjectSpace.CreateObject<Employee>();
                employee.FirstName = "Robert";
                employee.LastName = "King";
                employee.Department = department;
                employee.Save();
            }

        }
    }
}
