using System;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid;

namespace FormattingViaEvents {
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
        }
        protected void CustomCellDisplayText(object sender, PivotCellDisplayTextEventArgs e) {
            if (e.RowValueType != PivotGridValueType.GrandTotal ||
                e.ColumnValueType == PivotGridValueType.GrandTotal) return;
            if (Convert.ToSingle(e.Value) < 50000)
                e.DisplayText = "Low";
            else if (Convert.ToSingle(e.Value) > 100000)
                e.DisplayText = "High";
            else
                e.DisplayText = "Middle";
        }
    }
}
