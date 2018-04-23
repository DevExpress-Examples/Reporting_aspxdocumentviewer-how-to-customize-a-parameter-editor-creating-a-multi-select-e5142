using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;

namespace E5142 {
    public partial class ProductsReport : DevExpress.XtraReports.UI.XtraReport {
        public ProductsReport() {
            InitializeComponent();
        }

        private void ProductsReport_DataSourceDemanded(object sender, EventArgs e) {
            string[] categories = Convert.ToString(this.Parameters["Categories"].Value).Split('|');
            List<int> selectedCategories = new List<int>();
            foreach (string category in categories) {
                int categoryID;
                if (Int32.TryParse(category, out categoryID)) {
                    selectedCategories.Add(categoryID);
                }
            }

            NWindEntities db = new NWindEntities();
            this.DataSource = from product in db.Products
                              where product.CategoryID.HasValue && selectedCategories.Contains(product.CategoryID.Value)
                              select product;
        }

    }
}
