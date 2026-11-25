using Navigation2;

namespace Navigation2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Notes", typeof(Notes));
        }
    }
}
