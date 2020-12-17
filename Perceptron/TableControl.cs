using System.ComponentModel;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class TableControl : UserControl
    {
        public string GroupText
        {
            get => GroupBox.Text;
            set => GroupBox.Text = value;
        }

        [DefaultValue(1)]
        public int RowCount
        {
            get => DataGridView.RowCount;
            set => DataGridView.RowCount = value;
        }

        [DefaultValue(1)]
        public int ColumnCount
        {
            get => DataGridView.ColumnCount;
            set => DataGridView.ColumnCount = value;
        }

        public bool IsReadOnly
        {
            get => DataGridView.ReadOnly;
            set => DataGridView.ReadOnly = value;
        }

        public TableControl()
        {
            InitializeComponent();
            DataGridView.RowHeadersWidth = 100;
        }

        public void Suspend() => DataGridView.SuspendLayout();

        public void Resume() => DataGridView.ResumeLayout();

        public DataGridViewColumnCollection ColumnCollection => DataGridView.Columns;

        public DataGridViewRowCollection RowCollection => DataGridView.Rows;
    }
}
