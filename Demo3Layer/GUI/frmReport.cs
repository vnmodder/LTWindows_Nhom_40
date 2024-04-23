using Demo3Layer.BUS;
using Microsoft.Reporting.WinForms;

namespace Demo3Layer.GUI
{
    public partial class frmReport : Form
    {
        private readonly StudentBUS _studentBUS;
        public frmReport()
        {
            InitializeComponent();
            _studentBUS = new StudentBUS();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            var data = _studentBUS.GetStudentsByClassId(0);
            var dataSource = new ReportDataSource("DataSet1", data);
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Demo3Layer.BUS.Reports.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            reportViewer1.LocalReport.SetParameters(new List<ReportParameter>() { new("testParam", "aha") });
            reportViewer1.RefreshReport();
        }
    }
}
