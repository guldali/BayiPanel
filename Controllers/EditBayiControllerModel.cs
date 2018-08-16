using System.Collections.Generic;
using System.Web.Mvc;
using Bootstrap.Model;

namespace Bootstrap.Controllers {
    public class EditBayiControllerModel {
        public BayiKart Bayi { get; set; }
        public IEnumerable<SelectListItem> LogLevels { get; set; }
        public IEnumerable<SelectListItem> SyncTables { get; set; }
        public IEnumerable<string> SelectedSyncTables { get; set; }
        public IEnumerable<string> SelectedLogLevels { get; set; }

        
    }
}
