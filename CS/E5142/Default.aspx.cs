using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

namespace E5142 {
    public partial class Default : System.Web.UI.Page {
        NWindEntities db = new NWindEntities();

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void documentViewer_CustomizeParameterEditors(object sender, DevExpress.XtraReports.Web.CustomizeParameterEditorsEventArgs e) {
            if (e.Parameter.Name == "Categories") {
                ASPxTokenBox customParameterEditor = new ASPxTokenBox() {
                    ID = "tbCategories"
                };
                e.Editor = customParameterEditor;
                customParameterEditor.Init += new EventHandler(customParameterEditor_Init);
            }
        }

        void customParameterEditor_Init(object sender, EventArgs e) {
            ASPxTokenBox customParameterEditor = sender as ASPxTokenBox;
            customParameterEditor.AllowCustomTokens = false;
            customParameterEditor.ShowDropDownOnFocus = ShowDropDownOnFocusMode.Always;

            customParameterEditor.ValueField = "CategoryID";
            customParameterEditor.TextField = "CategoryName";
            customParameterEditor.ValueSeparator = '|';

            customParameterEditor.DataSource = from category in db.Categories
                                               select category;
            customParameterEditor.DataBindItems();
        }
    }
}