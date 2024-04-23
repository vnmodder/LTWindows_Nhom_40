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

            var newData = data.Select(x => new
            {
                Masv = x.Id,
                Ten = x.Name,
                Lop = x.ClassId,
                Diem = x.Scores
            });

            var dataSource = new ReportDataSource("DataSet2", newData);
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Demo3Layer.BUS.Reports.Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            reportViewer1.LocalReport.SetParameters(new List<ReportParameter>() { new("tenLop", "aha") });
            reportViewer1.RefreshReport();
        }
    }
}
