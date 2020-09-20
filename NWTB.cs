using System.Windows.Forms;

namespace NotepadWithoutTopBar
{
    public partial class frmNWTB : Form
    {
        public frmNWTB()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey( ref Message msg, Keys keyData )
        {
            // Small steps
            if ( keyData == ( Keys.Left | Keys.Shift ) )
                Left--;

            if ( keyData == ( Keys.Right | Keys.Shift ) )
                Left++;

            if ( keyData == ( Keys.Up | Keys.Shift ) )
                Top--;

            if ( keyData == ( Keys.Down | Keys.Shift ) )
                Top++;

            // Big steps
            if ( keyData == ( Keys.Left | Keys.Control ) )
                Left -= 10;

            if ( keyData == ( Keys.Right | Keys.Control ) )
                Left += 10;

            if ( keyData == ( Keys.Up | Keys.Control ) )
                Top -= 10;

            if ( keyData == ( Keys.Down | Keys.Control ) )
                Top += 10;

            return base.ProcessCmdKey( ref msg, keyData );
        }
    }
}
